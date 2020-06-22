namespace gestor_de_recursos_humanos
{
    partial class VerPostulantes
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
            this.btnProponerPostulante = new System.Windows.Forms.Button();
            this.dgrVerPostulantes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurriculum = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerPostulantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(652, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 43);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnProponerPostulante
            // 
            this.btnProponerPostulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProponerPostulante.Location = new System.Drawing.Point(397, 400);
            this.btnProponerPostulante.Name = "btnProponerPostulante";
            this.btnProponerPostulante.Size = new System.Drawing.Size(97, 43);
            this.btnProponerPostulante.TabIndex = 14;
            this.btnProponerPostulante.Text = "Proponer postulante";
            this.btnProponerPostulante.UseVisualStyleBackColor = true;
            this.btnProponerPostulante.Click += new System.EventHandler(this.btnProponerPostulante_Click);
            // 
            // dgrVerPostulantes
            // 
            this.dgrVerPostulantes.AllowUserToAddRows = false;
            this.dgrVerPostulantes.AllowUserToDeleteRows = false;
            this.dgrVerPostulantes.AllowUserToResizeColumns = false;
            this.dgrVerPostulantes.AllowUserToResizeRows = false;
            this.dgrVerPostulantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrVerPostulantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrVerPostulantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrVerPostulantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrVerPostulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVerPostulantes.GridColor = System.Drawing.SystemColors.Control;
            this.dgrVerPostulantes.Location = new System.Drawing.Point(288, 0);
            this.dgrVerPostulantes.Name = "dgrVerPostulantes";
            this.dgrVerPostulantes.ReadOnly = true;
            this.dgrVerPostulantes.RowTemplate.ReadOnly = true;
            this.dgrVerPostulantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrVerPostulantes.ShowEditingIcon = false;
            this.dgrVerPostulantes.Size = new System.Drawing.Size(513, 394);
            this.dgrVerPostulantes.TabIndex = 13;
            this.dgrVerPostulantes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVerPostulantes_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCurriculum);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 452);
            this.panel1.TabIndex = 12;
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
            this.txtCurriculum.Size = new System.Drawing.Size(256, 315);
            this.txtCurriculum.TabIndex = 18;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(90, 426);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(121, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "___________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Estado:";
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
            // VerPostulantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnProponerPostulante);
            this.Controls.Add(this.dgrVerPostulantes);
            this.Controls.Add(this.panel1);
            this.Name = "VerPostulantes";
            this.Text = "VerPostulantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerPostulantes_FormClosed);
            this.Load += new System.EventHandler(this.VerPostulantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerPostulantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnProponerPostulante;
        private System.Windows.Forms.DataGridView dgrVerPostulantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCurriculum;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label6;
    }
}