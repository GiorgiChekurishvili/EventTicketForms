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
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddFavorites
            // 
            btnAddFavorites.BackColor = Color.Orange;
            btnAddFavorites.FlatStyle = FlatStyle.Flat;
            btnAddFavorites.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFavorites.ForeColor = Color.White;
            btnAddFavorites.Location = new Point(43, 672);
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
            btnBuyTicket.Location = new Point(581, 672);
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
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 56;
            label1.Text = "id:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(306, 460);
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
            txtCapacity.Location = new Point(466, 337);
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
            txtEventLocation.Location = new Point(306, 297);
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
            txtEventName.Location = new Point(306, 257);
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
            button1.Location = new Point(722, 0);
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
            label2.Location = new Point(146, 263);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 60;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label3.Location = new Point(146, 303);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 61;
            label3.Text = "Event Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label4.Location = new Point(373, 343);
            label4.Name = "label4";
            label4.Size = new Size(87, 24);
            label4.TabIndex = 62;
            label4.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            label5.Location = new Point(146, 388);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 63;
            label5.Text = "Event Date (d/m/y)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold);
            label6.Location = new Point(146, 460);
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
            btnUpdate.Location = new Point(581, 662);
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
            btnDelete.Location = new Point(43, 662);
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
            comboBoxCategories.Location = new Point(408, 419);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(169, 35);
            comboBoxCategories.TabIndex = 99;
            comboBoxCategories.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label7.Location = new Point(310, 424);
            label7.Name = "label7";
            label7.Size = new Size(92, 24);
            label7.TabIndex = 100;
            label7.Text = "Category";
            // 
            // dateForEvent
            // 
            dateForEvent.Enabled = false;
            dateForEvent.Format = DateTimePickerFormat.Short;
            dateForEvent.Location = new Point(306, 384);
            dateForEvent.Name = "dateForEvent";
            dateForEvent.Size = new Size(141, 27);
            dateForEvent.TabIndex = 101;
            // 
            // TimeForEvent
            // 
            TimeForEvent.Enabled = false;
            TimeForEvent.Format = DateTimePickerFormat.Time;
            TimeForEvent.Location = new Point(453, 384);
            TimeForEvent.Name = "TimeForEvent";
            TimeForEvent.ShowUpDown = true;
            TimeForEvent.Size = new Size(124, 27);
            TimeForEvent.TabIndex = 102;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(330, 672);
            button2.Name = "button2";
            button2.Size = new Size(144, 40);
            button2.TabIndex = 103;
            button2.Text = "See Ticket Types";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(49, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // EventShowFullyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 724);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button2;
        private PictureBox pictureBox1;
    }
}