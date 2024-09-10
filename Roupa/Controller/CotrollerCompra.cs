using Roupa.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupa.Controller
{
    internal class CotrollerCompra
    {
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(conect.conexao());
           SqlCommand cmd = new SqlCommand("Procedure", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@Tamanho", compra.Tamanho);
                cmd.Parameters.AddWithValue("@Modelo", compra.Modelo);
                cmd.Parameters.AddWithValue("@Cor", compra.Cor);
                cmd.Parameters.AddWithValue("@Numero", compra.Numero);


                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Obrigado(a), por realizar a compra e faça um bom aproveito");

            }
            catch (Exception)
            {
                throw;
            }



        }


    }
}
