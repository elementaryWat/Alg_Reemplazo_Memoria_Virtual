using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_de_reemplazo
{
    public partial class Form1 : Form
    {
        List<int[]> TPBvalidos;
        List<int[]> MarcosUbicacion;
        List<int[]> Contadores;
        bool RefAproceso;
        enum Ambitosreemplazo { LOCAL=1, Global=2 };
        Ambitosreemplazo AmbReem;
        enum AlgsReemplazo { FIFO=1, Optimo,LRU, SegundaOportunidad};
        AlgsReemplazo Algreem;
        public Form1()
        {
            InitializeComponent();
            RefAproceso = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetodoReemp_Click(object sender, EventArgs e)
        {

        }

        private void iniciarVirtual(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            if (!ts.Checked)
            {
                ts.Checked = true;
            }
            if (Aprocesos != ts)
            {
                Aprocesos.Checked = false;
                RefAproceso = false;
                Idproceso.Visible = false;
            }
            if (Adirecciones != ts)
            {
                Adirecciones.Checked = false;
                RefAproceso = true;
                if (aVariosProc.Checked)
                {
                    Idproceso.Visible = true;
                }
            }
        }

        private void TipoRef_CLICK(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            if (!ts.Checked)
            {
                ts.Checked = true;
            }
            if (Aprocesos != ts)
            {
                Aprocesos.Checked = false;
                RefAproceso = false;
                Idproceso.Visible = false;
            }
            if (Adirecciones != ts)
            {
                Adirecciones.Checked = false;
                RefAproceso = true;
                if (aVariosProc.Checked)
                {
                    Idproceso.Visible = true;
                }
            }
        }

        private void CantProcR_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            if (!ts.Checked)
            {
                ts.Checked = true;
            }
            if (aUnoProc != ts)
            {
                aUnoProc.Checked = false;
                Idproceso.Visible = false;
            }
            if (aVariosProc != ts)
            {
                aVariosProc.Checked = false;
                Idproceso.Visible = true;
            }
        }

        private void AmREEM_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            if (!ts.Checked)
            {
                ts.Checked = true;
            }
            if (AmRglobal != ts)
            {
                AmRglobal.Checked = false;
                AmbReem = Ambitosreemplazo.LOCAL;
            }
            if (AmRlocal != ts)
            {
                AmRlocal.Checked = false;
                AmbReem = Ambitosreemplazo.Global;
            }
        }
    }
}
