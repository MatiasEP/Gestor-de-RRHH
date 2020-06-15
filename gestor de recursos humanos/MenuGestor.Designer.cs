namespace gestor_de_recursos_humanos
{
    partial class MenuGestor
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
            this.btn_show_org = new System.Windows.Forms.Button();
            this.btn_new_nesec = new System.Windows.Forms.Button();
            this.btn_show_nesec = new System.Windows.Forms.Button();
            this.btn_new_find_resource = new System.Windows.Forms.Button();
            this.btn_show_find_resouce = new System.Windows.Forms.Button();
            this.btn_regist_empl = new System.Windows.Forms.Button();
            this.btn_show_empl = new System.Windows.Forms.Button();
            this.btn_sign_out = new System.Windows.Forms.Button();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LCargo = new System.Windows.Forms.Label();
            this.legajoActual = new System.Windows.Forms.TextBox();
            this.cargoActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_show_org
            // 
            this.btn_show_org.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show_org.Location = new System.Drawing.Point(650, 36);
            this.btn_show_org.Name = "btn_show_org";
            this.btn_show_org.Size = new System.Drawing.Size(112, 32);
            this.btn_show_org.TabIndex = 0;
            this.btn_show_org.Text = "Ver organigrama";
            this.btn_show_org.UseVisualStyleBackColor = true;
            this.btn_show_org.Click += new System.EventHandler(this.btn_show_org_Click);
            // 
            // btn_new_nesec
            // 
            this.btn_new_nesec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_nesec.Location = new System.Drawing.Point(650, 74);
            this.btn_new_nesec.Name = "btn_new_nesec";
            this.btn_new_nesec.Size = new System.Drawing.Size(112, 32);
            this.btn_new_nesec.TabIndex = 1;
            this.btn_new_nesec.Text = "Crear necesidad";
            this.btn_new_nesec.UseVisualStyleBackColor = true;
            this.btn_new_nesec.Click += new System.EventHandler(this.btn_new_nesec_Click);
            // 
            // btn_show_nesec
            // 
            this.btn_show_nesec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show_nesec.Location = new System.Drawing.Point(650, 112);
            this.btn_show_nesec.Name = "btn_show_nesec";
            this.btn_show_nesec.Size = new System.Drawing.Size(112, 32);
            this.btn_show_nesec.TabIndex = 2;
            this.btn_show_nesec.Text = "Visualizar necesidad";
            this.btn_show_nesec.UseVisualStyleBackColor = true;
            this.btn_show_nesec.Click += new System.EventHandler(this.btn_show_nesec_Click);
            // 
            // btn_new_find_resource
            // 
            this.btn_new_find_resource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_find_resource.Location = new System.Drawing.Point(650, 150);
            this.btn_new_find_resource.Name = "btn_new_find_resource";
            this.btn_new_find_resource.Size = new System.Drawing.Size(112, 42);
            this.btn_new_find_resource.TabIndex = 3;
            this.btn_new_find_resource.Text = "Crear busqueda de recurso";
            this.btn_new_find_resource.UseVisualStyleBackColor = true;
            this.btn_new_find_resource.Click += new System.EventHandler(this.btn_new_find_resource_Click);
            // 
            // btn_show_find_resouce
            // 
            this.btn_show_find_resouce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show_find_resouce.Location = new System.Drawing.Point(650, 198);
            this.btn_show_find_resouce.Name = "btn_show_find_resouce";
            this.btn_show_find_resouce.Size = new System.Drawing.Size(112, 42);
            this.btn_show_find_resouce.TabIndex = 4;
            this.btn_show_find_resouce.Text = "Visualizar busqueda de recurso";
            this.btn_show_find_resouce.UseVisualStyleBackColor = true;
            this.btn_show_find_resouce.Click += new System.EventHandler(this.btn_show_find_resouce_Click);
            // 
            // btn_regist_empl
            // 
            this.btn_regist_empl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_regist_empl.Location = new System.Drawing.Point(650, 246);
            this.btn_regist_empl.Name = "btn_regist_empl";
            this.btn_regist_empl.Size = new System.Drawing.Size(112, 32);
            this.btn_regist_empl.TabIndex = 5;
            this.btn_regist_empl.Text = "Registrar empleado";
            this.btn_regist_empl.UseVisualStyleBackColor = true;
            this.btn_regist_empl.Click += new System.EventHandler(this.btn_regist_empl_Click);
            // 
            // btn_show_empl
            // 
            this.btn_show_empl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show_empl.Location = new System.Drawing.Point(650, 284);
            this.btn_show_empl.Name = "btn_show_empl";
            this.btn_show_empl.Size = new System.Drawing.Size(112, 32);
            this.btn_show_empl.TabIndex = 6;
            this.btn_show_empl.Text = "Visualizar empleado";
            this.btn_show_empl.UseVisualStyleBackColor = true;
            this.btn_show_empl.Click += new System.EventHandler(this.btn_show_empl_Click);
            // 
            // btn_sign_out
            // 
            this.btn_sign_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sign_out.Location = new System.Drawing.Point(650, 380);
            this.btn_sign_out.Name = "btn_sign_out";
            this.btn_sign_out.Size = new System.Drawing.Size(112, 32);
            this.btn_sign_out.TabIndex = 7;
            this.btn_sign_out.Text = "Cerrar sesion";
            this.btn_sign_out.UseVisualStyleBackColor = true;
            this.btn_sign_out.Click += new System.EventHandler(this.btn_sign_out_Click);
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(15, 12);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(39, 13);
            this.LUsuario.TabIndex = 9;
            this.LUsuario.Text = "Legajo";
            // 
            // LCargo
            // 
            this.LCargo.AutoSize = true;
            this.LCargo.Location = new System.Drawing.Point(15, 32);
            this.LCargo.Name = "LCargo";
            this.LCargo.Size = new System.Drawing.Size(41, 13);
            this.LCargo.TabIndex = 10;
            this.LCargo.Text = "Cargo :";
            // 
            // legajoActual
            // 
            this.legajoActual.Location = new System.Drawing.Point(61, 9);
            this.legajoActual.Name = "legajoActual";
            this.legajoActual.Size = new System.Drawing.Size(100, 20);
            this.legajoActual.TabIndex = 11;
            // 
            // cargoActual
            // 
            this.cargoActual.Location = new System.Drawing.Point(61, 29);
            this.cargoActual.Name = "cargoActual";
            this.cargoActual.Size = new System.Drawing.Size(100, 20);
            this.cargoActual.TabIndex = 12;
            // 
            // MenuGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cargoActual);
            this.Controls.Add(this.legajoActual);
            this.Controls.Add(this.LCargo);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.btn_sign_out);
            this.Controls.Add(this.btn_show_empl);
            this.Controls.Add(this.btn_regist_empl);
            this.Controls.Add(this.btn_show_find_resouce);
            this.Controls.Add(this.btn_new_find_resource);
            this.Controls.Add(this.btn_show_nesec);
            this.Controls.Add(this.btn_new_nesec);
            this.Controls.Add(this.btn_show_org);
            this.Name = "MenuGestor";
            this.Text = "Menu Gestor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuGestor_FormClosed);
            this.Load += new System.EventHandler(this.MenuGestor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_show_org;
        private System.Windows.Forms.Button btn_new_nesec;
        private System.Windows.Forms.Button btn_show_nesec;
        private System.Windows.Forms.Button btn_new_find_resource;
        private System.Windows.Forms.Button btn_show_find_resouce;
        private System.Windows.Forms.Button btn_regist_empl;
        private System.Windows.Forms.Button btn_show_empl;
        private System.Windows.Forms.Button btn_sign_out;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LCargo;
        private System.Windows.Forms.TextBox legajoActual;
        private System.Windows.Forms.TextBox cargoActual;
    }
}