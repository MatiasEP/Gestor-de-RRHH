namespace gestor_de_recursos_humanos
{
    partial class ActualizarPassword
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
            this.passUno = new System.Windows.Forms.TextBox();
            this.passDos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cambiarPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passUno
            // 
            this.passUno.Location = new System.Drawing.Point(152, 14);
            this.passUno.Name = "passUno";
            this.passUno.PasswordChar = '*';
            this.passUno.Size = new System.Drawing.Size(100, 20);
            this.passUno.TabIndex = 0;
            this.passUno.UseSystemPasswordChar = true;
            // 
            // passDos
            // 
            this.passDos.Location = new System.Drawing.Point(152, 41);
            this.passDos.Name = "passDos";
            this.passDos.PasswordChar = '*';
            this.passDos.Size = new System.Drawing.Size(100, 20);
            this.passDos.TabIndex = 1;
            this.passDos.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repita Password";
            // 
            // cambiarPassword
            // 
            this.cambiarPassword.Location = new System.Drawing.Point(152, 79);
            this.cambiarPassword.Name = "cambiarPassword";
            this.cambiarPassword.Size = new System.Drawing.Size(100, 23);
            this.cambiarPassword.TabIndex = 4;
            this.cambiarPassword.Text = "confirmar";
            this.cambiarPassword.UseVisualStyleBackColor = true;
            this.cambiarPassword.Click += new System.EventHandler(this.cambiarPassword_Click);
            // 
            // ActualizarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 143);
            this.Controls.Add(this.cambiarPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passDos);
            this.Controls.Add(this.passUno);
            this.Name = "ActualizarPassword";
            this.Text = "ActualizarPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passUno;
        private System.Windows.Forms.TextBox passDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cambiarPassword;
    }
}