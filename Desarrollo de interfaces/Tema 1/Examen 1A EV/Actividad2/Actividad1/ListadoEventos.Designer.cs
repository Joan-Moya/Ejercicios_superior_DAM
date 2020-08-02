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
            this.escribeDia = new System.Windows.Forms.TextBox();
            this.escribeHora = new System.Windows.Forms.TextBox();
            this.escribeEquipoLocal = new System.Windows.Forms.TextBox();
            this.EscribeEquipoVisitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.añadirEvento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eliminarID = new System.Windows.Forms.TextBox();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.buscarEvento = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.IdEventoFiltrado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.escribeFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zonaListadoEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarEvento)).BeginInit();
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
            this.zonaListadoEventos.Size = new System.Drawing.Size(1649, 618);
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
            // escribeDia
            // 
            this.escribeDia.Location = new System.Drawing.Point(98, 771);
            this.escribeDia.Name = "escribeDia";
            this.escribeDia.Size = new System.Drawing.Size(100, 35);
            this.escribeDia.TabIndex = 4;
            // 
            // escribeHora
            // 
            this.escribeHora.Location = new System.Drawing.Point(300, 771);
            this.escribeHora.Name = "escribeHora";
            this.escribeHora.Size = new System.Drawing.Size(100, 35);
            this.escribeHora.TabIndex = 5;
            // 
            // escribeEquipoLocal
            // 
            this.escribeEquipoLocal.Location = new System.Drawing.Point(608, 768);
            this.escribeEquipoLocal.Name = "escribeEquipoLocal";
            this.escribeEquipoLocal.Size = new System.Drawing.Size(100, 35);
            this.escribeEquipoLocal.TabIndex = 6;
            // 
            // EscribeEquipoVisitante
            // 
            this.EscribeEquipoVisitante.Location = new System.Drawing.Point(936, 768);
            this.EscribeEquipoVisitante.Name = "EscribeEquipoVisitante";
            this.EscribeEquipoVisitante.Size = new System.Drawing.Size(100, 35);
            this.EscribeEquipoVisitante.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 777);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 777);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 774);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Equipo visitante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 774);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Equipo Local:";
            // 
            // añadirEvento
            // 
            this.añadirEvento.Location = new System.Drawing.Point(1132, 777);
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
            // buscarEvento
            // 
            this.buscarEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarEvento.Location = new System.Drawing.Point(1678, 73);
            this.buscarEvento.Name = "buscarEvento";
            this.buscarEvento.ReadOnly = true;
            this.buscarEvento.RowHeadersWidth = 92;
            this.buscarEvento.RowTemplate.Height = 37;
            this.buscarEvento.Size = new System.Drawing.Size(873, 618);
            this.buscarEvento.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1672, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 35);
            this.label10.TabIndex = 19;
            this.label10.Text = "BUSCAR UN EVENTO";
            // 
            // IdEventoFiltrado
            // 
            this.IdEventoFiltrado.Location = new System.Drawing.Point(2149, 715);
            this.IdEventoFiltrado.Name = "IdEventoFiltrado";
            this.IdEventoFiltrado.Size = new System.Drawing.Size(100, 35);
            this.IdEventoFiltrado.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1682, 715);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(446, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Pon el ID del evento que quieras buscar:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2287, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 54);
            this.button1.TabIndex = 22;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(513, 825);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(405, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fecha formato (2013-11-24 17:15:10)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // escribeFecha
            // 
            this.escribeFecha.Location = new System.Drawing.Point(940, 822);
            this.escribeFecha.Name = "escribeFecha";
            this.escribeFecha.Size = new System.Drawing.Size(150, 35);
            this.escribeFecha.TabIndex = 24;
            // 
            // ListadoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2563, 1062);
            this.Controls.Add(this.escribeFecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IdEventoFiltrado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buscarEvento);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.eliminarID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.añadirEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EscribeEquipoVisitante);
            this.Controls.Add(this.escribeEquipoLocal);
            this.Controls.Add(this.escribeHora);
            this.Controls.Add(this.escribeDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zonaListadoEventos);
            this.Name = "ListadoEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoEventos";
            this.Load += new System.EventHandler(this.ListadoEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zonaListadoEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zonaListadoEventos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox escribeDia;
        private System.Windows.Forms.TextBox escribeHora;
        private System.Windows.Forms.TextBox escribeEquipoLocal;
        private System.Windows.Forms.TextBox EscribeEquipoVisitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button añadirEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eliminarID;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.DataGridView buscarEvento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdEventoFiltrado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox escribeFecha;
    }
}