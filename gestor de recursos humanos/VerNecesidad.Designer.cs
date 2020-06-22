namespace gestor_de_recursos_humanos
{
    partial class VerNecesidad
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
            this.btnCrearBusqueda = new System.Windows.Forms.Button();
            this.dgrVerNecesidad = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerPropuestos = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerNecesidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(657, 450);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 33);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrearBusqueda
            // 
            this.btnCrearBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearBusqueda.Location = new System.Drawing.Point(657, 411);
            this.btnCrearBusqueda.Name = "btnCrearBusqueda";
            this.btnCrearBusqueda.Size = new System.Drawing.Size(130, 33);
            this.btnCrearBusqueda.TabIndex = 6;
            this.btnCrearBusqueda.Text = "Crear busqueda";
            this.btnCrearBusqueda.UseVisualStyleBackColor = true;
            this.btnCrearBusqueda.Click += new System.EventHandler(this.btnCrearBusqueda_Click);
            // 
            // dgrVerNecesidad
            // 
            this.dgrVerNecesidad.AllowUserToAddRows = false;
            this.dgrVerNecesidad.AllowUserToDeleteRows = false;
            this.dgrVerNecesidad.AllowUserToResizeColumns = false;
            this.dgrVerNecesidad.AllowUserToResizeRows = false;
            this.dgrVerNecesidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrVerNecesidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrVerNecesidad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrVerNecesidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrVerNecesidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVerNecesidad.GridColor = System.Drawing.SystemColors.Control;
            this.dgrVerNecesidad.Location = new System.Drawing.Point(288, 0);
            this.dgrVerNecesidad.Name = "dgrVerNecesidad";
            this.dgrVerNecesidad.ReadOnly = true;
            this.dgrVerNecesidad.RowTemplate.ReadOnly = true;
            this.dgrVerNecesidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrVerNecesidad.ShowEditingIcon = false;
            this.dgrVerNecesidad.Size = new System.Drawing.Size(513, 407);
            this.dgrVerNecesidad.TabIndex = 5;
            this.dgrVerNecesidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVerNecesidad_CellContentClick);
            this.dgrVerNecesidad.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVerNecesidad_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtAsunto);
            this.panel1.Controls.Add(this.lblCreador);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 450);
            this.panel1.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(16, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(256, 312);
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
            this.lblCreador.Location = new System.Drawing.Point(90, 424);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(121, 13);
            this.lblCreador.TabIndex = 8;
            this.lblCreador.Text = "___________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 424);
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
            // btnVerPropuestos
            // 
            this.btnVerPropuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPropuestos.Location = new System.Drawing.Point(657, 411);
            this.btnVerPropuestos.Name = "btnVerPropuestos";
            this.btnVerPropuestos.Size = new System.Drawing.Size(130, 33);
            this.btnVerPropuestos.TabIndex = 8;
            this.btnVerPropuestos.Text = "Ver propuestos";
            this.btnVerPropuestos.UseVisualStyleBackColor = true;
            this.btnVerPropuestos.Click += new System.EventHandler(this.btnVerPropuestos_Click);
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(18, 447);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(770, 2);
            this.Line.TabIndex = 17;
            // 
            // VerNecesidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.btnVerPropuestos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearBusqueda);
            this.Controls.Add(this.dgrVerNecesidad);
            this.Controls.Add(this.panel1);
            this.Name = "VerNecesidad";
            this.Text = "Ver Necesidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerNecesidad_FormClosed);
            this.Load += new System.EventHandler(this.VerNecesidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVerNecesidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrearBusqueda;
        private System.Windows.Forms.DataGridView dgrVerNecesidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Button btnVerPropuestos;
        private System.Windows.Forms.Label Line;
    }
}