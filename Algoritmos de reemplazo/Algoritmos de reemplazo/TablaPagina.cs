using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_de_reemplazo
{
    public class TablaPagina
    {
        Memoria Mimemoria;
        public List<List<int[]>> TValidos;
        public List<List<int[]>> MUbicacion;
        public List<List<int[]>> ICarga;
        public List<List<int[]>> BR;
        public List<List<int[]>> BM;
        public List<List<int[]>> Cs;
        //Tablas de paginas por proceso
        public List<int[]> TPBvalidos;
        public List<int[]> MarcosUbicacion;
        public List<int[]> InstCarga;
        public List<int[]> BitsR;
        public List<int[]> BitsM;
        public List<int[]> Contadores;
        public int[] cantpagproc;
        public int cantproc;
        public TablaPagina(Memoria memac)
        {
            Mimemoria = memac;
        }
        public void DefinirTablas(int[] cantpaginas)
        {
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
            cantpagproc = (int[])cantpaginas.Clone();
            for (int i = 0; i < cantproc; i++)
            {
                int[] Bitsvalidosa = new int[cantpaginas[i]];
                int[] MarcosUba = new int[cantpaginas[i]];
                int[] InstantCar = new int[cantpaginas[i]];
                int[] BitsRa = new int[cantpaginas[i]];
                int[] BitsMa = new int[cantpaginas[i]];
                int[] Contadoresa = new int[cantpaginas[i]];
                for (int h = 0; h < cantpaginas[i]; h++)
                {
                    Bitsvalidosa[h] = -1;
                    MarcosUba[h] = -1;
                    InstantCar[h] = -1;
                    BitsRa[h] = -1;
                    BitsMa[h] = -1;
                    Contadoresa[h] = -1;
                }
                TPBvalidos.Add(Bitsvalidosa);
                MarcosUbicacion.Add(MarcosUba);
                InstCarga.Add(InstantCar);
                BitsR.Add(BitsRa);
                BitsM.Add(BitsMa);
                Contadores.Add(Contadoresa);
            }
            TValidos.Add(ClonaRlista(TPBvalidos));
            MUbicacion.Add(ClonaRlista(MarcosUbicacion));
            ICarga.Add(ClonaRlista(InstCarga));
            BR.Add(ClonaRlista(BitsR));
            BM.Add(ClonaRlista(BitsM));
            Cs.Add(ClonaRlista(Contadores));
        }
        public bool paginaenmemoria(int idproceso, int pagina, int instante)
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
        public void asignarmarco(int proceso, int pagina, int marco, int instante)
        {
            int[] Bitsvalidop = TPBvalidos[proceso];
            Bitsvalidop[pagina] = 1;
            MarcosUbicacion[proceso][pagina] = marco;
            InstCarga[proceso][pagina] = instante;
            Contadores[proceso][pagina] = instante;
        }
        public void ReiniciarFilaTabla(int proceso,int pagina)
        {
            TPBvalidos[proceso][pagina] = 0;
            MarcosUbicacion[proceso][pagina] = -1;
            InstCarga[proceso][pagina] = -1;
            Contadores[proceso][pagina] = -1;
        }
        public void ReferenciarMarco(int proceso, int pagina,int instante)
        {
            int[] Contador = Contadores[proceso];
            Contador[pagina]=instante;
            Mimemoria.ContadoresM[MarcosUbicacion[proceso][pagina]] = instante;
        }
        public int ObtnerMarco(int proceso, int pagina)
        {
            int[] MarsU = MarcosUbicacion[proceso];
            return MarsU[pagina];
        }
        private List<int[]> ClonaRlista(List<int[]>Lista)
        {
            List<int[]> NuevaLista= new List<int[]>();
            for (int i=0;i<Lista.Count;i++)
            {
                int[] NarrA = (int[])Lista[i].ToArray().Clone();
                int longA = Lista[i].Length;
                NuevaLista.Add(NarrA);
            }
            return NuevaLista;
        }
        public void agregarTablasinst()
        {
            TValidos.Add(ClonaRlista(TPBvalidos));
            MUbicacion.Add(ClonaRlista(MarcosUbicacion));
            ICarga.Add(ClonaRlista(InstCarga));
            BR.Add(ClonaRlista(BitsR));
            BM.Add(ClonaRlista(BitsM));
            Cs.Add(ClonaRlista(Contadores));
        }
        public int elegirPaginaReem(int proceso)
        {
            int menor = -1;
            int indicemenor = -1;
            int cantpagPa=cantpagproc[proceso];
            switch (Mimemoria.Algreem)
            {
                case Memoria.AlgsReemplazo.FIFO:
                    for (int i = 0; i < cantpagPa; i++)
                    {
                        if ((InstCarga[proceso][i] < menor && InstCarga[proceso][i] !=-1) || menor == -1)
                        {
                            menor = InstCarga[proceso][i];
                            indicemenor = i;
                        }
                    }
                    break;
                case Memoria.AlgsReemplazo.LRU:
                    for (int i = 0; i < cantpagPa; i++)
                    {
                        if ((Contadores[proceso][i] < menor && Contadores[proceso][i] !=-1) || menor == -1)
                        {
                            menor = Contadores[proceso][i];
                            indicemenor = i;
                        }
                    }
                    break;
            }
            return MarcosUbicacion[proceso][indicemenor];
        }
    }
}
