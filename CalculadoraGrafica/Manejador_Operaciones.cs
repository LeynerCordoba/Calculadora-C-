using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalculadoraGrafica
{
    class Manejador_Operaciones
    {


        DataBases bd = new DataBases();
        public int RegistrarOperacion(Operaciones op)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into operaciones (operacion, resultado) values ('{0}','{1}')",
                op.Operacion, op.Resultado), bd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        
        public int Actualizar(Operaciones op)
        {
            int retorno = 0;
            MySqlConnection conexion = bd.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update operaciones set operacion='{0}', resultado='{1}'",
                op.Operacion, op.Resultado), bd.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        
         public  List<Operaciones> Listar()
         {
             List<Operaciones> _lista = new List<Operaciones>();

             MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM operaciones"), bd.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
             while (_reader.Read())
             {
                Operaciones op = new Operaciones();
               //  pCliente.Id = _reader.GetInt32(0);
                op.Operacion = _reader.GetString(0);
                 op.Resultado = _reader.GetString(1);
                 _lista.Add(op);
             }

             return _lista;
         }
        /*
         public static Cliente ObtenerCliente(int pId)
         {
             Cliente pCliente = new Cliente();
             MySqlConnection conexion = BdComun.ObtnerCOnexion();

             MySqlCommand _comando = new MySqlCommand(String.Format("SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes where IdCliente={0}", pId), conexion);
             MySqlDataReader _reader = _comando.ExecuteReader();
             while (_reader.Read())
             {
                 pCliente.Id = _reader.GetInt32(0);
                 pCliente.Nombre = _reader.GetString(1);
                 pCliente.Apellido = _reader.GetString(2);
                 pCliente.Fecha_Nac = _reader.GetString(3);
                 pCliente.Direccion = _reader.GetString(4);

             }

             conexion.Close();
             return pCliente;

         }

         public static int Eliminar(int pId)
         {
             int retorno = 0;
             MySqlConnection conexion = BdComun.ObtenerConexion();

             MySqlCommand comando = new MySqlCommand(string.Format("Delete From clientes where IdCliente={0}", pId), conexion);

             retorno = comando.ExecuteNonQuery();
             conexion.Close();

             return retorno;

         }

     */


    }
}
