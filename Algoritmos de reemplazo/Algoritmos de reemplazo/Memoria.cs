using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Algoritmos_de_reemplazo
{
    public class Memoria
    {
        private VisualizadorTP VisualTP;
        private TablaPagina MitablaP;
        private MapaMemoria Mimapa;
        Form1 FormPrinc;
        public enum Ambitosreemplazo { LOCAL = 1, Global = 2 };
        public Ambitosreemplazo AmbReem;
        public enum AlgsReemplazo { FIFO = 1, Optimo, LRU, SegundaOportunidad };
        public AlgsReemplazo Algreem;
        public AlgsReemplazo AlgreemBack;
        private List<int[]> mapasmemoria;
        private List<int[]> mapaspaginas;
        public int[] InstCargaM;
        public int[] BitsRM;
        public int[] BitsMM;
        public int[] ContadoresM;
        int[] mapamemoria;
        int[] mapapaginas;
        public int cantprocesos;
        public int cantpaginas;
        public int tamaniopagina;
        public Memoria(Form1 forma)
        {
            MitablaP = new TablaPagina(this);
            FormPrinc = forma;
        }
        public void definircantpag(int cant)
        {
            cantpaginas = cant;
            mapamemoria = new int[cant];
            mapapaginas = new int[cant];
            InstCargaM = new int[cant];
            BitsRM = new int[cant];
            BitsMM = new int[cant];
            ContadoresM = new int[cant];
            mapasmemoria = new List<int[]>();
            mapaspaginas = new List<int[]>();
            for (int i = 0; i < cantpaginas; i++)
            {
                mapamemoria[i] = -1;
                mapapaginas[i] = -1;
                InstCargaM[i] = -1;
                BitsRM[i] = -1;
                BitsMM[i] = -1;
                ContadoresM[i] = -1;
            }
        }
        public bool estallena()
        {
            bool llena = true;
            for (int i = 0; i < cantpaginas; i++)
            {
                if (mapamemoria[i] == -1)
                {
                    llena = false;
                }
            }
            return llena;
        }

        public void calcularcantpagPro(int[] tamaniosmax)
        {
            int[] cantpaginas = new int[cantprocesos];
            for (int i = 0; i < cantprocesos; i++)
            {
                cantpaginas[i] = (int)Math.Floor((double)tamaniosmax[i] / (double)tamaniopagina) + 1;
                //MessageBox.Show("La cantidad de paginas de "+i+" es de "+ cantpaginas[i]);
            }
            MitablaP.cantproc = cantprocesos;
            MitablaP.DefinirTablas(cantpaginas);
        }
        public bool paginaenmemoria(int proceso, int direccion, int instante)
        {
            int indice = Array.IndexOf(mapamemoria, proceso);
            if (indice != -1)
            {
                return MitablaP.paginaenmemoria(proceso, direccion / tamaniopagina, instante);
            }
            else
            {
                return false;
            }
        }
        public int obtenerDirFisica(int proceso, int direccion)
        {
            int dir = MitablaP.ObtnerMarco(proceso, direccion/tamaniopagina)*tamaniopagina+ (direccion % tamaniopagina);
            return dir;
        }
        public void referenciar(int proceso, int direccion,int instante)
        {
            MitablaP.ReferenciarMarco(proceso, direccion / tamaniopagina, instante);
            mapasmemoria.Add((int[])mapamemoria.Clone());
            mapaspaginas.Add((int[])mapapaginas.Clone());
        }
        public void asignarmemoria(int proceso, int direccion, int instante)
        {
            for (int i = 0; i < cantpaginas; i++)
            {
                if (mapamemoria[i] == -1)
                {
                    mapamemoria[i] = proceso;
                    mapapaginas[i] = direccion / tamaniopagina;
                    InstCargaM[i] = instante;
                    ContadoresM[i] = instante;
                    MitablaP.asignarmarco(proceso, direccion / tamaniopagina, i, instante);
                    //MessageBox.Show("Se le asigna al proceso "+proceso+" el marco "+i);
                    break;
                }
            }
            mapasmemoria.Add((int[])mapamemoria.Clone());
            mapaspaginas.Add((int[])mapapaginas.Clone());
        }
        public void reemplazarMarco(int proceso, int direccion, int instante)
        {
            int marcoelegido = ElegirMreem(proceso, instante);
            MitablaP.ReiniciarFilaTabla(mapamemoria[marcoelegido],mapapaginas[marcoelegido]);
            mapamemoria[marcoelegido] = proceso;
            mapapaginas[marcoelegido] = direccion / tamaniopagina;
            InstCargaM[marcoelegido] = instante;
            ContadoresM[marcoelegido] = instante;
            MitablaP.asignarmarco(proceso, direccion / tamaniopagina, marcoelegido, instante);
            mapasmemoria.Add((int[])mapamemoria.Clone());
            mapaspaginas.Add((int[])mapapaginas.Clone());
        }
        public void VermapaMemoria(int instante)
        {
            int[] mapama = mapasmemoria[instante];
            int[] mapapa = mapaspaginas[instante];
            Mimapa = new MapaMemoria();
            for (int i = 0; i < cantpaginas; i++)
            {
                string sr = "";
                if (mapama[i] != -1)
                {
                    sr = (mapama[i]+1) + "," + mapapa[i];
                }
                else
                {
                    sr = "-";
                }
                string[] marcoa = { i.ToString(), sr };
                Mimapa.MapaMemT.Rows.Add(marcoa);
            }
            Mimapa.Show();
        }
        public void verTablaPaginas(int instante)
        {
            VisualTP = new VisualizadorTP(MitablaP);
            VisualTP.instantea = instante+1;
            VisualTP.cantproc = MitablaP.cantproc;
            VisualTP.Show();
        }
        public void actualizartablas()
        {
            MitablaP.agregarTablasinst();
        }
        public int reemPGlobal(int instante)
        {
            int menor = -1;
            int indicemenor = -1;
            switch (Algreem)
            {
                case AlgsReemplazo.FIFO:
                    for (int i = 0; i < cantpaginas; i++)
                    {
                        if (InstCargaM[i] < menor || menor == -1)
                        {
                            menor = InstCargaM[i];
                            indicemenor = i;
                        }
                    }
                    break;
                case AlgsReemplazo.LRU:
                    for (int i = 0; i < cantpaginas; i++)
                    {
                        if (ContadoresM[i] < menor || menor == -1)
                        {
                            menor = ContadoresM[i];
                            indicemenor = i;
                        }
                    }
                    break;
            }
            return indicemenor;
        }
        private int Buscarprimeraaparicion(int proceso,int instante)
        {
            int[] primerasapariciones=new int[cantpaginas];
            int[] primerasaparicionesl = new int[cantpaginas];
            int proca;
            int direccion;
            int pag;
            for (int i = 0; i<cantpaginas;i++)
            {
                primerasapariciones[i]=-1;
                primerasaparicionesl[i] = -1;
            }
            int cantidadfilas = FormPrinc.CadenaRef.Rows.Count - 1;
            for (int i=0;i<cantpaginas;i++)
            {
                for (int h = instante + 1; h < cantidadfilas; h++)
                {
                    if (FormPrinc.unosolo)
                    {
                        proca = 0;
                    }
                    else
                    {
                        proca = Int32.Parse(FormPrinc.CadenaRef.Rows[h].Cells[0].Value.ToString()) - 1;
                    }
                    direccion = Int32.Parse(FormPrinc.CadenaRef.Rows[h].Cells[1].Value.ToString());
                    pag = direccion / tamaniopagina;
                    if (proca == proceso && mapamemoria[i] == proca && pag == mapapaginas[i])
                    {
                        primerasaparicionesl[i] = h;
                    }
                    if (mapamemoria[i] == proca && pag == mapapaginas[i])
                    {
                        primerasapariciones[i] = h;
                        break;
                    }
                }
            }
            int mayor = 0;
            int indicemayor = -1;
            //Sirve para cuando hay solo una referencia mas
            int conta = 0;
            if (AmbReem== Ambitosreemplazo.LOCAL)
            {
                for (int i=0;i<cantpaginas;i++)
                {
                    if (primerasaparicionesl[i]>mayor)
                    {
                        //MessageBox.Show("La primera aparicion local es en" + i);
                        mayor = primerasaparicionesl[i];
                        indicemayor = i;
                        conta++;
                    }
                }
                if (conta==1)
                {
                    return -1;
                }
            }
            if (AmbReem == Ambitosreemplazo.Global || indicemayor==-1)
            {
                for (int i = 0; i < cantpaginas; i++)
                {
                    if (primerasapariciones[i] > mayor)
                    {
                        //MessageBox.Show("La primera aparicion global es en" + i);
                        mayor = primerasapariciones[i];
                        indicemayor = i;
                        conta++;
                    }
                }
                if (conta==1)
                {
                    return -1;
                }
            }
            return indicemayor;
        }
        public int ElegirMreem(int proceso,int instante)
        {
            int indicesel=-1;
            if (Algreem == AlgsReemplazo.Optimo)
            {
                indicesel = Buscarprimeraaparicion(proceso, instante);
            }
            if (Algreem != AlgsReemplazo.Optimo || indicesel==-1)
            {
                Algreem = AlgsReemplazo.FIFO;
                switch (AmbReem)
                {
                    case Ambitosreemplazo.Global:
                        indicesel = reemPGlobal(instante);
                        break;
                    case Ambitosreemplazo.LOCAL:
                        //MessageBox.Show("Se reemplazara localmente");
                        indicesel = MitablaP.elegirPaginaReem(proceso);
                        if (indicesel == -1)
                        {
                            //MessageBox.Show("A pesar de que esta elegida la opcion de ambito local se realizara reemplazo global");
                            indicesel = reemPGlobal(instante);
                        }
                        break;
                }
            }
            
            //MessageBox.Show("El indice menor es "+indicemenor);
            return indicesel;
        }
    }
}
