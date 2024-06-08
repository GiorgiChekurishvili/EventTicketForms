namespace EventTicketForms
{
    partial class EventShowFullyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventShowFullyForm));
            btnAddFavorites = new Button();
            btnBuyTicket = new Button();
            label1 = new Label();
            txtDescription = new TextBox();
            txtCapacity = new TextBox();
            txtEventLocation = new TextBox();
            txtEventName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblid = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            comboBoxCategories = new ComboBox();
            label7 = new Label();
            dateForEvent = new DateTimePicker();
            TimeForEvent = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAddFavorites
            // 
            btnAddFavorites.BackColor = Color.Orange;
            btnAddFavorites.FlatStyle = FlatStyle.Flat;
            btnAddFavorites.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFavorites.ForeColor = Color.White;
            btnAddFavorites.Location = new Point(32, 625);
            btnAddFavorites.Name = "btnAddFavorites";
            btnAddFavorites.Size = new Size(144, 40);
            btnAddFavorites.TabIndex = 58;
            btnAddFavorites.Text = "Favorite Event";
            btnAddFavorites.UseVisualStyleBackColor = false;
            btnAddFavorites.Click += btnAddFavorites_Click;
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.BackColor = Color.FromArgb(0, 192, 0);
            btnBuyTicket.FlatAppearance.BorderSize = 0;
            btnBuyTicket.FlatStyle = FlatStyle.Popup;
            btnBuyTicket.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuyTicket.ForeColor = Color.White;
            btnBuyTicket.Location = new Point(266, 625);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.Size = new Size(144, 40);
            btnBuyTicket.TabIndex = 57;
            btnBuyTicket.Text = "Buy Ticket";
            btnBuyTicket.UseVisualStyleBackColor = false;
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(9, 38);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 56;
            label1.Text = "id:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(172, 413);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Event Description";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(271, 184);
            txtDescription.TabIndex = 51;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(332, 290);
            txtCapacity.Multiline = true;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.PlaceholderText = "Capacity";
            txtCapacity.ReadOnly = true;
            txtCapacity.Size = new Size(111, 36);
            txtCapacity.TabIndex = 48;
            // 
            // txtEventLocation
            // 
            txtEventLocation.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventLocation.Location = new Point(172, 250);
            txtEventLocation.Multiline = true;
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.PlaceholderText = "Event Location";
            txtEventLocation.ReadOnly = true;
            txtEventLocation.Size = new Size(271, 34);
            txtEventLocation.TabIndex = 46;
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(172, 210);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.PlaceholderText = "Event Name";
            txtEventName.ReadOnly = true;
            txtEventName.Size = new Size(271, 34);
            txtEventName.TabIndex = 45;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(418, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 32);
            button1.TabIndex = 59;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label2.Location = new Point(12, 216);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 60;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label3.Location = new Point(12, 256);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 61;
            label3.Text = "Event Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label4.Location = new Point(239, 296);
            label4.Name = "label4";
            label4.Size = new Size(87, 24);
            label4.TabIndex = 62;
            label4.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 63;
            label5.Text = "Event Date (d/m/y)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold);
            label6.Location = new Point(12, 413);
            label6.Name = "label6";
            label6.Size = new Size(155, 22);
            label6.TabIndex = 64;
            label6.Text = "Event Description";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.ForeColor = Color.Indigo;
            lblid.Location = new Point(43, 38);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 20);
            lblid.TabIndex = 65;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(266, 615);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 40);
            btnUpdate.TabIndex = 66;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(32, 615);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 40);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategories.Font = new Font("Bahnschrift", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCategories.ForeColor = Color.Black;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(274, 372);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(169, 35);
            comboBoxCategories.TabIndex = 99;
            comboBoxCategories.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label7.Location = new Point(176, 377);
            label7.Name = "label7";
            label7.Size = new Size(92, 24);
            label7.TabIndex = 100;
            label7.Text = "Category";
            // 
            // dateForEvent
            // 
            dateForEvent.Enabled = false;
            dateForEvent.Format = DateTimePickerFormat.Short;
            dateForEvent.Location = new Point(172, 337);
            dateForEvent.Name = "dateForEvent";
            dateForEvent.Size = new Size(141, 27);
            dateForEvent.TabIndex = 101;
            // 
            // TimeForEvent
            // 
            TimeForEvent.Enabled = false;
            TimeForEvent.Format = DateTimePickerFormat.Time;
            TimeForEvent.Location = new Point(319, 337);
            TimeForEvent.Name = "TimeForEvent";
            TimeForEvent.ShowUpDown = true;
            TimeForEvent.Size = new Size(124, 27);
            TimeForEvent.TabIndex = 102;
            // 
            // EventShowFullyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 667);
            Controls.Add(TimeForEvent);
            Controls.Add(dateForEvent);
            Controls.Add(label7);
            Controls.Add(comboBoxCategories);
            Controls.Add(btnAddFavorites);
            Controls.Add(btnDelete);
            Controls.Add(btnBuyTicket);
            Controls.Add(btnUpdate);
            Controls.Add(lblid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCapacity);
            Controls.Add(txtEventLocation);
            Controls.Add(txtEventName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventShowFullyForm";
            Text = "RemoveFavoriteForm";
            Load += EventModifier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddFavorites;
        private Button btnBuyTicket;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtCapacity;
        private TextBox txtEventLocation;
        private TextBox txtEventName;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblid;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox comboBoxCategories;
        private Label label7;
        private DateTimePicker dateForEvent;
        private DateTimePicker TimeForEvent;
    }
}