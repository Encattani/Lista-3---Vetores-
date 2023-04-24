using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1304
{
    internal class ex6
    {
        public static void Exercicio6()
        {
            //int[] entradasNumericas = Program.LerEntradas(10);
           int[] entradasNumericas = Program.GerarAleatorios(99);
           Program.ImprimirNumeros(entradasNumericas);
           int n = Program.SomaImpar(entradasNumericas);
        }
    }
}
