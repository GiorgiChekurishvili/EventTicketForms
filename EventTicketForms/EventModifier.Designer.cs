namespace EventTicketForms
{
    partial class EventModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventModifier));
            btnAddFavorites = new Button();
            btnBuyTicket = new Button();
            label1 = new Label();
            txtDescription = new TextBox();
            txtDate = new TextBox();
            txtCapacity = new TextBox();
            txtEventLocation = new TextBox();
            txtEventName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAddFavorites
            // 
            btnAddFavorites.BackColor = Color.Orange;
            btnAddFavorites.FlatStyle = FlatStyle.Flat;
            btnAddFavorites.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFavorites.ForeColor = Color.White;
            btnAddFavorites.Location = new Point(33, 625);
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
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 56;
            label1.Text = "id:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(157, 413);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Event Description";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(286, 184);
            txtDescription.TabIndex = 51;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(157, 342);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "Event Date";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(286, 34);
            txtDate.TabIndex = 50;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(332, 292);
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
            txtEventLocation.Location = new Point(157, 252);
            txtEventLocation.Multiline = true;
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.PlaceholderText = "Event Location";
            txtEventLocation.ReadOnly = true;
            txtEventLocation.Size = new Size(286, 34);
            txtEventLocation.TabIndex = 46;
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(157, 175);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.PlaceholderText = "Event Name";
            txtEventName.ReadOnly = true;
            txtEventName.Size = new Size(286, 34);
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
            label2.Location = new Point(32, 181);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 60;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label3.Location = new Point(8, 258);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 61;
            label3.Text = "Event Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label4.Location = new Point(239, 298);
            label4.Name = "label4";
            label4.Size = new Size(87, 24);
            label4.TabIndex = 62;
            label4.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label5.Location = new Point(43, 348);
            label5.Name = "label5";
            label5.Size = new Size(108, 24);
            label5.TabIndex = 63;
            label5.Text = "Event Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold);
            label6.Location = new Point(-4, 413);
            label6.Name = "label6";
            label6.Size = new Size(155, 22);
            label6.TabIndex = 64;
            label6.Text = "Event Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(43, 38);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 65;
            // 
            // EventModifier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 667);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnAddFavorites);
            Controls.Add(btnBuyTicket);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtDate);
            Controls.Add(txtCapacity);
            Controls.Add(txtEventLocation);
            Controls.Add(txtEventName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventModifier";
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
        private TextBox txtDate;
        private TextBox txtCapacity;
        private TextBox txtEventLocation;
        private TextBox txtEventName;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}