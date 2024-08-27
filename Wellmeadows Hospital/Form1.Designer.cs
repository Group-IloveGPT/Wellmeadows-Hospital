namespace Wellmeadows_Hospital
{
    partial class Form1
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
            this.Btn_SignIn = new System.Windows.Forms.Button();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_SignIn.Location = new System.Drawing.Point(261, 345);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(276, 45);
            this.Btn_SignIn.TabIndex = 0;
            this.Btn_SignIn.Text = "Sign In";
            this.Btn_SignIn.UseVisualStyleBackColor = false;
            this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // Txt_User
            // 
            this.Txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User.Location = new System.Drawing.Point(185, 185);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(431, 38);
            this.Txt_User.TabIndex = 1;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(185, 245);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '•';
            this.Txt_Password.Size = new System.Drawing.Size(431, 38);
            this.Txt_Password.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_Error);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Btn_SignIn);
            this.panel2.Controls.Add(this.Txt_Password);
            this.panel2.Controls.Add(this.Txt_User);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            // 
            // Lbl_Error
            // 
            this.Lbl_Error.AutoSize = true;
            this.Lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_Error.Location = new System.Drawing.Point(181, 303);
            this.Lbl_Error.Name = "Lbl_Error";
            this.Lbl_Error.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Error.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELLMEADOWS\r\nHOSTPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Sign In ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_SignIn;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Error;
    }
}

