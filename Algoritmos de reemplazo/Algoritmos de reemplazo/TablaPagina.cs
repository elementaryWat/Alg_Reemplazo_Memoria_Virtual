using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_de_reemplazo
{
    public class TablaPagina
    {
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
            int[] MarcoU = MarcosUbicacion[proceso];
            MarcoU[pagina] = marco;
            int[] instanteC = InstCarga[proceso];
            instanteC[pagina] = instante;
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
    }
}
