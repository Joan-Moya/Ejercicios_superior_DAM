namespace Actividad1
{

    partial class menuAdministrador
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
            this.botonEventos = new System.Windows.Forms.Button();
            this.botonMercados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.informes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonEventos
            // 
            this.botonEventos.Location = new System.Drawing.Point(29, 95);
            this.botonEventos.Name = "botonEventos";
            this.botonEventos.Size = new System.Drawing.Size(184, 95);
            this.botonEventos.TabIndex = 0;
            this.botonEventos.Text = "Eventos";
            this.botonEventos.UseVisualStyleBackColor = true;
            this.botonEventos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonEventos_MouseClick);
            // 
            // botonMercados
            // 
            this.botonMercados.Location = new System.Drawing.Point(251, 95);
            this.botonMercados.Name = "botonMercados";
            this.botonMercados.Size = new System.Drawing.Size(200, 95);
            this.botonMercados.TabIndex = 1;
            this.botonMercados.Text = "Mercados";
            this.botonMercados.UseVisualStyleBackColor = true;
            this.botonMercados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonMercados_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "PARAMETROS A LISTAR Y MODIFICAR DEL ADMINISTRADOR SOBRE LA BASE DE DATOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 95);
            this.button1.TabIndex = 3;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 95);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mensajes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(958, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 95);
            this.button3.TabIndex = 5;
            this.button3.Text = "Fotos inicio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(985, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 75);
            this.button4.TabIndex = 6;
            this.button4.Text = "Salir";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // informes
            // 
            this.informes.Location = new System.Drawing.Point(29, 288);
            this.informes.Name = "informes";
            this.informes.Size = new System.Drawing.Size(184, 95);
            this.informes.TabIndex = 14;
            this.informes.Text = "Informes";
            this.informes.UseVisualStyleBackColor = true;
            this.informes.Click += new System.EventHandler(this.informes_Click);
            // 
            // menuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1202, 441);
            this.Controls.Add(this.informes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonMercados);
            this.Controls.Add(this.botonEventos);
            this.Name = "menuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelAdministrador";
            this.Load += new System.EventHandler(this.MenuAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEventos;
        private System.Windows.Forms.Button botonMercados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button informes;
    }
}