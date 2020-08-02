namespace Actividad1
{
    partial class ListadoEventos
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
            this.zonaListadoEventos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.escribeId = new System.Windows.Forms.TextBox();
            this.escribeDia = new System.Windows.Forms.TextBox();
            this.escribeHora = new System.Windows.Forms.TextBox();
            this.escribeEquipoLocal = new System.Windows.Forms.TextBox();
            this.EscribeEquipoVisitante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.añadirEvento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eliminarID = new System.Windows.Forms.TextBox();
            this.BotonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zonaListadoEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // zonaListadoEventos
            // 
            this.zonaListadoEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonaListadoEventos.Location = new System.Drawing.Point(12, 73);
            this.zonaListadoEventos.Name = "zonaListadoEventos";
            this.zonaListadoEventos.ReadOnly = true;
            this.zonaListadoEventos.RowHeadersWidth = 92;
            this.zonaListadoEventos.RowTemplate.Height = 37;
            this.zonaListadoEventos.Size = new System.Drawing.Size(1385, 618);
            this.zonaListadoEventos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "lISTADO DE LOS EVENTOS DISPONIBLES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 715);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Añadir un Evento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // escribeId
            // 
            this.escribeId.Location = new System.Drawing.Point(92, 795);
            this.escribeId.Name = "escribeId";
            this.escribeId.Size = new System.Drawing.Size(100, 35);
            this.escribeId.TabIndex = 3;
            // 
            // escribeDia
            // 
            this.escribeDia.Location = new System.Drawing.Point(281, 792);
            this.escribeDia.Name = "escribeDia";
            this.escribeDia.Size = new System.Drawing.Size(100, 35);
            this.escribeDia.TabIndex = 4;
            // 
            // escribeHora
            // 
            this.escribeHora.Location = new System.Drawing.Point(483, 792);
            this.escribeHora.Name = "escribeHora";
            this.escribeHora.Size = new System.Drawing.Size(100, 35);
            this.escribeHora.TabIndex = 5;
            // 
            // escribeEquipoLocal
            // 
            this.escribeEquipoLocal.Location = new System.Drawing.Point(791, 789);
            this.escribeEquipoLocal.Name = "escribeEquipoLocal";
            this.escribeEquipoLocal.Size = new System.Drawing.Size(100, 35);
            this.escribeEquipoLocal.TabIndex = 6;
            // 
            // EscribeEquipoVisitante
            // 
            this.EscribeEquipoVisitante.Location = new System.Drawing.Point(1119, 789);
            this.EscribeEquipoVisitante.Name = "EscribeEquipoVisitante";
            this.EscribeEquipoVisitante.Size = new System.Drawing.Size(100, 35);
            this.EscribeEquipoVisitante.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 801);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 798);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 798);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(912, 795);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Equipo visitante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 795);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Equipo Local:";
            // 
            // añadirEvento
            // 
            this.añadirEvento.Location = new System.Drawing.Point(1246, 785);
            this.añadirEvento.Name = "añadirEvento";
            this.añadirEvento.Size = new System.Drawing.Size(138, 54);
            this.añadirEvento.TabIndex = 13;
            this.añadirEvento.Text = "Añadir";
            this.añadirEvento.UseVisualStyleBackColor = true;
            this.añadirEvento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.añadirEvento_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 892);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "Eliminar un Evento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 955);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "ID:";
            // 
            // eliminarID
            // 
            this.eliminarID.Location = new System.Drawing.Point(78, 949);
            this.eliminarID.Name = "eliminarID";
            this.eliminarID.Size = new System.Drawing.Size(100, 35);
            this.eliminarID.TabIndex = 16;
            this.eliminarID.TextChanged += new System.EventHandler(this.eliminarID_TextChanged);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(196, 939);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(138, 54);
            this.BotonEliminar.TabIndex = 17;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // ListadoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1407, 1062);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.eliminarID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.añadirEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EscribeEquipoVisitante);
            this.Controls.Add(this.escribeEquipoLocal);
            this.Controls.Add(this.escribeHora);
            this.Controls.Add(this.escribeDia);
            this.Controls.Add(this.escribeId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zonaListadoEventos);
            this.Name = "ListadoEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoEventos";
            this.Load += new System.EventHandler(this.ListadoEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zonaListadoEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zonaListadoEventos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox escribeId;
        private System.Windows.Forms.TextBox escribeDia;
        private System.Windows.Forms.TextBox escribeHora;
        private System.Windows.Forms.TextBox escribeEquipoLocal;
        private System.Windows.Forms.TextBox EscribeEquipoVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button añadirEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eliminarID;
        private System.Windows.Forms.Button BotonEliminar;
    }
}