using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_de_reemplazo
{
    public class Memoria
    {
        private VisualizadorTP VisualTP;
        private TablaPagina MitablaP;
        private MapaMemoria Mimapa;
        public enum Ambitosreemplazo { LOCAL = 1, Global = 2 };
        public Ambitosreemplazo AmbReem;
        public enum AlgsReemplazo { FIFO = 1, Optimo, LRU, SegundaOportunidad };
        public AlgsReemplazo Algreem;
        private List<int[]> mapasmemoria;
        private List<int[]> mapaspaginas;
        int[] mapamemoria;
        int[] mapapaginas;
        public int cantprocesos;
        public int cantpaginas;
        public int tamaniopagina;
        public Memoria()
        {
            MitablaP = new TablaPagina();
        }
        public void definircantpag(int cant)
        {
            cantpaginas = cant;
            mapamemoria = new int[cant];
            mapapaginas = new int[cant];
            mapasmemoria = new List<int[]>();
            mapaspaginas = new List<int[]>();
            for (int i = 0; i < cantpaginas; i++)
            {
                mapamemoria[i] = -1;
                mapapaginas[i] = -1;
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
        public void asignarmemoria(int proceso, int direccion, int instante)
        {
            for (int i = 0; i < cantpaginas; i++)
            {
                if (mapamemoria[i] == -1)
                {
                    mapamemoria[i] = proceso;
                    mapapaginas[i] = direccion / tamaniopagina;
                    MitablaP.asignarmarco(proceso, direccion / tamaniopagina, i, instante);
                    //MessageBox.Show("Se le asigna al proceso "+proceso+" el marco "+i);
                    break;
                }
            }
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
                    sr = mapama[i] + "," + mapapa[i];
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
        public void elegirmarcoraeem()
        {
        }
    }
}
