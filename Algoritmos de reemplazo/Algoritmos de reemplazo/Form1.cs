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
        bool RefAproceso;
        int cantidadProc;
        Memoria Mimemoria;
        int instanteseleccionado;
        public Form1()
        {
            InitializeComponent();
            RefAproceso = false;
            Mimemoria = new Memoria();
            Mimemoria.AmbReem = Memoria.Ambitosreemplazo.Global;
            Mimemoria.Algreem = Memoria.AlgsReemplazo.LRU;
            cantidadProc = 1;
            CantidadPr.Text = "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetodoReemp_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            if (!ts.Checked)
            {
                ts.Checked = true;
            }
            if (lRUTM != ts)
            {
                lRUTM.Checked = false;
            }
            if (fIFOTM != ts)
            {
                fIFOTM.Checked = false;
            }
            if (optimoTm != ts)
            {
                optimoTm.Checked = false;
            }
            if (segundaOTM != ts)
            {
                segundaOTM.Checked = false;
            }
            if (ts==fIFOTM)
            {
                Mimemoria.Algreem = Memoria.AlgsReemplazo.FIFO;
            }
            if (ts == lRUTM)
            {
                Mimemoria.Algreem = Memoria.AlgsReemplazo.LRU;
            }
            if (ts == optimoTm)
            {
                Mimemoria.Algreem = Memoria.AlgsReemplazo.Optimo;
            }
            if (ts == segundaOTM)
            {
                Mimemoria.Algreem = Memoria.AlgsReemplazo.SegundaOportunidad;
            }
        }
        public bool solicitarcantp()
        {
            try
            {
                Mimemoria.definircantpag(Int32.Parse(Cantpaginas.Text)) ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un numero en la cantidad de paginas");
                return false;
            }
            return true;
        }
        public bool solicitartamp()
        {
            try
            {
                Mimemoria.tamaniopagina = Int32.Parse(TamPagina.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un numero en el tamaño de pagina ");
                return false;
            }
            return true;
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
        private void definirdatosCombo()
        {
            DataGridViewComboBoxColumn ColProc = CadenaRef.Columns[0] as DataGridViewComboBoxColumn;
            ColProc.Items.Clear();
            for (int i=1;i<=cantidadProc;i++)
            {
                ColProc.Items.Add(i.ToString());
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
                Idproceso.Visible = true;
                cantidadProc = Int32.Parse(CantidadPr.Text);
            }
            if (aVariosProc != ts)
            {
                aVariosProc.Checked = false;
                Idproceso.Visible = false;
                cantidadProc = 1;
            }
            definirdatosCombo();
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
                Mimemoria.AmbReem = Memoria.Ambitosreemplazo.LOCAL;
            }
            if (AmRlocal != ts)
            {
                AmRlocal.Checked = false;
                Mimemoria.AmbReem = Memoria.Ambitosreemplazo.Global;
            }
        }
        private void estinst(object sender, DataGridViewCellEventArgs e)
        {
            instanteseleccionado = e.RowIndex;
        }
        private void tratarCadenaDeReferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (solicitarcantp() && solicitartamp())
                {
                    Mimemoria.cantprocesos = cantidadProc;
                    int[] tamaniosmax = new int[cantidadProc];
                    for (int i = 0; i < cantidadProc; i++)
                    {
                        tamaniosmax[i] = 0;
                    }
                    int cantidadfilas = CadenaRef.Rows.Count - 1;
                    if (cantidadfilas > 0)
                    {
                        for (int i = 0; i < cantidadfilas; i++)
                        {
                            int proceso = Int32.Parse(CadenaRef.Rows[i].Cells[0].Value.ToString());
                            int direccion = Int32.Parse(CadenaRef.Rows[i].Cells[1].Value.ToString());
                            if (direccion > tamaniosmax[proceso - 1])
                            {
                                tamaniosmax[proceso-1] = direccion;
                            }
                        }
                        Mimemoria.calcularcantpagPro(tamaniosmax);
                        for (int i = 0; i < cantidadfilas; i++)
                        {
                            int proceso = Int32.Parse(CadenaRef.Rows[i].Cells[0].Value.ToString());
                            int direccion = Int32.Parse(CadenaRef.Rows[i].Cells[1].Value.ToString());
                            if (!Mimemoria.paginaenmemoria(proceso-1,direccion,i))
                            {
                                if (!Mimemoria.estallena())
                                {
                                    Mimemoria.asignarmemoria(proceso-1,direccion,i);
                                }
                            }
                            CadenaRef.Rows[i].ContextMenuStrip = MenuCreferencia;
                            CadenaRef.CellClick += new DataGridViewCellEventHandler(estinst);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar por lo menos una direccion a memoria");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar numeros en las direcciones");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe ingresar valores no nulos en las referencias a memoria");
            }
        }

        private void CantidadPr_TextChanged(object sender, EventArgs e)
        {
            try {
                aUnoProc.Checked = false;
                aVariosProc.Checked = true;
                cantidadProc = Int32.Parse(CantidadPr.Text);
                if (cantidadProc<2)
                {
                    MessageBox.Show("Debe ingresar un numero mayor que 2 en la cantidad de procesos");
                    CantidadPr.Text = "2";
                    cantidadProc = 2;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un numero en la cantidad de procesos");
                CantidadPr.Text = "2";
                cantidadProc = 2;
            }
            definirdatosCombo();
        }

        private void verMapaDeMemoriaEnEsteInstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mimemoria.VermapaMemoria(instanteseleccionado);
        }

        private void definirTablasDePaginasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mimemoria.verTablaPaginas();
        }
    }
}
