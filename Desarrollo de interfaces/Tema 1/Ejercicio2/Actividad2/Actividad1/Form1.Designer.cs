namespace Actividad1
{
    partial class ventanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoUsuario = new System.Windows.Forms.MaskedTextBox();
            this.textoContra = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textoUsuario
            // 
            this.textoUsuario.Location = new System.Drawing.Point(259, 148);
            this.textoUsuario.Name = "textoUsuario";
            this.textoUsuario.Size = new System.Drawing.Size(100, 35);
            this.textoUsuario.TabIndex = 0;
            // 
            // textoContra
            // 
            this.textoContra.Location = new System.Drawing.Point(259, 227);
            this.textoContra.Name = "textoContra";
            this.textoContra.Size = new System.Drawing.Size(100, 35);
            this.textoContra.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(130, 151);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(96, 29);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(90, 233);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(136, 29);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "Contraseña";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(234, 296);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(125, 51);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Entrar_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Actividad1.Properties.Resources.usuarioAdministrador;
            this.pictureBox1.Location = new System.Drawing.Point(470, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ventanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.textoContra);
            this.Controls.Add(this.textoUsuario);
            this.Name = "ventanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.ventanaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textoUsuario;
        private System.Windows.Forms.TextBox textoContra;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

