namespace Actividad1
{
    partial class MenuInformes
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
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosActualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuestasPorEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuestasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1464, 851);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(197, 48);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(196, 44);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 806);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1464, 45);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosActualesToolStripMenuItem,
            this.eventosEntreFechasToolStripMenuItem,
            this.apuestasPorEventoToolStripMenuItem,
            this.apuestasPorUsuarioToolStripMenuItem,
            this.mercadosToolStripMenuItem,
            this.usuariosToolStripMenuItem2});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(272, 43);
            this.usuariosToolStripMenuItem1.Text = "Listado de informes";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // eventosActualesToolStripMenuItem
            // 
            this.eventosActualesToolStripMenuItem.Name = "eventosActualesToolStripMenuItem";
            this.eventosActualesToolStripMenuItem.Size = new System.Drawing.Size(416, 48);
            this.eventosActualesToolStripMenuItem.Text = "Eventos actuales";
            this.eventosActualesToolStripMenuItem.Click += new System.EventHandler(this.eventosActualesToolStripMenuItem_Click);
            // 
            // eventosEntreFechasToolStripMenuItem
            // 
            this.eventosEntreFechasToolStripMenuItem.Name = "eventosEntreFechasToolStripMenuItem";
            this.eventosEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(416, 48);
            this.eventosEntreFechasToolStripMenuItem.Text = "Eventos entre fechas";
            this.eventosEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.eventosEntreFechasToolStripMenuItem_Click);
            // 
            // apuestasPorEventoToolStripMenuItem
            // 
            this.apuestasPorEventoToolStripMenuItem.Name = "apuestasPorEventoToolStripMenuItem";
            this.apuestasPorEventoToolStripMenuItem.Size = new System.Drawing.Size(416, 48);
            this.apuestasPorEventoToolStripMenuItem.Text = "Apuestas por evento";
            this.apuestasPorEventoToolStripMenuItem.Click += new System.EventHandler(this.apuestasPorEventoToolStripMenuItem_Click);
            // 
            // apuestasPorUsuarioToolStripMenuItem
            // 
            this.apuestasPorUsuarioToolStripMenuItem.Name = "apuestasPorUsuarioToolStripMenuItem";
            this.apuestasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(416, 48);
            this.apuestasPorUsuarioToolStripMenuItem.Text = "Apuestas por usuario";
            this.apuestasPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.apuestasPorUsuarioToolStripMenuItem_Click);
            // 
            // mercadosToolStripMenuItem
            // 
            this.mercadosToolStripMenuItem.Name = "mercadosToolStripMenuItem";
            this.mercadosToolStripMenuItem.Size = new System.Drawing.Size(416, 48);
            this.mercadosToolStripMenuItem.Text = "Mercados";
            this.mercadosToolStripMenuItem.Click += new System.EventHandler(this.mercadosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem2
            // 
            this.usuariosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem2.Name = "usuariosToolStripMenuItem2";
            this.usuariosToolStripMenuItem2.Size = new System.Drawing.Size(416, 48);
            this.usuariosToolStripMenuItem2.Text = "Usuarios";
            this.usuariosToolStripMenuItem2.Click += new System.EventHandler(this.usuariosToolStripMenuItem2_Click);
            // 
            // cuentasDeUsuariosToolStripMenuItem
            // 
            this.cuentasDeUsuariosToolStripMenuItem.Name = "cuentasDeUsuariosToolStripMenuItem";
            this.cuentasDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(404, 48);
            this.cuentasDeUsuariosToolStripMenuItem.Text = "Cuentas de usuarios";
            this.cuentasDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cuentasDeUsuariosToolStripMenuItem_Click);
            // 
            // MenuInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 851);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crystalReportViewer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInformes";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventosActualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuestasPorEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuestasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cuentasDeUsuariosToolStripMenuItem;
    }
}