namespace Proyecto_POO_BDD
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Location = new System.Drawing.Point(221, 211);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(261, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Constraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(327, 211);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(172, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(327, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(311, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema Vacunación  COVID-19\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartSesion
            // 
            this.btnStartSesion.Location = new System.Drawing.Point(337, 316);
            this.btnStartSesion.Name = "btnStartSesion";
            this.btnStartSesion.Size = new System.Drawing.Size(151, 47);
            this.btnStartSesion.TabIndex = 5;
            this.btnStartSesion.Text = "Iniciar sesion";
            this.btnStartSesion.UseVisualStyleBackColor = true;
            this.btnStartSesion.Click += new System.EventHandler(this.btnStartSesion_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnStartSesion;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label lblUser;

        #endregion
    }
}