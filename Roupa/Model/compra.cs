using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupa.Model
{
    internal class compra
    {
        private static int codigo;
        private static string tamanho;
        private static string modelo;
        private static string cor;
        private static string numero;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Tamanho { get => tamanho; set => tamanho = value; }
        public static string Modelo { get => modelo; set => modelo = value; }
        public static string Cor { get => cor; set => cor = value; }
        public static string Numero { get => numero; set => numero = value; }
    }
}
