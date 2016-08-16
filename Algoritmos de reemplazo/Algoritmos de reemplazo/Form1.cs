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
        int cantPRap;
        int instanteseleccionado;
        public bool unosolo;
        public Form1()
        {
            InitializeComponent();
            RefAproceso = false;
            Mimemoria = new Memoria(this);
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
            //if (segundaOTM != ts)
            //{
            //    segundaOTM.Checked = false;
            //}
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
            //if (ts == segundaOTM)
            //{
            //    Mimemoria.Algreem = Memoria.AlgsReemplazo.SegundaOportunidad;
            //}
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
                unosolo = true;
                cantidadProc = 1;
            }
            if (Adirecciones != ts)
            {
                Adirecciones.Checked = false;
                RefAproceso = true;
                unosolo = false;
                if (aVariosProc.Checked)
                {
                    Idproceso.Visible = true;
                }
                cantidadProc = cantPRap;
            }
            definirdatosCombo();
        }
        private void definirdatosCombo()
        {
            DataGridViewComboBoxColumn ColProc = CadenaRef.Columns[0] as DataGridViewComboBoxColumn;
            ColProc.Items.Clear();
            CadenaRef.Rows.Clear();
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
                unosolo = false;
                cantidadProc = Int32.Parse(CantidadPr.Text);
            }
            if (aVariosProc != ts)
            {
                aVariosProc.Checked = false;
                unosolo = true;
                Idproceso.Visible = false;
                cantidadProc = 1;
            }
            cantPRap = cantidadProc;
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
            int cantC = 0;
            int cantE = 0;
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
                    Mimemoria.AlgreemBack = Mimemoria.Algreem;
                    if (cantidadfilas > 0)
                    {
                        for (int i = 0; i < cantidadfilas; i++)
                        {
                            int proceso;
                            if (unosolo)
                            {
                                proceso = 0;
                            }
                            else
                            {
                                proceso = Int32.Parse(CadenaRef.Rows[i].Cells[0].Value.ToString())-1;
                            }
                            int direccion = Int32.Parse(CadenaRef.Rows[i].Cells[1].Value.ToString());
                            if (direccion > tamaniosmax[proceso])
                            {
                                tamaniosmax[proceso] = direccion;
                            }
                        }
                        Mimemoria.calcularcantpagPro(tamaniosmax);
                        for (int i = 0; i < cantidadfilas; i++)
                        {
                            int proceso;
                            DataGridViewCellStyle MDstyle = new DataGridViewCellStyle();
                            MDstyle.BackColor = Color.White;
                            MDstyle.ForeColor = Color.Black;
                            CadenaRef.Rows[i].Cells[1].Style = MDstyle;
                            if (unosolo)
                            {
                                proceso = 0;
                            }
                            else
                            {
                                proceso = Int32.Parse(CadenaRef.Rows[i].Cells[0].Value.ToString()) - 1;
                            }
                            int direccion = Int32.Parse(CadenaRef.Rows[i].Cells[1].Value.ToString());
                            if (!Mimemoria.paginaenmemoria(proceso, direccion, i))
                            {
                                if (!Mimemoria.estallena())
                                {
                                    Mimemoria.asignarmemoria(proceso, direccion, i);
                                    DataGridViewCellStyle Mstyle = new DataGridViewCellStyle();
                                    Mstyle.BackColor = Color.OrangeRed;
                                    Mstyle.ForeColor = Color.White;
                                    CadenaRef.Rows[i].Cells[1].Style = Mstyle;
                                    cantC++;
                                }
                                else
                                {
                                    Mimemoria.reemplazarMarco(proceso,direccion,i);
                                    DataGridViewCellStyle Mstyle = new DataGridViewCellStyle();
                                    Mstyle.BackColor = Color.IndianRed;
                                    Mstyle.ForeColor = Color.White;
                                    CadenaRef.Rows[i].Cells[1].Style = Mstyle;
                                    cantE++;
                                }
                            }
                            else
                            {
                                Mimemoria.referenciar(proceso,direccion,i);
                            }
                            Mimemoria.actualizartablas();
                            CadenaRef.Rows[i].Cells[2].Value = Mimemoria.obtenerDirFisica(proceso,direccion);
                            CadenaRef.Rows[i].ContextMenuStrip = MenuCreferencia;
                            CadenaRef.CellClick += new DataGridViewCellEventHandler(estinst);
                        }
                        FPC.Text="Fallos de pagina comunes: "+cantC;
                        FPE.Text = "Fallos de pagina atribuibles al algoritmo: " + cantE;
                        Mimemoria.Algreem = Mimemoria.AlgreemBack;
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
            cantPRap = cantidadProc;
            definirdatosCombo();
        }

        private void verMapaDeMemoriaEnEsteInstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mimemoria.VermapaMemoria(instanteseleccionado);
        }

        private void definirTablasDePaginasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mimemoria.verTablaPaginas(0);
        }

        private void verTablasDePaginasEnEsteInstatnteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mimemoria.verTablaPaginas(instanteseleccionado);
        }


        private void meotodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
