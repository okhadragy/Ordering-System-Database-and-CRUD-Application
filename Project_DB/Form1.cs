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
            con = new SqlConnection("Data Source=LAPTOP-68C2HGIQ;Initial Catalog=\"Ordering System\";Integrated Security=True;");
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

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

        private List<string> primaryKeys = new List<string>();

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

            // Get primary key columns for the selected table
            SqlCommand pkCmd = new SqlCommand("EXEC sp_pkeys '" + comboBox.SelectedItem.ToString() + "'", con);
            SqlDataReader pkReader = pkCmd.ExecuteReader();

            primaryKeys = new List<string>();

            while (pkReader.Read())
            {
                primaryKeys.Add(pkReader["COLUMN_NAME"].ToString());
            }
            pkReader.Close();

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
                if (primaryKeys.Contains(rdr.GetName(i)))
                {
                    checkedListBox.ItemCheck += (sender2, ev) =>
                    {
                        if (primaryKeys.Contains(checkedListBox.Items[ev.Index].ToString()) && ev.NewValue == CheckState.Unchecked)
                        {
                            ev.NewValue = CheckState.Checked;
                        }
                    };
                }
            }

            con.Close();
            rdr.Close();
        }

        // prevent read button when no columns are checked
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && !dataGridView.SelectedRows[0].IsNewRow)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    string deleteQuery = "DELETE FROM " + comboBox.SelectedItem.ToString() + " WHERE ";

                    List<string> conditions = new List<string>();

                    foreach (string pk in primaryKeys)
                    {
                        string pkValue = row.Cells[pk].Value.ToString();
                        conditions.Add(pk + " = '" + pkValue + "'");
                    }

                    deleteQuery += string.Join(" AND ", conditions);
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record(s) deleted successfully!");

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + comboBox.SelectedItem.ToString(), con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
