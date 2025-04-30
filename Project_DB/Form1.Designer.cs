using System.Collections.Generic;
using System.Windows.Forms;


namespace Project_DB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>


        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.readButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.ascRadio = new System.Windows.Forms.RadioButton();
            this.descRadio = new System.Windows.Forms.RadioButton();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 33);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // readButton
            // 
            this.readButton.Enabled = false;
            this.readButton.Location = new System.Drawing.Point(824, 5);
            this.readButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(88, 30);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 186);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(459, 290);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(149, 12);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(183, 140);
            this.checkedListBox.TabIndex = 4;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // ascRadio
            // 
            this.ascRadio.AutoSize = true;
            this.ascRadio.Enabled = false;
            this.ascRadio.Location = new System.Drawing.Point(12, 123);
            this.ascRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ascRadio.Name = "ascRadio";
            this.ascRadio.Size = new System.Drawing.Size(92, 20);
            this.ascRadio.TabIndex = 5;
            this.ascRadio.TabStop = true;
            this.ascRadio.Text = "Ascending";
            this.ascRadio.UseVisualStyleBackColor = true;
            // 
            // descRadio
            // 
            this.descRadio.AutoSize = true;
            this.descRadio.Enabled = false;
            this.descRadio.Location = new System.Drawing.Point(12, 149);
            this.descRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descRadio.Name = "descRadio";
            this.descRadio.Size = new System.Drawing.Size(101, 20);
            this.descRadio.TabIndex = 6;
            this.descRadio.TabStop = true;
            this.descRadio.Text = "Descending";
            this.descRadio.UseVisualStyleBackColor = true;
            // 
            // orderBox
            // 
            this.orderBox.Enabled = false;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(12, 87);
            this.orderBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(121, 24);
            this.orderBox.TabIndex = 7;
            this.orderBox.SelectedIndexChanged += new System.EventHandler(this.orderBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Table";
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(824, 39);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Location = new System.Drawing.Point(478, 13);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(319, 464);
            this.inputPanel.TabIndex = 10;
            this.inputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inputPanel_Paint);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(824, 73);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(88, 30);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(824, 113);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 30);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 487);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.descRadio);
            this.Controls.Add(this.ascRadio);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Panel inputPanel;

        private RadioButton ascRadio;
        private RadioButton descRadio;
        private ComboBox orderBox;
        private Label label1;
        private Label label2;
        private Button deleteButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button insertButton;
        private Button updateButton;
    }
}

