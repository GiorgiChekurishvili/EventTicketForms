namespace EventTicketForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            btnBought = new Button();
            button3 = new Button();
            btnFavorites = new Button();
            pnlSubEvents = new Panel();
            btnOthers = new Button();
            btnKids = new Button();
            btnMovies = new Button();
            btnConcerts = new Button();
            btnCircus = new Button();
            btnOpera = new Button();
            btnTheatre = new Button();
            btnComedy = new Button();
            btnSports = new Button();
            btnEvents = new Button();
            panel3 = new Panel();
            pnlMain = new Panel();
            pnlChild = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            txtFilter = new TextBox();
            dataGridForEvents = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlSubEvents.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlChild.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridForEvents).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1436, 48);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1378, 0);
            button1.Name = "button1";
            button1.Size = new Size(58, 48);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(17, 53, 71);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnBought);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnFavorites);
            panel2.Controls.Add(pnlSubEvents);
            panel2.Controls.Add(btnEvents);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 715);
            panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.Gainsboro;
            btnLogOut.Location = new Point(0, 667);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(10, 0, 0, 0);
            btnLogOut.Size = new Size(302, 45);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Visible = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnBought
            // 
            btnBought.Dock = DockStyle.Top;
            btnBought.FlatStyle = FlatStyle.Flat;
            btnBought.ForeColor = Color.Gainsboro;
            btnBought.Location = new Point(0, 554);
            btnBought.Name = "btnBought";
            btnBought.Padding = new Padding(10, 0, 0, 0);
            btnBought.Size = new Size(302, 45);
            btnBought.TabIndex = 8;
            btnBought.Text = "Bought Tickets";
            btnBought.TextAlign = ContentAlignment.MiddleLeft;
            btnBought.UseVisualStyleBackColor = true;
            btnBought.Visible = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 667);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(302, 45);
            button3.TabIndex = 7;
            button3.Text = "Log in";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnFavorites
            // 
            btnFavorites.Dock = DockStyle.Top;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.ForeColor = Color.Gainsboro;
            btnFavorites.Location = new Point(0, 509);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Padding = new Padding(10, 0, 0, 0);
            btnFavorites.Size = new Size(302, 45);
            btnFavorites.TabIndex = 6;
            btnFavorites.Text = "My Favorites";
            btnFavorites.TextAlign = ContentAlignment.MiddleLeft;
            btnFavorites.UseVisualStyleBackColor = true;
            btnFavorites.Visible = false;
            btnFavorites.Click += button2_Click;
            // 
            // pnlSubEvents
            // 
            pnlSubEvents.BackColor = Color.FromArgb(35, 32, 39);
            pnlSubEvents.Controls.Add(btnOthers);
            pnlSubEvents.Controls.Add(btnKids);
            pnlSubEvents.Controls.Add(btnMovies);
            pnlSubEvents.Controls.Add(btnConcerts);
            pnlSubEvents.Controls.Add(btnCircus);
            pnlSubEvents.Controls.Add(btnOpera);
            pnlSubEvents.Controls.Add(btnTheatre);
            pnlSubEvents.Controls.Add(btnComedy);
            pnlSubEvents.Controls.Add(btnSports);
            pnlSubEvents.Dock = DockStyle.Top;
            pnlSubEvents.Location = new Point(0, 141);
            pnlSubEvents.Name = "pnlSubEvents";
            pnlSubEvents.Size = new Size(302, 368);
            pnlSubEvents.TabIndex = 5;
            pnlSubEvents.Visible = false;
            pnlSubEvents.Paint += panel4_Paint;
            // 
            // btnOthers
            // 
            btnOthers.Dock = DockStyle.Top;
            btnOthers.FlatAppearance.BorderSize = 0;
            btnOthers.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnOthers.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnOthers.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnOthers.FlatStyle = FlatStyle.Flat;
            btnOthers.ForeColor = Color.LightGray;
            btnOthers.Location = new Point(0, 320);
            btnOthers.Name = "btnOthers";
            btnOthers.Padding = new Padding(35, 0, 0, 0);
            btnOthers.Size = new Size(302, 40);
            btnOthers.TabIndex = 11;
            btnOthers.Text = "Others";
            btnOthers.TextAlign = ContentAlignment.MiddleLeft;
            btnOthers.UseVisualStyleBackColor = true;
            btnOthers.Click += btnOthers_Click;
            // 
            // btnKids
            // 
            btnKids.Dock = DockStyle.Top;
            btnKids.FlatAppearance.BorderSize = 0;
            btnKids.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnKids.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnKids.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnKids.FlatStyle = FlatStyle.Flat;
            btnKids.ForeColor = Color.LightGray;
            btnKids.Location = new Point(0, 280);
            btnKids.Name = "btnKids";
            btnKids.Padding = new Padding(35, 0, 0, 0);
            btnKids.Size = new Size(302, 40);
            btnKids.TabIndex = 10;
            btnKids.Text = "Kids";
            btnKids.TextAlign = ContentAlignment.MiddleLeft;
            btnKids.UseVisualStyleBackColor = true;
            btnKids.Click += btnKids_Click;
            // 
            // btnMovies
            // 
            btnMovies.Dock = DockStyle.Top;
            btnMovies.FlatAppearance.BorderSize = 0;
            btnMovies.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnMovies.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnMovies.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.ForeColor = Color.LightGray;
            btnMovies.Location = new Point(0, 240);
            btnMovies.Name = "btnMovies";
            btnMovies.Padding = new Padding(35, 0, 0, 0);
            btnMovies.Size = new Size(302, 40);
            btnMovies.TabIndex = 9;
            btnMovies.Text = "Movies";
            btnMovies.TextAlign = ContentAlignment.MiddleLeft;
            btnMovies.UseVisualStyleBackColor = true;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnConcerts
            // 
            btnConcerts.Dock = DockStyle.Top;
            btnConcerts.FlatAppearance.BorderSize = 0;
            btnConcerts.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnConcerts.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnConcerts.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnConcerts.FlatStyle = FlatStyle.Flat;
            btnConcerts.ForeColor = Color.LightGray;
            btnConcerts.Location = new Point(0, 200);
            btnConcerts.Name = "btnConcerts";
            btnConcerts.Padding = new Padding(35, 0, 0, 0);
            btnConcerts.Size = new Size(302, 40);
            btnConcerts.TabIndex = 8;
            btnConcerts.Text = "Concerts";
            btnConcerts.TextAlign = ContentAlignment.MiddleLeft;
            btnConcerts.UseVisualStyleBackColor = true;
            btnConcerts.Click += btnConcerts_Click;
            // 
            // btnCircus
            // 
            btnCircus.Dock = DockStyle.Top;
            btnCircus.FlatAppearance.BorderSize = 0;
            btnCircus.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnCircus.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnCircus.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnCircus.FlatStyle = FlatStyle.Flat;
            btnCircus.ForeColor = Color.LightGray;
            btnCircus.Location = new Point(0, 160);
            btnCircus.Name = "btnCircus";
            btnCircus.Padding = new Padding(35, 0, 0, 0);
            btnCircus.Size = new Size(302, 40);
            btnCircus.TabIndex = 7;
            btnCircus.Text = "Circus";
            btnCircus.TextAlign = ContentAlignment.MiddleLeft;
            btnCircus.UseVisualStyleBackColor = true;
            btnCircus.Click += btnCircus_Click;
            // 
            // btnOpera
            // 
            btnOpera.Dock = DockStyle.Top;
            btnOpera.FlatAppearance.BorderSize = 0;
            btnOpera.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnOpera.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnOpera.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnOpera.FlatStyle = FlatStyle.Flat;
            btnOpera.ForeColor = Color.LightGray;
            btnOpera.Location = new Point(0, 120);
            btnOpera.Name = "btnOpera";
            btnOpera.Padding = new Padding(35, 0, 0, 0);
            btnOpera.Size = new Size(302, 40);
            btnOpera.TabIndex = 6;
            btnOpera.Text = "Opera";
            btnOpera.TextAlign = ContentAlignment.MiddleLeft;
            btnOpera.UseVisualStyleBackColor = true;
            btnOpera.Click += btnOpera_Click;
            // 
            // btnTheatre
            // 
            btnTheatre.Dock = DockStyle.Top;
            btnTheatre.FlatAppearance.BorderSize = 0;
            btnTheatre.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnTheatre.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnTheatre.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnTheatre.FlatStyle = FlatStyle.Flat;
            btnTheatre.ForeColor = Color.LightGray;
            btnTheatre.Location = new Point(0, 80);
            btnTheatre.Name = "btnTheatre";
            btnTheatre.Padding = new Padding(35, 0, 0, 0);
            btnTheatre.Size = new Size(302, 40);
            btnTheatre.TabIndex = 5;
            btnTheatre.Text = "Theatre";
            btnTheatre.TextAlign = ContentAlignment.MiddleLeft;
            btnTheatre.UseVisualStyleBackColor = true;
            btnTheatre.Click += btnTheatre_Click;
            // 
            // btnComedy
            // 
            btnComedy.Dock = DockStyle.Top;
            btnComedy.FlatAppearance.BorderSize = 0;
            btnComedy.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnComedy.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnComedy.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnComedy.FlatStyle = FlatStyle.Flat;
            btnComedy.ForeColor = Color.LightGray;
            btnComedy.Location = new Point(0, 40);
            btnComedy.Name = "btnComedy";
            btnComedy.Padding = new Padding(35, 0, 0, 0);
            btnComedy.Size = new Size(302, 40);
            btnComedy.TabIndex = 4;
            btnComedy.Text = "Comedy";
            btnComedy.TextAlign = ContentAlignment.MiddleLeft;
            btnComedy.UseVisualStyleBackColor = true;
            btnComedy.Click += btnComedy_Click;
            // 
            // btnSports
            // 
            btnSports.Dock = DockStyle.Top;
            btnSports.FlatAppearance.BorderSize = 0;
            btnSports.FlatAppearance.CheckedBackColor = Color.FromArgb(35, 32, 39);
            btnSports.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 32, 39);
            btnSports.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnSports.FlatStyle = FlatStyle.Flat;
            btnSports.ForeColor = Color.LightGray;
            btnSports.Location = new Point(0, 0);
            btnSports.Name = "btnSports";
            btnSports.Padding = new Padding(35, 0, 0, 0);
            btnSports.Size = new Size(302, 40);
            btnSports.TabIndex = 3;
            btnSports.Text = "Sport";
            btnSports.TextAlign = ContentAlignment.MiddleLeft;
            btnSports.UseVisualStyleBackColor = true;
            btnSports.Click += btnSports_Click;
            // 
            // btnEvents
            // 
            btnEvents.Dock = DockStyle.Top;
            btnEvents.FlatStyle = FlatStyle.Flat;
            btnEvents.ForeColor = Color.Gainsboro;
            btnEvents.Location = new Point(0, 96);
            btnEvents.Name = "btnEvents";
            btnEvents.Padding = new Padding(10, 0, 0, 0);
            btnEvents.Size = new Size(302, 45);
            btnEvents.TabIndex = 2;
            btnEvents.Text = "Events";
            btnEvents.TextAlign = ContentAlignment.MiddleLeft;
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 53, 71);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 96);
            panel3.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlChild);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(302, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1134, 715);
            pnlMain.TabIndex = 5;
            // 
            // pnlChild
            // 
            pnlChild.Controls.Add(panel5);
            pnlChild.Controls.Add(dataGridForEvents);
            pnlChild.Dock = DockStyle.Fill;
            pnlChild.ForeColor = Color.White;
            pnlChild.Location = new Point(0, 0);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(1134, 715);
            pnlChild.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtFilter);
            panel5.Location = new Point(351, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(499, 51);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.FromArgb(30, 30, 30);
            panel6.Location = new Point(3, 36);
            panel6.Name = "panel6";
            panel6.Size = new Size(477, 1);
            panel6.TabIndex = 4;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.None;
            txtFilter.BackColor = Color.FromArgb(30, 30, 30);
            txtFilter.BorderStyle = BorderStyle.None;
            txtFilter.Font = new Font("Segoe UI", 13F);
            txtFilter.ForeColor = Color.Gray;
            txtFilter.Location = new Point(3, 5);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Search An  Event";
            txtFilter.Size = new Size(477, 29);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // dataGridForEvents
            // 
            dataGridForEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridForEvents.Dock = DockStyle.Bottom;
            dataGridForEvents.Location = new Point(0, 102);
            dataGridForEvents.Name = "dataGridForEvents";
            dataGridForEvents.RowHeadersWidth = 51;
            dataGridForEvents.Size = new Size(1134, 613);
            dataGridForEvents.TabIndex = 0;
            dataGridForEvents.CellContentClick += dataGridForEvents_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1436, 763);
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = " ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            pnlSubEvents.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlChild.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridForEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel pnlSubEvents;
        private Button btnComedy;
        private Button btnSports;
        private Button btnEvents;
        private Button btnKids;
        private Button btnMovies;
        private Button btnConcerts;
        private Button btnCircus;
        private Button btnOpera;
        private Button btnTheatre;
        private Button btnOthers;
        private Button button3;
        private Button btnFavorites;
        private Panel pnlMain;
        private Panel pnlChild;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtFilter;
        private DataGridView dataGridForEvents;
        private Button btnBought;
        private Button btnLogOut;
    }
}