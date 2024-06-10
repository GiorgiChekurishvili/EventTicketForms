namespace EventTicketForms
{
    partial class TicketTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketTypeForm));
            TimeForSalesStart = new DateTimePicker();
            dateForSalesStart = new DateTimePicker();
            comboBoxTicketType = new ComboBox();
            txtPrice = new TextBox();
            txtEventName = new TextBox();
            txtTotalTickets = new TextBox();
            TimeForSalesEnd = new DateTimePicker();
            DateForSalesEnd = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTicketsLeft = new TextBox();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // TimeForSalesStart
            // 
            TimeForSalesStart.Format = DateTimePickerFormat.Time;
            TimeForSalesStart.Location = new Point(312, 355);
            TimeForSalesStart.Name = "TimeForSalesStart";
            TimeForSalesStart.ShowUpDown = true;
            TimeForSalesStart.Size = new Size(87, 27);
            TimeForSalesStart.TabIndex = 115;
            // 
            // dateForSalesStart
            // 
            dateForSalesStart.Format = DateTimePickerFormat.Short;
            dateForSalesStart.Location = new Point(189, 355);
            dateForSalesStart.Name = "dateForSalesStart";
            dateForSalesStart.Size = new Size(117, 27);
            dateForSalesStart.TabIndex = 114;
            // 
            // comboBoxTicketType
            // 
            comboBoxTicketType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTicketType.Font = new Font("Bahnschrift", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxTicketType.ForeColor = Color.Black;
            comboBoxTicketType.FormattingEnabled = true;
            comboBoxTicketType.Location = new Point(153, 117);
            comboBoxTicketType.Name = "comboBoxTicketType";
            comboBoxTicketType.Size = new Size(246, 35);
            comboBoxTicketType.TabIndex = 112;
            comboBoxTicketType.Tag = "";
            comboBoxTicketType.SelectedIndexChanged += comboBoxTicketType_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(288, 198);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(111, 36);
            txtPrice.TabIndex = 105;
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(245, 158);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.PlaceholderText = "Event Name";
            txtEventName.Size = new Size(154, 34);
            txtEventName.TabIndex = 103;
            // 
            // txtTotalTickets
            // 
            txtTotalTickets.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalTickets.Location = new Point(245, 240);
            txtTotalTickets.Multiline = true;
            txtTotalTickets.Name = "txtTotalTickets";
            txtTotalTickets.PlaceholderText = "Total Tickets";
            txtTotalTickets.Size = new Size(154, 36);
            txtTotalTickets.TabIndex = 116;
            // 
            // TimeForSalesEnd
            // 
            TimeForSalesEnd.Format = DateTimePickerFormat.Time;
            TimeForSalesEnd.Location = new Point(312, 388);
            TimeForSalesEnd.Name = "TimeForSalesEnd";
            TimeForSalesEnd.ShowUpDown = true;
            TimeForSalesEnd.Size = new Size(87, 27);
            TimeForSalesEnd.TabIndex = 118;
            // 
            // DateForSalesEnd
            // 
            DateForSalesEnd.Format = DateTimePickerFormat.Short;
            DateForSalesEnd.Location = new Point(189, 388);
            DateForSalesEnd.Name = "DateForSalesEnd";
            DateForSalesEnd.Size = new Size(117, 27);
            DateForSalesEnd.TabIndex = 117;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label3.Location = new Point(23, 128);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 119;
            label3.Text = "Ticket Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label1.Location = new Point(96, 164);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 120;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label2.Location = new Point(139, 204);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 121;
            label2.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label4.Location = new Point(105, 246);
            label4.Name = "label4";
            label4.Size = new Size(123, 24);
            label4.TabIndex = 122;
            label4.Text = "Total Tickets";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label5.Location = new Point(23, 355);
            label5.Name = "label5";
            label5.Size = new Size(158, 24);
            label5.TabIndex = 123;
            label5.Text = "Sales Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label6.Location = new Point(23, 388);
            label6.Name = "label6";
            label6.Size = new Size(146, 24);
            label6.TabIndex = 124;
            label6.Text = "Sales End Date";
            // 
            // txtTicketsLeft
            // 
            txtTicketsLeft.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTicketsLeft.Location = new Point(245, 282);
            txtTicketsLeft.Multiline = true;
            txtTicketsLeft.Name = "txtTicketsLeft";
            txtTicketsLeft.PlaceholderText = "Tickets Left";
            txtTicketsLeft.ReadOnly = true;
            txtTicketsLeft.Size = new Size(154, 36);
            txtTicketsLeft.TabIndex = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label7.Location = new Point(105, 294);
            label7.Name = "label7";
            label7.Size = new Size(114, 24);
            label7.TabIndex = 126;
            label7.Text = "Tickets Left";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(255, 60);
            button2.Name = "button2";
            button2.Size = new Size(144, 40);
            button2.TabIndex = 127;
            button2.Text = "Add New Type";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 448);
            button1.Name = "button1";
            button1.Size = new Size(144, 40);
            button1.TabIndex = 128;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(245, 448);
            button3.Name = "button3";
            button3.Size = new Size(144, 40);
            button3.TabIndex = 129;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(384, 0);
            button4.Name = "button4";
            button4.Size = new Size(39, 32);
            button4.TabIndex = 130;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TicketTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 509);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(txtTicketsLeft);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(TimeForSalesEnd);
            Controls.Add(DateForSalesEnd);
            Controls.Add(txtTotalTickets);
            Controls.Add(TimeForSalesStart);
            Controls.Add(dateForSalesStart);
            Controls.Add(comboBoxTicketType);
            Controls.Add(txtPrice);
            Controls.Add(txtEventName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicketTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketTypeForm";
            Load += TicketTypeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker TimeForSalesStart;
        private DateTimePicker dateForSalesStart;
        private ComboBox comboBoxTicketType;
        private TextBox txtPrice;
        private TextBox txtEventName;
        private TextBox txtTotalTickets;
        private DateTimePicker TimeForSalesEnd;
        private DateTimePicker DateForSalesEnd;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTicketsLeft;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}