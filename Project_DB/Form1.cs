using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_DB
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=LAPTOP-VOK6VQOD;Initial Catalog=\"Ordering System\";Integrated Security=True");

            comboBox.Text = "Select Table";
            comboBox.Items.Add("Cart");
            comboBox.Items.Add("Cart_MenuItem");
            comboBox.Items.Add("Customer");
            comboBox.Items.Add("Employee");
            comboBox.Items.Add("Menu_Item");
            comboBox.Items.Add("Order_MenuItem");
            comboBox.Items.Add("OrderTable");
            comboBox.Items.Add("Restaurant");
            comboBox.Items.Add("Restaurant_Address");
            comboBox.Items.Add("UserTable");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            con.Open();

            string colString = "";
            for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
            {
                colString += checkedListBox.CheckedItems[i].ToString();
                if (i != checkedListBox.CheckedItems.Count - 1) colString += ", ";
            }

            string order = "NO ORDER";
            if (ascRadio.Checked) order = "ASC";
            else if (descRadio.Checked) order = "DESC";

            if (order == "NO ORDER")
            {
                cmd = new SqlCommand("SELECT " + colString + " FROM " + comboBox.SelectedItem.ToString(), con);
            }
            else
            {
                cmd = new SqlCommand("SELECT " + colString + " FROM " + comboBox.SelectedItem.ToString()
                    + " ORDER BY " + orderBox.SelectedItem.ToString() + " " + order, con);
            }

            rdr = cmd.ExecuteReader();

            dt = new DataTable();
            dt.Load(rdr);
            dataGridView.DataSource = dt;

            con.Close();
            rdr.Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent read button and order box when no selection
            if (comboBox.SelectedItem != null)
            {
                readButton.Enabled = true; 
                orderBox.Enabled = true;
            }

            con.Open();

            cmd = new SqlCommand("SELECT * FROM " + comboBox.SelectedItem.ToString(), con);
            rdr = cmd.ExecuteReader();

            checkedListBox.Items.Clear();
            orderBox.Items.Clear();
            orderBox.Items.Add("No order");
            orderBox.SelectedItem = "No order";

            for (int i = 0; i < rdr.FieldCount; i++)
            {
                checkedListBox.Items.Add(rdr.GetName(i));
                checkedListBox.SetItemChecked(i, true);

                orderBox.Items.Add(rdr.GetName(i));
            }

            con.Close();
            rdr.Close();
        }

        // prevent read button when no columns are checked
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int newCheckedCount = checkedListBox.CheckedItems.Count;

            // if checking a new item
            if (e.NewValue == CheckState.Checked)
                newCheckedCount++;
            else if (e.NewValue == CheckState.Unchecked)
                newCheckedCount--;

            readButton.Enabled = newCheckedCount > 0;
        }

        private void orderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderBox.SelectedItem != null && (string)orderBox.SelectedItem != "No order")
            {
                ascRadio.Checked = true;

                ascRadio.Enabled = true;
                descRadio.Enabled = true;
            }
            else
            {
                ascRadio.Checked = false;
                descRadio.Checked = false;

                ascRadio.Enabled = false;
                descRadio.Enabled = false;
            }
        }
    }
}
