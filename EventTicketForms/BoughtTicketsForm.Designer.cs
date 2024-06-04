namespace EventTicketForms
{
    partial class BoughtTicketsForm
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
            txtFilter = new TextBox();
            dataGridForEvents = new DataGridView();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridForEvents).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtFilter);
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
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.None;
            txtFilter.BackColor = Color.FromArgb(30, 30, 30);
            txtFilter.BorderStyle = BorderStyle.None;
            txtFilter.Font = new Font("Segoe UI", 13F);
            txtFilter.ForeColor = Color.Gray;
            txtFilter.Location = new Point(3, 5);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Search A Ticket";
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
            dataGridForEvents.TabIndex = 5;
            // 
            // BoughtTicketsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1134, 715);
            Controls.Add(panel5);
            Controls.Add(dataGridForEvents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BoughtTicketsForm";
            Text = "BoughtTicketsForm";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridForEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel6;
        private TextBox txtFilter;
        private DataGridView dataGridForEvents;
    }
}