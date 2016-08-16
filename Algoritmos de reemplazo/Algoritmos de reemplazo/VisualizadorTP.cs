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
    public partial class VisualizadorTP : Form
    {
        TablaPagina MisTablas;
        //Tablas de paginas de proceso por instante
        public int instantea;
        public int cantproc;
        public VisualizadorTP(TablaPagina tablac)
        {
            InitializeComponent();
            MisTablas = tablac;
        }
        private string DeterminarT(int valor)
        {
            if (valor == -1)
            {
                return "-";
            }
            else
            {
                return valor.ToString();
            }
        }
        private void TablasPaginascs_Load(object sender, EventArgs e)
        {
            ListaProc.Items.Clear();
            //MessageBox.Show("Se visualizara el instante "+instantea);
            for (int i=1;i<=cantproc;i++)
            {
                ListaProc.Items.Add(i.ToString());
            }
            ListaProc.SelectedIndex = 0;
            TablaPA.Rows.Clear();
            int cantpagactual = MisTablas.cantpagproc[0];
            int[] Bitsvalidop = MisTablas.TValidos[instantea][0];
            int[] InCarga = MisTablas.ICarga[instantea][0];
            int[] Marub = MisTablas.MUbicacion[instantea][0];
            int[] BitR = MisTablas.BR[instantea][0];
            int[] BitM = MisTablas.BM[instantea][0];
            int[] Conts = MisTablas.Cs[instantea][0];
            for (int i=0;i<cantpagactual;i++)
            {
                TablaPA.Rows.Add();
                TablaPA.Rows[i].Cells[0].Value = i.ToString();
                TablaPA.Rows[i].Cells[1].Value = DeterminarT(Marub[i]);
                TablaPA.Rows[i].Cells[2].Value = DeterminarT(InCarga[i]);
                string bv = "";
                if (Bitsvalidop[i] == 0 || Marub[i]==-1)
                {
                    bv = "i";
                }
                else
                {
                    bv = "v";
                }
                TablaPA.Rows[i].Cells[3].Value = bv;
                TablaPA.Rows[i].Cells[4].Value = DeterminarT(Conts[i]);
                TablaPA.Rows[i].Cells[5].Value = DeterminarT(BitR[i]);
                TablaPA.Rows[i].Cells[6].Value = DeterminarT(BitM[i]);
            }
        }

        private void ListaProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ListaProc.SelectedIndex;
            TablaPA.Rows.Clear();
            int cantpagactual = MisTablas.cantpagproc[indice];
            int[] Bitsvalidop = MisTablas.TValidos[instantea][indice];
            int[] InCarga = MisTablas.ICarga[instantea][indice];
            int[] Marub = MisTablas.MUbicacion[instantea][indice];
            int[] BitR = MisTablas.BR[instantea][indice];
            int[] BitM = MisTablas.BM[instantea][indice];
            int[] Conts = MisTablas.Cs[instantea][indice];
            for (int i = 0; i < cantpagactual; i++)
            {
                TablaPA.Rows.Add();
                TablaPA.Rows[i].Cells[0].Value = i.ToString();
                TablaPA.Rows[i].Cells[1].Value = Marub[i];
                TablaPA.Rows[i].Cells[2].Value = InCarga[i];
                string bv = "";
                if (Bitsvalidop[i] == 0)
                {
                    bv = "i";
                }
                else
                {
                    bv = "v";
                }
                TablaPA.Rows[i].Cells[3].Value = bv;
                TablaPA.Rows[i].Cells[4].Value = Conts[i];
                TablaPA.Rows[i].Cells[5].Value = BitR[i];
                TablaPA.Rows[i].Cells[6].Value = BitM[i];
            }
        }
    }
}
