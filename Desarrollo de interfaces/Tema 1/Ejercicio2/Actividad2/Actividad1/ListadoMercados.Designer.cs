namespace Actividad1
{
    partial class ListadoMercados
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
            this.zonaListadoMercados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.escribeTipoMercado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.escribeInformacionCuotaOver = new System.Windows.Forms.TextBox();
            this.escribeInformacionCuotaUnder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.escribeDineroApostadoOver = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.escribeDineroApostadoUnder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.escribeIdMercado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.escribeIdEvento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.añadirMercado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.escribeEliminarId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.botonEliminarMercado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zonaListadoMercados)).BeginInit();
            this.SuspendLayout();
            // 
            // zonaListadoMercados
            // 
            this.zonaListadoMercados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonaListadoMercados.Location = new System.Drawing.Point(12, 65);
            this.zonaListadoMercados.Name = "zonaListadoMercados";
            this.zonaListadoMercados.ReadOnly = true;
            this.zonaListadoMercados.RowHeadersWidth = 92;
            this.zonaListadoMercados.RowTemplate.Height = 37;
            this.zonaListadoMercados.Size = new System.Drawing.Size(1869, 608);
            this.zonaListadoMercados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "lISTADO DE LOS MERCADOS DISPONIBLES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 699);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Añadir un Mercado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 751);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de mercado:";
            // 
            // escribeTipoMercado
            // 
            this.escribeTipoMercado.Location = new System.Drawing.Point(259, 748);
            this.escribeTipoMercado.Name = "escribeTipoMercado";
            this.escribeTipoMercado.Size = new System.Drawing.Size(100, 35);
            this.escribeTipoMercado.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 751);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Información cuota over:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // escribeInformacionCuotaOver
            // 
            this.escribeInformacionCuotaOver.Location = new System.Drawing.Point(688, 748);
            this.escribeInformacionCuotaOver.Name = "escribeInformacionCuotaOver";
            this.escribeInformacionCuotaOver.Size = new System.Drawing.Size(100, 35);
            this.escribeInformacionCuotaOver.TabIndex = 23;
            // 
            // escribeInformacionCuotaUnder
            // 
            this.escribeInformacionCuotaUnder.Location = new System.Drawing.Point(1129, 748);
            this.escribeInformacionCuotaUnder.Name = "escribeInformacionCuotaUnder";
            this.escribeInformacionCuotaUnder.Size = new System.Drawing.Size(100, 35);
            this.escribeInformacionCuotaUnder.TabIndex = 25;
            this.escribeInformacionCuotaUnder.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(838, 751);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Información cuota under:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // escribeDineroApostadoOver
            // 
            this.escribeDineroApostadoOver.Location = new System.Drawing.Point(309, 818);
            this.escribeDineroApostadoOver.Name = "escribeDineroApostadoOver";
            this.escribeDineroApostadoOver.Size = new System.Drawing.Size(100, 35);
            this.escribeDineroApostadoOver.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 821);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Dinero apostado a over:";
            // 
            // escribeDineroApostadoUnder
            // 
            this.escribeDineroApostadoUnder.Location = new System.Drawing.Point(747, 818);
            this.escribeDineroApostadoUnder.Name = "escribeDineroApostadoUnder";
            this.escribeDineroApostadoUnder.Size = new System.Drawing.Size(100, 35);
            this.escribeDineroApostadoUnder.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 821);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Dinero apostado a under:";
            // 
            // escribeIdMercado
            // 
            this.escribeIdMercado.Location = new System.Drawing.Point(1069, 818);
            this.escribeIdMercado.Name = "escribeIdMercado";
            this.escribeIdMercado.Size = new System.Drawing.Size(100, 35);
            this.escribeIdMercado.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(886, 821);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Id de mercado:";
            // 
            // escribeIdEvento
            // 
            this.escribeIdEvento.Location = new System.Drawing.Point(1385, 818);
            this.escribeIdEvento.Name = "escribeIdEvento";
            this.escribeIdEvento.Size = new System.Drawing.Size(100, 35);
            this.escribeIdEvento.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1219, 821);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "Id de evento:";
            // 
            // añadirMercado
            // 
            this.añadirMercado.Location = new System.Drawing.Point(38, 877);
            this.añadirMercado.Name = "añadirMercado";
            this.añadirMercado.Size = new System.Drawing.Size(138, 54);
            this.añadirMercado.TabIndex = 34;
            this.añadirMercado.Text = "Añadir";
            this.añadirMercado.UseVisualStyleBackColor = true;
            this.añadirMercado.Click += new System.EventHandler(this.añadirMercado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 1022);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 35);
            this.label4.TabIndex = 35;
            this.label4.Text = "Eliminar un Mercado";
            // 
            // escribeEliminarId
            // 
            this.escribeEliminarId.Location = new System.Drawing.Point(217, 1069);
            this.escribeEliminarId.Name = "escribeEliminarId";
            this.escribeEliminarId.Size = new System.Drawing.Size(100, 35);
            this.escribeEliminarId.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 1072);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "Id de mercado:";
            // 
            // botonEliminarMercado
            // 
            this.botonEliminarMercado.Location = new System.Drawing.Point(39, 1125);
            this.botonEliminarMercado.Name = "botonEliminarMercado";
            this.botonEliminarMercado.Size = new System.Drawing.Size(244, 54);
            this.botonEliminarMercado.TabIndex = 38;
            this.botonEliminarMercado.Text = "Eliminar Mercado";
            this.botonEliminarMercado.UseVisualStyleBackColor = true;
            this.botonEliminarMercado.Click += new System.EventHandler(this.botonEliminarMercado_Click);
            // 
            // ListadoMercados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1899, 1221);
            this.Controls.Add(this.botonEliminarMercado);
            this.Controls.Add(this.escribeEliminarId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.añadirMercado);
            this.Controls.Add(this.escribeIdEvento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.escribeIdMercado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.escribeDineroApostadoUnder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.escribeDineroApostadoOver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.escribeInformacionCuotaUnder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.escribeInformacionCuotaOver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.escribeTipoMercado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zonaListadoMercados);
            this.Name = "ListadoMercados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoMercados";
            this.Load += new System.EventHandler(this.ListadoMercados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zonaListadoMercados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zonaListadoMercados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox escribeTipoMercado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox escribeInformacionCuotaOver;
        private System.Windows.Forms.TextBox escribeInformacionCuotaUnder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox escribeDineroApostadoOver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox escribeDineroApostadoUnder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox escribeIdMercado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox escribeIdEvento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button añadirMercado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox escribeEliminarId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button botonEliminarMercado;
    }
}