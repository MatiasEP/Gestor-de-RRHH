namespace gestor_de_recursos_humanos
{
    partial class Organigrama
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
            this.dgrSupervisor = new System.Windows.Forms.DataGridView();
            this.dgrSupervisados = new System.Windows.Forms.DataGridView();
            this.Supervisor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblSupervisados = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSupervisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSupervisados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrSupervisor
            // 
            this.dgrSupervisor.AllowUserToAddRows = false;
            this.dgrSupervisor.AllowUserToDeleteRows = false;
            this.dgrSupervisor.AllowUserToResizeColumns = false;
            this.dgrSupervisor.AllowUserToResizeRows = false;
            this.dgrSupervisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSupervisor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrSupervisor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSupervisor.GridColor = System.Drawing.SystemColors.Control;
            this.dgrSupervisor.Location = new System.Drawing.Point(136, 46);
            this.dgrSupervisor.Name = "dgrSupervisor";
            this.dgrSupervisor.ReadOnly = true;
            this.dgrSupervisor.RowTemplate.ReadOnly = true;
            this.dgrSupervisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrSupervisor.ShowEditingIcon = false;
            this.dgrSupervisor.Size = new System.Drawing.Size(513, 55);
            this.dgrSupervisor.TabIndex = 14;
            // 
            // dgrSupervisados
            // 
            this.dgrSupervisados.AllowUserToAddRows = false;
            this.dgrSupervisados.AllowUserToDeleteRows = false;
            this.dgrSupervisados.AllowUserToResizeColumns = false;
            this.dgrSupervisados.AllowUserToResizeRows = false;
            this.dgrSupervisados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSupervisados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrSupervisados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrSupervisados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrSupervisados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSupervisados.GridColor = System.Drawing.SystemColors.Control;
            this.dgrSupervisados.Location = new System.Drawing.Point(136, 146);
            this.dgrSupervisados.Name = "dgrSupervisados";
            this.dgrSupervisados.ReadOnly = true;
            this.dgrSupervisados.RowTemplate.ReadOnly = true;
            this.dgrSupervisados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrSupervisados.ShowEditingIcon = false;
            this.dgrSupervisados.Size = new System.Drawing.Size(513, 245);
            this.dgrSupervisados.TabIndex = 15;
            // 
            // Supervisor
            // 
            this.Supervisor.AutoSize = true;
            this.Supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supervisor.Location = new System.Drawing.Point(117, 18);
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.Size = new System.Drawing.Size(87, 16);
            this.Supervisor.TabIndex = 16;
            this.Supervisor.Text = "Supervisor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Supervisados:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(658, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(306, 72);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(173, 16);
            this.lblSupervisor.TabIndex = 19;
            this.lblSupervisor.Text = "No posee un supervisor";
            this.lblSupervisor.Visible = false;
            // 
            // lblSupervisados
            // 
            this.lblSupervisados.AutoSize = true;
            this.lblSupervisados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisados.Location = new System.Drawing.Point(318, 178);
            this.lblSupervisados.Name = "lblSupervisados";
            this.lblSupervisados.Size = new System.Drawing.Size(156, 16);
            this.lblSupervisados.TabIndex = 20;
            this.lblSupervisados.Text = "No supervisa a nadie";
            this.lblSupervisados.Visible = false;
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(18, 446);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(770, 2);
            this.Line.TabIndex = 23;
            // 
            // Organigrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.lblSupervisados);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Supervisor);
            this.Controls.Add(this.dgrSupervisados);
            this.Controls.Add(this.dgrSupervisor);
            this.Name = "Organigrama";
            this.Text = "Organigrama Personal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Organigrama_FormClosed);
            this.Load += new System.EventHandler(this.Organigrama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSupervisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSupervisados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrSupervisor;
        private System.Windows.Forms.DataGridView dgrSupervisados;
        private System.Windows.Forms.Label Supervisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblSupervisados;
        private System.Windows.Forms.Label Line;
    }
}