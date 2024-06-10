namespace EventTicketForms.Forms
{
    partial class AddTicketTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTicketTypeForm));
            label6 = new Label();
            label5 = new Label();
            TimeForSalesEnd = new DateTimePicker();
            DateForSalesEnd = new DateTimePicker();
            txtTotalTickets = new TextBox();
            TimeForSalesStart = new DateTimePicker();
            dateForSalesStart = new DateTimePicker();
            txtPrice = new TextBox();
            txtTicketTypeName = new TextBox();
            button2 = new Button();
            label1 = new Label();
            lblEventName = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label6.Location = new Point(40, 266);
            label6.Name = "label6";
            label6.Size = new Size(146, 24);
            label6.TabIndex = 140;
            label6.Text = "Sales End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label5.Location = new Point(40, 233);
            label5.Name = "label5";
            label5.Size = new Size(158, 24);
            label5.TabIndex = 139;
            label5.Text = "Sales Start Date";
            // 
            // TimeForSalesEnd
            // 
            TimeForSalesEnd.Format = DateTimePickerFormat.Time;
            TimeForSalesEnd.Location = new Point(329, 266);
            TimeForSalesEnd.Name = "TimeForSalesEnd";
            TimeForSalesEnd.ShowUpDown = true;
            TimeForSalesEnd.Size = new Size(87, 27);
            TimeForSalesEnd.TabIndex = 134;
            // 
            // DateForSalesEnd
            // 
            DateForSalesEnd.Format = DateTimePickerFormat.Short;
            DateForSalesEnd.Location = new Point(206, 266);
            DateForSalesEnd.Name = "DateForSalesEnd";
            DateForSalesEnd.Size = new Size(117, 27);
            DateForSalesEnd.TabIndex = 133;
            // 
            // txtTotalTickets
            // 
            txtTotalTickets.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalTickets.Location = new Point(159, 178);
            txtTotalTickets.Multiline = true;
            txtTotalTickets.Name = "txtTotalTickets";
            txtTotalTickets.PlaceholderText = "Total Tickets";
            txtTotalTickets.Size = new Size(154, 36);
            txtTotalTickets.TabIndex = 132;
            // 
            // TimeForSalesStart
            // 
            TimeForSalesStart.Format = DateTimePickerFormat.Time;
            TimeForSalesStart.Location = new Point(329, 233);
            TimeForSalesStart.Name = "TimeForSalesStart";
            TimeForSalesStart.ShowUpDown = true;
            TimeForSalesStart.Size = new Size(87, 27);
            TimeForSalesStart.TabIndex = 131;
            // 
            // dateForSalesStart
            // 
            dateForSalesStart.Format = DateTimePickerFormat.Short;
            dateForSalesStart.Location = new Point(206, 233);
            dateForSalesStart.Name = "dateForSalesStart";
            dateForSalesStart.Size = new Size(117, 27);
            dateForSalesStart.TabIndex = 130;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(183, 136);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(111, 36);
            txtPrice.TabIndex = 128;
            // 
            // txtTicketTypeName
            // 
            txtTicketTypeName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTicketTypeName.Location = new Point(118, 96);
            txtTicketTypeName.Multiline = true;
            txtTicketTypeName.Name = "txtTicketTypeName";
            txtTicketTypeName.PlaceholderText = "Ticket Type Name";
            txtTicketTypeName.Size = new Size(239, 34);
            txtTicketTypeName.TabIndex = 127;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(169, 320);
            button2.Name = "button2";
            button2.Size = new Size(144, 40);
            button2.TabIndex = 143;
            button2.Text = "Add New Type";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 144;
            label1.Text = "Event Name:";
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEventName.ForeColor = Color.Indigo;
            lblEventName.Location = new Point(136, 30);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(0, 20);
            lblEventName.TabIndex = 145;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(428, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 32);
            button1.TabIndex = 146;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddTicketTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 388);
            Controls.Add(button1);
            Controls.Add(lblEventName);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TimeForSalesEnd);
            Controls.Add(DateForSalesEnd);
            Controls.Add(txtTotalTickets);
            Controls.Add(TimeForSalesStart);
            Controls.Add(dateForSalesStart);
            Controls.Add(txtPrice);
            Controls.Add(txtTicketTypeName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTicketTypeForm";
            Text = "AddTicketTypeForm";
            Load += AddTicketTypeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtTicketsLeft;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private DateTimePicker TimeForSalesEnd;
        private DateTimePicker DateForSalesEnd;
        private TextBox txtTotalTickets;
        private DateTimePicker TimeForSalesStart;
        private DateTimePicker dateForSalesStart;
        private ComboBox comboBoxTicketType;
        private TextBox txtPrice;
        private TextBox txtTicketTypeName;
        private Button button2;
        private Label lblEventName;
        private Button button1;
    }
}