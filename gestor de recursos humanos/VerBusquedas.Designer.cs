namespace gestor_de_recursos_humanos
{
    partial class VerBusquedas
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
            this.btnVerPostulantes = new System.Windows.Forms.Button();
            this.dgrVerBusqueda = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOficina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerBusqueda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(657, 450);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 33);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVerPostulantes
            // 
            this.btnVerPostulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPostulantes.Location = new System.Drawing.Point(657, 410);
            this.btnVerPostulantes.Name = "btnVerPostulantes";
            this.btnVerPostulantes.Size = new System.Drawing.Size(130, 33);
            this.btnVerPostulantes.TabIndex = 10;
            this.btnVerPostulantes.Text = "Ver Postulantes";
            this.btnVerPostulantes.UseVisualStyleBackColor = true;
            this.btnVerPostulantes.Click += new System.EventHandler(this.btnVerPostulantes_Click);
            // 
            // dgrVerBusqueda
            // 
            this.dgrVerBusqueda.AllowUserToAddRows = false;
            this.dgrVerBusqueda.AllowUserToDeleteRows = false;
            this.dgrVerBusqueda.AllowUserToResizeColumns = false;
            this.dgrVerBusqueda.AllowUserToResizeRows = false;
            this.dgrVerBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrVerBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrVerBusqueda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrVerBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrVerBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVerBusqueda.GridColor = System.Drawing.SystemColors.Control;
            this.dgrVerBusqueda.Location = new System.Drawing.Point(288, 0);
            this.dgrVerBusqueda.Name = "dgrVerBusqueda";
            this.dgrVerBusqueda.ReadOnly = true;
            this.dgrVerBusqueda.RowTemplate.ReadOnly = true;
            this.dgrVerBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrVerBusqueda.ShowEditingIcon = false;
            this.dgrVerBusqueda.Size = new System.Drawing.Size(513, 404);
            this.dgrVerBusqueda.TabIndex = 9;
            this.dgrVerBusqueda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVerBusqueda_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblOficina);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtAsunto);
            this.panel1.Controls.Add(this.lblCreador);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 449);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Location = new System.Drawing.Point(94, 400);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(121, 13);
            this.lblOficina.TabIndex = 19;
            this.lblOficina.Text = "___________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Oficina:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(16, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(256, 292);
            this.txtDescripcion.TabIndex = 18;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Enabled = false;
            this.txtAsunto.Location = new System.Drawing.Point(16, 23);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.ReadOnly = true;
            this.txtAsunto.Size = new System.Drawing.Size(256, 54);
            this.txtAsunto.TabIndex = 8;
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Location = new System.Drawing.Point(94, 422);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(121, 13);
            this.lblCreador.TabIndex = 8;
            this.lblCreador.Text = "___________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 422);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Creador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asunto: ";
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(18, 446);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(770, 2);
            this.Line.TabIndex = 22;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // VerBusquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVerPostulantes);
            this.Controls.Add(this.dgrVerBusqueda);
            this.Controls.Add(this.panel1);
            this.Name = "VerBusquedas";
            this.Text = "VerBusquedas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerBusquedas_FormClosed);
            this.Load += new System.EventHandler(this.VerBusquedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerBusqueda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVerPostulantes;
        private System.Windows.Forms.DataGridView dgrVerBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Line;
    }
}