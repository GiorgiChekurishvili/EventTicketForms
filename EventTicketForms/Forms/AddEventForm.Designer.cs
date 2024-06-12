namespace EventTicketForms
{
    partial class AddEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventForm));
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            btnAddTicket = new Button();
            txtDescription = new TextBox();
            txtCapacity = new TextBox();
            txtEventLocation = new TextBox();
            txtEventName = new TextBox();
            dateOfEvent = new DateTimePicker();
            TimeOfEvent = new DateTimePicker();
            comboBoxCategories = new ComboBox();
            btnImage = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(224, -88);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 79;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(193, -88);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 71;
            label1.Text = "id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(44, 38);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 94;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(419, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 32);
            button1.TabIndex = 88;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddTicket
            // 
            btnAddTicket.BackColor = Color.FromArgb(0, 192, 0);
            btnAddTicket.FlatAppearance.BorderSize = 0;
            btnAddTicket.FlatStyle = FlatStyle.Popup;
            btnAddTicket.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTicket.ForeColor = Color.White;
            btnAddTicket.Location = new Point(165, 615);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(144, 40);
            btnAddTicket.TabIndex = 86;
            btnAddTicket.Text = "Add Event";
            btnAddTicket.UseVisualStyleBackColor = false;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(90, 414);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Event Description";
            txtDescription.Size = new Size(286, 184);
            txtDescription.TabIndex = 84;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(265, 339);
            txtCapacity.Multiline = true;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.PlaceholderText = "Capacity";
            txtCapacity.Size = new Size(111, 36);
            txtCapacity.TabIndex = 82;
            // 
            // txtEventLocation
            // 
            txtEventLocation.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventLocation.Location = new Point(90, 299);
            txtEventLocation.Multiline = true;
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.PlaceholderText = "Event Location";
            txtEventLocation.Size = new Size(286, 34);
            txtEventLocation.TabIndex = 81;
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(90, 259);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.PlaceholderText = "Event Name";
            txtEventName.Size = new Size(286, 34);
            txtEventName.TabIndex = 80;
            // 
            // dateOfEvent
            // 
            dateOfEvent.Format = DateTimePickerFormat.Short;
            dateOfEvent.Location = new Point(90, 381);
            dateOfEvent.Name = "dateOfEvent";
            dateOfEvent.Size = new Size(169, 27);
            dateOfEvent.TabIndex = 96;
            // 
            // TimeOfEvent
            // 
            TimeOfEvent.Format = DateTimePickerFormat.Time;
            TimeOfEvent.Location = new Point(265, 381);
            TimeOfEvent.Name = "TimeOfEvent";
            TimeOfEvent.ShowUpDown = true;
            TimeOfEvent.Size = new Size(111, 27);
            TimeOfEvent.TabIndex = 97;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategories.Font = new Font("Bahnschrift", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCategories.ForeColor = Color.Black;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(90, 339);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(169, 35);
            comboBoxCategories.TabIndex = 98;
            comboBoxCategories.Tag = "";
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // btnImage
            // 
            btnImage.BackColor = Color.FromArgb(0, 192, 0);
            btnImage.FlatAppearance.BorderSize = 0;
            btnImage.FlatStyle = FlatStyle.Popup;
            btnImage.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImage.ForeColor = Color.White;
            btnImage.Location = new Point(280, 83);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(144, 40);
            btnImage.TabIndex = 99;
            btnImage.Text = "Upload Image";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 667);
            Controls.Add(btnImage);
            Controls.Add(comboBoxCategories);
            Controls.Add(TimeOfEvent);
            Controls.Add(dateOfEvent);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnAddTicket);
            Controls.Add(txtDescription);
            Controls.Add(txtCapacity);
            Controls.Add(txtEventLocation);
            Controls.Add(txtEventName);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEventForm";
            Load += AddEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Button button1;
        private Button btnAddFavorites;
        private Button btnAddTicket;
        private TextBox txtDescription;
        private TextBox txtCapacity;
        private TextBox txtEventLocation;
        private TextBox txtEventName;
        private DateTimePicker dateOfEvent;
        private DateTimePicker TimeOfEvent;
        private ComboBox comboBoxCategories;
        private Button btnImage;
    }
}