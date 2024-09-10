using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupa.Model
{
    internal class conect
    {
        public static string conexao()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gisele.hsilva1\source\repos\Roupa\Roupa\Dados\bdCompras.mdf;Integrated Security=True";

        }
    }
}
