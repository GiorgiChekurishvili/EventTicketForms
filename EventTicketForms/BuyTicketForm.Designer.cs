namespace EventTicketForms
{
    partial class BuyTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicketForm));
            comboboxTicketType = new ComboBox();
            numTicketsQuantity = new NumericUpDown();
            btnBuyTicket = new Button();
            label4 = new Label();
            lblEventName = new Label();
            label1 = new Label();
            button1 = new Button();
            label10 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            lblPrice = new Label();
            lblTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numTicketsQuantity).BeginInit();
            SuspendLayout();
            // 
            // comboboxTicketType
            // 
            comboboxTicketType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxTicketType.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboboxTicketType.ForeColor = SystemColors.WindowFrame;
            comboboxTicketType.FormattingEnabled = true;
            comboboxTicketType.Location = new Point(68, 68);
            comboboxTicketType.Name = "comboboxTicketType";
            comboboxTicketType.Size = new Size(286, 30);
            comboboxTicketType.TabIndex = 67;
            comboboxTicketType.Tag = "";
            comboboxTicketType.SelectedIndexChanged += txtTicketType_SelectedIndexChanged;
            // 
            // numTicketsQuantity
            // 
            numTicketsQuantity.Location = new Point(134, 269);
            numTicketsQuantity.Name = "numTicketsQuantity";
            numTicketsQuantity.Size = new Size(150, 27);
            numTicketsQuantity.TabIndex = 68;
            numTicketsQuantity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.BackColor = Color.FromArgb(0, 192, 0);
            btnBuyTicket.FlatAppearance.BorderSize = 0;
            btnBuyTicket.FlatStyle = FlatStyle.Popup;
            btnBuyTicket.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuyTicket.ForeColor = Color.White;
            btnBuyTicket.Location = new Point(134, 389);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.Size = new Size(144, 40);
            btnBuyTicket.TabIndex = 69;
            btnBuyTicket.Text = "Buy Ticket";
            btnBuyTicket.UseVisualStyleBackColor = false;
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label4.Location = new Point(134, 349);
            label4.Name = "label4";
            label4.Size = new Size(111, 24);
            label4.TabIndex = 70;
            label4.Text = "Total Price:";
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            lblEventName.Location = new Point(12, 9);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(124, 24);
            lblEventName.TabIndex = 72;
            lblEventName.Text = "Event Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label1.Location = new Point(26, 272);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 73;
            label1.Text = "Quantity";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(392, 1);
            button1.Name = "button1";
            button1.Size = new Size(39, 32);
            button1.TabIndex = 74;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label10.Location = new Point(17, 101);
            label10.Name = "label10";
            label10.Size = new Size(126, 24);
            label10.TabIndex = 75;
            label10.Text = "Ticket Price: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 76;
            label3.Text = "Sales Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(146, 24);
            label5.TabIndex = 77;
            label5.Text = "Sales End Date";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStartDate.Location = new Point(167, 142);
            txtStartDate.Multiline = true;
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(250, 34);
            txtStartDate.TabIndex = 78;
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEndDate.Location = new Point(164, 187);
            txtEndDate.Multiline = true;
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(253, 34);
            txtEndDate.TabIndex = 79;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            lblPrice.Location = new Point(143, 101);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 24);
            lblPrice.TabIndex = 80;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(245, 349);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 24);
            lblTotalPrice.TabIndex = 81;
            // 
            // BuyTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblEventName);
            Controls.Add(label4);
            Controls.Add(btnBuyTicket);
            Controls.Add(numTicketsQuantity);
            Controls.Add(comboboxTicketType);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyTicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuyTicketForm";
            Load += BuyTicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)numTicketsQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboboxTicketType;
        private NumericUpDown numTicketsQuantity;
        private Button btnBuyTicket;
        private Label label4;
        private Label lblEventName;
        private Label label1;
        private Button button1;
        private Label label10;
        private Label label3;
        private Label label5;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private Label lblPrice;
        private Label lblTotalPrice;
    }
}