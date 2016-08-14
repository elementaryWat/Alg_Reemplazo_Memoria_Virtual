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
    public partial class TablasPaginascs : Form
    {
        //Tablas de paginas de proceso por instante
        List<List<int[]>> TValidos;
        List<List<int[]>> MUbicacion;
        List<List<int[]>> ICarga;
        List<List<int[]>> BR;
        List<List<int[]>> BM;
        List<List<int[]>> Cs;
        //Tablas de paginas por proceso
        List<int[]> TPBvalidos;
        List<int[]> MarcosUbicacion;
        List<int[]> InstCarga;
        List<int[]> BitsR;
        List<int[]> BitsM;
        List<int[]> Contadores;
        int[] cantpagproc;
        public int instantea;
        public int cantproc;
        public TablasPaginascs()
        {
            InitializeComponent();
            TValidos = new List<List<int[]>>();
            MUbicacion = new List<List<int[]>>();
            ICarga = new List<List<int[]>>();
            BR = new List<List<int[]>>();
            BM = new List<List<int[]>>();
            Cs = new List<List<int[]>>();
            TPBvalidos = new List<int[]>();
            MarcosUbicacion = new List<int[]>();
            InstCarga = new List<int[]>();
            BitsR = new List<int[]>();
            BitsM = new List<int[]>();
            Contadores = new List<int[]>();
        }
        public void DefinirTablas(int[] cantpaginas)
        {
            cantpagproc = (int[])cantpaginas.Clone();
            for (int i=0;i<cantproc;i++)
            {
                int[] Bitsvalidosa = new int[cantpaginas[i]];
                int[] MarcosUba = new int[cantpaginas[i]];
                int[] InstantCar = new int[cantpaginas[i]];
                int[] BitsRa = new int[cantpaginas[i]];
                int[] BitsMa = new int[cantpaginas[i]];
                int[] Contadoresa = new int[cantpaginas[i]];
                for (int h=0;h<cantpaginas[i];h++)
                {
                    Bitsvalidosa[h] = 0;
                    MarcosUba[h] = 0;
                    InstantCar[h] = 0;
                    BitsRa[h] = 0;
                    BitsMa[h] = 0;
                    Contadoresa[h] = 0;
                }
                TPBvalidos.Add(Bitsvalidosa);
                MarcosUbicacion.Add(MarcosUba);
                InstCarga.Add(InstantCar);
                BitsR.Add(BitsRa);
                BitsM.Add(BitsMa);
                Contadores.Add(Contadoresa);
                TValidos.Add(TPBvalidos);
                MUbicacion.Add(MarcosUbicacion);
                ICarga.Add(InstCarga);
                BR.Add(BitsR);
                BM.Add(BitsM);
                Cs.Add(Contadores);
            }
        }
        public bool paginaenmemoria(int idproceso,int pagina,int instante)
        {
            int[] Bitsvalidop = TPBvalidos[idproceso];
            int[] Contador = InstCarga[idproceso];
            Contador[pagina] = instante;
            if (Bitsvalidop[pagina] == 1)
            {
                return true;
            }
            return false;
        }
        public void asignarmarco(int proceso,int pagina, int marco, int instante)
        {
            int[] Bitsvalidop = TPBvalidos[proceso];
            Bitsvalidop[pagina] = 1;
            int[] MarcoU = MarcosUbicacion[proceso];
            MarcoU[pagina] = marco;
            int[] instanteC = InstCarga[proceso];
            instanteC[pagina] = instante;
        }
        public void agregarTablasinst()
        {
            TValidos.Add(TPBvalidos);
            MUbicacion.Add(MarcosUbicacion);
            ICarga.Add(InstCarga);
            BR.Add(BitsR);
            BM.Add(BitsM);
            Cs.Add(Contadores);
        }
        private void TablasPaginascs_Load(object sender, EventArgs e)
        {
            ListaProc.Items.Clear();
            for (int i=1;i<=cantproc;i++)
            {
                ListaProc.Items.Add(i.ToString());
            }
            TablaPA.Rows.Clear();
            int cantpagactual = cantpagproc[0];
            int[] Bitsvalidop = TValidos[instantea][0];
            int[] InCarga = ICarga[instantea][0];
            int[] Marub = MUbicacion[instantea][0];
            int[] BitR = BR[instantea][0];
            int[] BitM = BM[instantea][0];
            int[] Conts = Cs[instantea][0];
            for (int i=0;i<cantpagactual;i++)
            {
                TablaPA.Rows.Add();
                TablaPA.Rows[i].Cells[0].Value = i.ToString();
                TablaPA.Rows[i].Cells[1].Value = Marub[i].ToString();
                TablaPA.Rows[i].Cells[2].Value = InCarga[i].ToString();
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
                TablaPA.Rows[i].Cells[4].Value = Conts[i].ToString();
                TablaPA.Rows[i].Cells[5].Value = BitR[i].ToString();
                TablaPA.Rows[i].Cells[6].Value = BitM[i].ToString();
            }
        }
    }
}
