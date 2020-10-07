namespace DepartmentOfLabour
{
    partial class main
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_appDt = new System.Windows.Forms.DateTimePicker();
            this.dtp_AppTm = new System.Windows.Forms.DateTimePicker();
            this.txtAppDetails = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(292, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make an Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Date Of Appointment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Time of Appointment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Appointment Details";
            // 
            // dtp_appDt
            // 
            this.dtp_appDt.Location = new System.Drawing.Point(419, 98);
            this.dtp_appDt.Name = "dtp_appDt";
            this.dtp_appDt.Size = new System.Drawing.Size(200, 20);
            this.dtp_appDt.TabIndex = 4;
            // 
            // dtp_AppTm
            // 
            this.dtp_AppTm.Location = new System.Drawing.Point(419, 159);
            this.dtp_AppTm.Name = "dtp_AppTm";
            this.dtp_AppTm.Size = new System.Drawing.Size(200, 20);
            this.dtp_AppTm.TabIndex = 5;
            // 
            // txtAppDetails
            // 
            this.txtAppDetails.Location = new System.Drawing.Point(419, 223);
            this.txtAppDetails.Multiline = true;
            this.txtAppDetails.Name = "txtAppDetails";
            this.txtAppDetails.Size = new System.Drawing.Size(200, 153);
            this.txtAppDetails.TabIndex = 6;
            this.txtAppDetails.TextChanged += new System.EventHandler(this.txtAppDetails_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(456, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit Appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dept_Labour.Properties.Resources.labour1;
            this.pictureBox1.Image = global::Dept_Labour.Properties.Resources.labourAp;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAppDetails);
            this.Controls.Add(this.dtp_AppTm);
            this.Controls.Add(this.dtp_appDt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "main1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_appDt;
        private System.Windows.Forms.DateTimePicker dtp_AppTm;
        private System.Windows.Forms.TextBox txtAppDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

