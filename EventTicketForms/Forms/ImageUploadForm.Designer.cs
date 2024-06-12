namespace EventTicketForms.Forms
{
    partial class ImageUploadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageUploadForm));
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnUpload = new Button();
            label5 = new Label();
            comboBoxEvents = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(79, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(656, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(562, 474);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 40);
            btnDelete.TabIndex = 68;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(0, 192, 0);
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Bahnschrift", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(79, 474);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(144, 40);
            btnUpload.TabIndex = 69;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label5.Location = new Point(562, 447);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 140;
            label5.Text = "Don't Like It?";
            // 
            // comboBoxEvents
            // 
            comboBoxEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEvents.Font = new Font("Bahnschrift", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxEvents.ForeColor = Color.Black;
            comboBoxEvents.FormattingEnabled = true;
            comboBoxEvents.Location = new Point(259, 394);
            comboBoxEvents.Name = "comboBoxEvents";
            comboBoxEvents.Size = new Size(288, 35);
            comboBoxEvents.TabIndex = 141;
            comboBoxEvents.Tag = "";
            comboBoxEvents.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.8F, FontStyle.Bold);
            label1.Location = new Point(25, 399);
            label1.Name = "label1";
            label1.Size = new Size(224, 24);
            label1.TabIndex = 142;
            label1.Text = "Upload For Which Event";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(761, -3);
            button1.Name = "button1";
            button1.Size = new Size(39, 32);
            button1.TabIndex = 143;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ImageUploadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBoxEvents);
            Controls.Add(label5);
            Controls.Add(btnUpload);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ImageUploadForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageUploadForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnDelete;
        private Button btnUpload;
        private Label label5;
        private ComboBox comboBoxEvents;
        private Label label1;
        private Button button1;
    }
}