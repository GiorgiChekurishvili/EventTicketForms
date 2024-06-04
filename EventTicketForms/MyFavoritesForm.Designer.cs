namespace EventTicketForms
{
    partial class MyFavoritesForm
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
            panel5 = new Panel();
            panel6 = new Panel();
            txtSearch = new TextBox();
            dataGridForFavorites = new DataGridView();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridForFavorites).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtSearch);
            panel5.Location = new Point(351, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(499, 51);
            panel5.TabIndex = 6;
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
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.BackColor = Color.FromArgb(30, 30, 30);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 13F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search An  Event";
            txtSearch.Size = new Size(477, 29);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Search";
            // 
            // dataGridForFavorites
            // 
            dataGridForFavorites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridForFavorites.Dock = DockStyle.Bottom;
            dataGridForFavorites.Location = new Point(0, 102);
            dataGridForFavorites.Name = "dataGridForFavorites";
            dataGridForFavorites.RowHeadersWidth = 51;
            dataGridForFavorites.Size = new Size(1134, 613);
            dataGridForFavorites.TabIndex = 5;
            // 
            // MyFavoritesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1134, 715);
            Controls.Add(panel5);
            Controls.Add(dataGridForFavorites);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyFavoritesForm";
            Text = "MyFavoritesForm";
            Load += MyFavoritesForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridForFavorites).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel6;
        private TextBox txtSearch;
        private DataGridView dataGridForFavorites;
    }
}