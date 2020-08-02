using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class MenuInformes : Form
    {
        public MenuInformes()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void eventosActualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportEventosActuales.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportUsuarios.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void eventosEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportEventosEntreFechas.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void apuestasPorEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportApuestasPorEvento.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void apuestasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportApuestasPorUsuarios.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void mercadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportMercados.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void cuentasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReportCuentasDeUsuarios.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
