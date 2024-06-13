namespace EventTicketForms.Forms
{
    partial class AddFundsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFundsForm));
            txtCreditCardNumber = new TextBox();
            txtValidThru = new TextBox();
            txtCVC = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnAddFunds = new Button();
            button2 = new Button();
            label3 = new Label();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // txtCreditCardNumber
            // 
            txtCreditCardNumber.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCreditCardNumber.Location = new Point(246, 136);
            txtCreditCardNumber.MaxLength = 19;
            txtCreditCardNumber.Multiline = true;
            txtCreditCardNumber.Name = "txtCreditCardNumber";
            txtCreditCardNumber.Size = new Size(402, 32);
            txtCreditCardNumber.TabIndex = 81;
            txtCreditCardNumber.TextChanged += txtCreditCardNumber_TextChanged;
            // 
            // txtValidThru
            // 
            txtValidThru.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValidThru.Location = new Point(246, 192);
            txtValidThru.MaxLength = 5;
            txtValidThru.Multiline = true;
            txtValidThru.Name = "txtValidThru";
            txtValidThru.Size = new Size(76, 32);
            txtValidThru.TabIndex = 82;
            txtValidThru.TextChanged += txtValidThru_TextChanged;
            // 
            // txtCVC
            // 
            txtCVC.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCVC.Location = new Point(563, 192);
            txtCVC.MaxLength = 3;
            txtCVC.Multiline = true;
            txtCVC.Name = "txtCVC";
            txtCVC.Size = new Size(85, 32);
            txtCVC.TabIndex = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label7.Location = new Point(49, 142);
            label7.Name = "label7";
            label7.Size = new Size(191, 24);
            label7.TabIndex = 102;
            label7.Text = "Credit Card Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label1.Location = new Point(121, 198);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 103;
            label1.Text = "VALID THRU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label2.Location = new Point(511, 198);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 104;
            label2.Text = "CVC";
            // 
            // btnAddFunds
            // 
            btnAddFunds.BackColor = Color.FromArgb(0, 192, 0);
            btnAddFunds.FlatAppearance.BorderSize = 0;
            btnAddFunds.FlatStyle = FlatStyle.Popup;
            btnAddFunds.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFunds.ForeColor = Color.White;
            btnAddFunds.Location = new Point(358, 341);
            btnAddFunds.Name = "btnAddFunds";
            btnAddFunds.Size = new Size(144, 40);
            btnAddFunds.TabIndex = 105;
            btnAddFunds.Text = "Add Funds";
            btnAddFunds.UseVisualStyleBackColor = false;
            btnAddFunds.Click += btnAddFunds_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(761, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 32);
            button2.TabIndex = 106;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label3.Location = new Point(166, 274);
            label3.Name = "label3";
            label3.Size = new Size(186, 24);
            label3.TabIndex = 107;
            label3.Text = "Amount To Transfer";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(373, 268);
            txtAmount.MaxLength = 5;
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(208, 32);
            txtAmount.TabIndex = 108;
            // 
            // AddFundsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnAddFunds);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(txtCVC);
            Controls.Add(txtValidThru);
            Controls.Add(txtCreditCardNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddFundsForm";
            Text = "AddFundsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreditCardNumber;
        private TextBox txtValidThru;
        private TextBox txtCVC;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button btnAddFunds;
        private Button button2;
        private Label label3;
        private TextBox txtAmount;
    }
}