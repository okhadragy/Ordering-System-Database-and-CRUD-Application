namespace Project_DB
{
    partial class ViewData
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.readButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.ascRadio = new System.Windows.Forms.RadioButton();
            this.descRadio = new System.Windows.Forms.RadioButton();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.comboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(194, 13);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(220, 27);
            this.comboBox.TabIndex = 0;
            // 
            // readButton
            // 
            this.readButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.readButton.FlatAppearance.BorderSize = 3;
            this.readButton.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.readButton.Location = new System.Drawing.Point(84, 178);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(162, 47);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "View";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Location = new System.Drawing.Point(157, 231);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.Size = new System.Drawing.Size(600, 250);
            this.dataGridView.TabIndex = 8;
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.checkedListBox.ForeColor = System.Drawing.Color.White;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(612, 105);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(200, 92);
            this.checkedListBox.TabIndex = 3;
            // 
            // ascRadio
            // 
            this.ascRadio.BackColor = System.Drawing.Color.Transparent;
            this.ascRadio.Location = new System.Drawing.Point(194, 148);
            this.ascRadio.Name = "ascRadio";
            this.ascRadio.Size = new System.Drawing.Size(104, 24);
            this.ascRadio.TabIndex = 6;
            this.ascRadio.Text = "ASC";
            this.ascRadio.UseVisualStyleBackColor = false;
            this.ascRadio.CheckedChanged += new System.EventHandler(this.ascRadio_CheckedChanged);
            // 
            // descRadio
            // 
            this.descRadio.Location = new System.Drawing.Point(310, 148);
            this.descRadio.Name = "descRadio";
            this.descRadio.Size = new System.Drawing.Size(104, 24);
            this.descRadio.TabIndex = 7;
            this.descRadio.Text = "DESC";
            this.descRadio.UseVisualStyleBackColor = false;
            this.descRadio.CheckedChanged += new System.EventHandler(this.descRadio_CheckedChanged);
            // 
            // orderBox
            // 
            this.orderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.orderBox.ForeColor = System.Drawing.SystemColors.Window;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(194, 105);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(220, 27);
            this.orderBox.TabIndex = 4;
            // 
            // labelTable
            // 
            this.labelTable.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.Location = new System.Drawing.Point(5, 7);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(241, 37);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "Select Table";
            // 
            // labelOrder
            // 
            this.labelOrder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(79, 101);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(167, 47);
            this.labelOrder.TabIndex = 5;
            this.labelOrder.Text = "Order By";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filters:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Columns";
            // 
            // ViewData
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.ascRadio);
            this.Controls.Add(this.descRadio);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewData";
            this.Size = new System.Drawing.Size(978, 612);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.RadioButton ascRadio;
        private System.Windows.Forms.RadioButton descRadio;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
