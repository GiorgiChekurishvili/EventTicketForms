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
            txtFilter = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnLogin = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.None;
            txtFilter.BackColor = Color.White;
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Font = new Font("Segoe UI", 13F);
            txtFilter.ForeColor = Color.Gray;
            txtFilter.Location = new Point(45, 194);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(477, 36);
            txtFilter.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(45, 272);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(477, 36);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(45, 340);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(477, 36);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(45, 422);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(477, 36);
            textBox3.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.FlatAppearance.BorderColor = Color.Red;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(268, 555);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(254, 40);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Remove";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(45, 491);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(477, 36);
            textBox4.TabIndex = 10;
            // 
            // RemoveFavoriteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 607);
            Controls.Add(textBox4);
            Controls.Add(btnLogin);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtFilter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveFavoriteForm";
            Text = "RemoveFavoriteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnLogin;
        private TextBox textBox4;
    }
}