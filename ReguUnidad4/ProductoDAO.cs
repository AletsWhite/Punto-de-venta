using MySqlConnector;
using PuntoDeVenta.POJOS;
using PuntoDeVenta.BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PuntoDeVenta.BackEnd
{
    class ProductoDAO
    {
        
        public static List<Producto> Buscar(String nombre)
        {
            List<Producto> lista = new List<Producto>();

            MySqlCommand comando = new MySqlCommand(String.Format(
              "select productid, productname, unitprice from products where productname = '{0}'", nombre), Conexion.abrirConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.id = reader.GetInt32(0);
                pProducto.nombre = reader.GetString(1);
                pProducto.precio = reader.GetDouble(2);

                lista.Add(pProducto);
            }

            return lista;
        }

        public static bool agregarProductoOrden(int orderid, int productid, double unitprice, string nombre, string orderdate, int quantity)
        {
            // CREACION Y CONFIGURACION DE LA CONEXION
            MySqlTransaction tran = null;
            Conexion.abrirConexion();
            try
            {
                Conexion.abrirConexion();
                tran = Conexion.abrirConexion().BeginTransaction();

                string insertarOrden = "insert into orders(orderid, orderdate) values(@orderid, @orderdate);";
                MySqlCommand comandoOrden = new MySqlCommand(insertarOrden, Conexion.abrirConexion());
                comandoOrden.Parameters.AddWithValue("@orderid", orderid);
                comandoOrden.Parameters.AddWithValue("@orderdate", orderdate);
                comandoOrden.ExecuteNonQuery();

                // CODIGO SQL PARA INSERTAR LA ORDEN EN ORDER DETAILS
                string cadena = "insert into `order details`(orderid, productid, unitprice, quantity) values(@orderid, @productid, @unitprice, @quantity)";
                MySqlCommand comando = new MySqlCommand(cadena, Conexion.abrirConexion());
                comando.Parameters.AddWithValue("@orderid", orderid);
                comando.Parameters.AddWithValue("@productid", productid);
                comando.Parameters.AddWithValue("@unitprice", unitprice);
                comando.Parameters.AddWithValue("@quantity", quantity);
                comando.ExecuteNonQuery();

                // CODIGO SQL PARA QUITAR SALDO
                String updateorigen = "update products set unitsinstock = unitsinstock - @resta where productName = @productName";
                MySqlCommand comandoAO = new MySqlCommand(updateorigen, Conexion.abrirConexion());
                comandoAO.Parameters.AddWithValue("@productName", nombre);
                comandoAO.Parameters.AddWithValue("@resta", quantity);
                comandoAO.ExecuteNonQuery();

                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexion.abrirConexion().Close();
                Conexion.abrirConexion().Dispose();
            }
        }
    }
}
