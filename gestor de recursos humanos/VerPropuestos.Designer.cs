namespace gestor_de_recursos_humanos
{
    partial class VerPropuestos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.dgrVerPropuestos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurriculum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerPropuestos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(662, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 43);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(361, 400);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(97, 43);
            this.btnAprobar.TabIndex = 18;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // dgrVerPropuestos
            // 
            this.dgrVerPropuestos.AllowUserToAddRows = false;
            this.dgrVerPropuestos.AllowUserToDeleteRows = false;
            this.dgrVerPropuestos.AllowUserToResizeColumns = false;
            this.dgrVerPropuestos.AllowUserToResizeRows = false;
            this.dgrVerPropuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrVerPropuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrVerPropuestos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrVerPropuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrVerPropuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVerPropuestos.GridColor = System.Drawing.SystemColors.Control;
            this.dgrVerPropuestos.Location = new System.Drawing.Point(288, 0);
            this.dgrVerPropuestos.Name = "dgrVerPropuestos";
            this.dgrVerPropuestos.ReadOnly = true;
            this.dgrVerPropuestos.RowTemplate.ReadOnly = true;
            this.dgrVerPropuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrVerPropuestos.ShowEditingIcon = false;
            this.dgrVerPropuestos.Size = new System.Drawing.Size(513, 394);
            this.dgrVerPropuestos.TabIndex = 17;
            this.dgrVerPropuestos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVerPropuestos_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCurriculum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 452);
            this.panel1.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(90, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(121, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "___________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(90, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(121, 13);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "___________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Apellido:";
            // 
            // txtCurriculum
            // 
            this.txtCurriculum.Enabled = false;
            this.txtCurriculum.Location = new System.Drawing.Point(16, 96);
            this.txtCurriculum.Multiline = true;
            this.txtCurriculum.Name = "txtCurriculum";
            this.txtCurriculum.ReadOnly = true;
            this.txtCurriculum.Size = new System.Drawing.Size(256, 343);
            this.txtCurriculum.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curriculum:";
            // 
            // btnRechazar
            // 
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.Location = new System.Drawing.Point(511, 400);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(97, 43);
            this.btnRechazar.TabIndex = 20;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // VerPropuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.dgrVerPropuestos);
            this.Controls.Add(this.panel1);
            this.Name = "VerPropuestos";
            this.Text = "VerPropuestos";
            this.Load += new System.EventHandler(this.VerPropuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerPropuestos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.DataGridView dgrVerPropuestos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurriculum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRechazar;
    }
}