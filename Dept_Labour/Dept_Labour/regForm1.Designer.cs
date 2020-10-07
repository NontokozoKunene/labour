namespace DepartmentOfLabour
{
    partial class regForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Email_Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fnametext = new System.Windows.Forms.TextBox();
            this.Surnametext = new System.Windows.Forms.TextBox();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.Passswordtext = new System.Windows.Forms.TextBox();
            this.cornfirmtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION FORM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(75, 152);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(49, 13);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            // 
            // Email_Address
            // 
            this.Email_Address.AutoSize = true;
            this.Email_Address.Location = new System.Drawing.Point(48, 215);
            this.Email_Address.Name = "Email_Address";
            this.Email_Address.Size = new System.Drawing.Size(76, 13);
            this.Email_Address.TabIndex = 3;
            this.Email_Address.Text = "Email_Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Fnametext
            // 
            this.Fnametext.Location = new System.Drawing.Point(152, 88);
            this.Fnametext.Name = "Fnametext";
            this.Fnametext.Size = new System.Drawing.Size(216, 20);
            this.Fnametext.TabIndex = 5;
            // 
            // Surnametext
            // 
            this.Surnametext.Location = new System.Drawing.Point(152, 145);
            this.Surnametext.Name = "Surnametext";
            this.Surnametext.Size = new System.Drawing.Size(216, 20);
            this.Surnametext.TabIndex = 6;
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(152, 215);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(216, 20);
            this.Emailtext.TabIndex = 7;
            // 
            // Passswordtext
            // 
            this.Passswordtext.Location = new System.Drawing.Point(152, 274);
            this.Passswordtext.Name = "Passswordtext";
            this.Passswordtext.Size = new System.Drawing.Size(216, 20);
            this.Passswordtext.TabIndex = 8;
            this.Passswordtext.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cornfirmtext
            // 
            this.cornfirmtext.Location = new System.Drawing.Point(152, 329);
            this.cornfirmtext.Name = "cornfirmtext";
            this.cornfirmtext.Size = new System.Drawing.Size(216, 20);
            this.cornfirmtext.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cornfirm-Password";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(214, 370);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(97, 32);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // regForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cornfirmtext);
            this.Controls.Add(this.Passswordtext);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.Surnametext);
            this.Controls.Add(this.Fnametext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Email_Address);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regForm1";
            this.Load += new System.EventHandler(this.regForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Email_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fnametext;
        private System.Windows.Forms.TextBox Surnametext;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.TextBox Passswordtext;
        private System.Windows.Forms.TextBox cornfirmtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitBtn;
    }
}