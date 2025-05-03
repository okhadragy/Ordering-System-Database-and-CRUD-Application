namespace Project_DB
{
    partial class InsertData
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.comboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(211, 13);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(248, 32);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.inputPanel.ForeColor = System.Drawing.Color.White;
            this.inputPanel.Location = new System.Drawing.Point(211, 137);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(400, 270);
            this.inputPanel.TabIndex = 3;
            this.inputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inputPanel_Paint);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.insertButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(211, 419);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(134, 57);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // labelTable
            // 
            this.labelTable.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.Location = new System.Drawing.Point(5, 7);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(200, 32);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "Select Table";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(5, 86);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(297, 48);
            this.labelInstructions.TabIndex = 2;
            this.labelInstructions.Text = "Enter data to insert";
            // 
            // InsertData
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.insertButton);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsertData";
            this.Size = new System.Drawing.Size(650, 589);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Label labelInstructions;
    }
}
