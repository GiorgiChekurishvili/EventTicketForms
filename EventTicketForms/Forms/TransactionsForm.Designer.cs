namespace EventTicketForms.Forms
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            dataGridView1 = new DataGridView();
            btnAddFunds = new Button();
            label7 = new Label();
            button2 = new Button();
            lblBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1410, 440);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddFunds
            // 
            btnAddFunds.BackColor = Color.FromArgb(0, 192, 0);
            btnAddFunds.FlatAppearance.BorderSize = 0;
            btnAddFunds.FlatStyle = FlatStyle.Popup;
            btnAddFunds.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFunds.ForeColor = Color.White;
            btnAddFunds.Location = new Point(667, 99);
            btnAddFunds.Name = "btnAddFunds";
            btnAddFunds.Size = new Size(144, 40);
            btnAddFunds.TabIndex = 58;
            btnAddFunds.Text = "Add Funds";
            btnAddFunds.UseVisualStyleBackColor = false;
            btnAddFunds.Click += btnAddFunds_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label7.Location = new Point(566, 53);
            label7.Name = "label7";
            label7.Size = new Size(88, 24);
            label7.TabIndex = 101;
            label7.Text = "Balance:";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1371, -3);
            button2.Name = "button2";
            button2.Size = new Size(39, 32);
            button2.TabIndex = 102;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            lblBalance.Location = new Point(654, 53);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(0, 24);
            lblBalance.TabIndex = 103;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 586);
            Controls.Add(lblBalance);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(btnAddFunds);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMyBalanceForm";
            Load += TransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddFunds;
        private Label label7;
        private Button button2;
        private Label lblBalance;
    }
}