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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // readButton
            // 
            this.readButton.Enabled = false;
            this.readButton.Location = new System.Drawing.Point(700, 12);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(88, 29);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 186);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 290);
            this.dataGridView.TabIndex = 2;
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(150, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(183, 157);
            this.checkedListBox.TabIndex = 4;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // ascRadio
            // 
            this.ascRadio.AutoSize = true;
            this.ascRadio.Enabled = false;
            this.ascRadio.Location = new System.Drawing.Point(12, 123);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.descRadio);
            this.Controls.Add(this.ascRadio);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Ordering System";
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
        private RadioButton ascRadio;
        private RadioButton descRadio;
        private ComboBox orderBox;
        private Label label1;
        private Label label2;
    }
}

