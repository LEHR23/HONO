using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HONO
{
    class BasedeDatos
    {


        public static void crearbasededatos()
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                mycn.Close();
            }
            catch (Exception e)
            {
                SqlConnection myConn = new SqlConnection(Constantes.primeraconexion);
                SqlCommand myCommand = new SqlCommand(Constantes.basededatos, myConn);
                SqlCommand myCommand2 = new SqlCommand(Constantes.eluso, myConn);
                SqlCommand myCommand3 = new SqlCommand(Constantes.tablanota, myConn);
                SqlCommand myCommand4 = new SqlCommand(Constantes.tablatareas, myConn);
                SqlCommand myCommand5 = new SqlCommand(Constantes.procedimiento1, myConn);
                SqlCommand myCommand6 = new SqlCommand(Constantes.procedimiento2, myConn);
                SqlCommand myCommand7 = new SqlCommand(Constantes.procedimiento3, myConn);
                SqlCommand myCommand8 = new SqlCommand(Constantes.procedimiento4, myConn);
                SqlCommand myCommand9 = new SqlCommand(Constantes.procedimiento5, myConn);
                try
                {
                    myConn.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand2.ExecuteNonQuery();
                    myCommand3.ExecuteNonQuery();
                    myCommand4.ExecuteNonQuery();
                    myCommand5.ExecuteNonQuery();
                    myCommand6.ExecuteNonQuery();
                    myCommand7.ExecuteNonQuery();
                    myCommand8.ExecuteNonQuery();
                    myCommand9.ExecuteNonQuery();
                    MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
        }


        public static void insertar_tarea(String titulo, String fecha, String nivel, String estado, String contenido, String fechamodificacion, String fechaentrega)
        {
            SqlConnection mycn = new SqlConnection(Constantes.conexion);
            try
            {
                mycn.Open();
                String insertar = "insert into tareas values('" + titulo + "', '" + fecha + "', '" + nivel + "', '" + estado + "', '" + contenido + "', '" + fechamodificacion + "', '" + fechaentrega + "')";
                SqlCommand sql = new SqlCommand(insertar, mycn);
                if (sql.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("LA TAREA SE REGISTRO EXITOSAMENTE");
                }
                else
                {
                    MessageBox.Show("LA TAREA NO SE HA REGISTRADO");
                }
                mycn.Close();
            } catch (Exception e)
            {
                MessageBox.Show("OCURRIO UN ERROR AL REGISTRAR TAREA");
            }
            finally
            {
                if (mycn.State == ConnectionState.Open)
                {
                    mycn.Close();
                }
            }
        }

        public static void insertar_nota(String titulo, String fecha, String nivel, String contenido, String fechamodificacion)
        {
            SqlConnection mycn = new SqlConnection(Constantes.conexion);
            try
            {
                mycn.Open();
                String insertar = "insert into notas values('" + titulo + "', '" + fecha + "', '" + nivel + "', '" + contenido + "', '" + fechamodificacion + "')";
                SqlCommand sql = new SqlCommand(insertar, mycn);
                if (sql.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("LA NOTA SE REGISTRO EXITOSAMENTE");
                }
                else
                {
                    MessageBox.Show("LA NOTA NO SE HA REGISTRADO");
                }
                mycn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("OCURRIO UN ERROR AL REGISTRAR NOTA");
            }
            finally
            {
                if (mycn.State == ConnectionState.Open)
                {
                    mycn.Close();
                }
            }
        }

        public static List<Item> listanotas()
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                SqlCommand consulta = new SqlCommand(Constantes.listanotas, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                List<Item> lista = new List<Item>();
                while (resultado.Read())
                {
                    lista.Add(new Item(resultado.GetValue(0).ToString(),resultado.GetValue(1).ToString()));
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Item> listatareas()
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                SqlCommand consulta = new SqlCommand(Constantes.listatareas, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                List<Item> lista = new List<Item>();
                while (resultado.Read())
                {
                    lista.Add(new Item(resultado.GetValue(0).ToString(),resultado.GetValue(1).ToString()));
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Item consulta_nota(String id)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                String com = Constantes.consulta_nota + id + "'";
                SqlCommand consulta = new SqlCommand(com, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                Item Arr = new Item();
                while (resultado.Read())
                {
                    Arr.id = resultado.GetInt32(0).ToString();
                    Arr.titulo = resultado.GetValue(1).ToString();
                    Arr.fecha_creacion = resultado.GetValue(2).ToString();
                    Arr.nivel = resultado.GetValue(3).ToString();
                    Arr.contenido = resultado.GetValue(4).ToString();
                    Arr.fecha_modificacion = resultado.GetValue(5).ToString();
                }
                mycn.Close();
                return Arr;
            }
            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message);
                return null;
            }
        }

        public static Item consulta_tarea(String id)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                String com = Constantes.consulta_tarea + id + "'";
                SqlCommand consulta = new SqlCommand(com, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                Item Agrr = new Item();
                while (resultado.Read())
                {
                    Agrr.id = resultado.GetInt32(0).ToString();
                    Agrr.titulo = resultado.GetValue(1).ToString();
                    Agrr.fecha_creacion = resultado.GetValue(2).ToString();
                    Agrr.nivel = resultado.GetValue(3).ToString();
                    Agrr.estado = resultado.GetValue(4).ToString();
                    Agrr.contenido = resultado.GetValue(5).ToString();
                    Agrr.fecha_modificacion = resultado.GetValue(6).ToString();
                    Agrr.fecha_entrega = resultado.GetValue(7).ToString();
                }
                mycn.Close();
                return Agrr;
            }
            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message);
                return null;
            }
        }

        internal static void editar_tarea(Item item)
        {
            SqlConnection mycn = new SqlConnection(Constantes.conexion);
            try
            {
                mycn.Open();
                String actualizar = "update tareas set titulo = '" + item.titulo + "', nivel = '" + item.nivel + "', contenido = '" + item.contenido + "', fechamodificacion = '" + item.fecha_modificacion + "', fechaentrega = '" + item.fecha_entrega + "', estado = '" + item.estado + "' where idtareas = " + item.id;
                SqlCommand sql = new SqlCommand(actualizar, mycn);
                if (sql.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("LA TAREA SE ACTUALIZO EXITOSAMENTE");
                }
                else
                {
                    MessageBox.Show("LA TAREA NO SE HA ACTUALIZADO");
                }
                mycn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("OCURRIO UN ERROR AL ACTUALIZAR TAREA");
            }
            finally
            {
                if (mycn.State == ConnectionState.Open)
                {
                    mycn.Close();
                }
            }
        }

        internal static void editar_nota(Item item)
        {
            SqlConnection mycn = new SqlConnection(Constantes.conexion);
            try
            {
                mycn.Open();
                String actualizar = "update notas set titulo = '" + item.titulo + "', nivel = '" + item.nivel + "', contenido = '" + item.contenido + "', fechamodificacion = '" + item.fecha_modificacion + "' where idnotas = " + item.id;
                SqlCommand sql = new SqlCommand(actualizar, mycn);
                if (sql.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("LA NOTA SE ACTUALIZO EXITOSAMENTE");
                }
                else
                {
                    MessageBox.Show("LA NOTA NO SE HA ACTUALIZADO");
                }
                mycn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("OCURRIO UN ERROR AL ACTUALIZAR NOTA");
            }
            finally
            {
                if (mycn.State == ConnectionState.Open)
                {
                    mycn.Close();
                }
            }
        }

        public static List<Item> generarfecha(int tip)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                List<Item> lista = new List<Item>();
                if (tip == 1)
                {
                    SqlCommand consulta = new SqlCommand(Constantes.generar_notas_fechas, mycn);
                    SqlDataReader resultado = consulta.ExecuteReader();
                    Item item;
                    while (resultado.Read())
                    {
                        item = new Item();
                        item.titulo = resultado.GetValue(1).ToString();
                        item.fecha_creacion = resultado.GetValue(2).ToString();
                        item.nivel = resultado.GetValue(3).ToString();
                        item.contenido = resultado.GetValue(4).ToString();
                        item.fecha_modificacion = resultado.GetValue(5).ToString();
                        lista.Add(item);
                    }
                }
                else
                {
                    SqlCommand consulta = new SqlCommand(Constantes.generar_tareas_fechas, mycn);
                    SqlDataReader resultado = consulta.ExecuteReader();
                    Item item;
                    while (resultado.Read())
                    {
                        item = new Item();
                        item.titulo = resultado.GetValue(1).ToString();
                        item.fecha_creacion = resultado.GetValue(2).ToString();
                        item.nivel = resultado.GetValue(3).ToString();
                        item.estado = resultado.GetValue(4).ToString();
                        item.contenido = resultado.GetValue(5).ToString();
                        item.fecha_modificacion = resultado.GetValue(6).ToString();
                        item.fecha_entrega = resultado.GetValue(7).ToString();
                        lista.Add(item);

                    }
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Item> generarmodif(int tip)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                List<Item> lista = new List<Item>();
                if (tip == 1)
                {
                    SqlCommand consulta = new SqlCommand(Constantes.generar_notas_mod, mycn);
                    SqlDataReader resultado = consulta.ExecuteReader();
                    Item item;
                    while (resultado.Read())
                    {
                        item = new Item();
                        item.titulo = resultado.GetValue(1).ToString();
                        item.fecha_creacion = resultado.GetValue(2).ToString();
                        item.nivel = resultado.GetValue(3).ToString();
                        item.contenido = resultado.GetValue(4).ToString();
                        item.fecha_modificacion = resultado.GetValue(5).ToString();
                        lista.Add(item);
                    }
                }
                else
                {
                    SqlCommand consulta = new SqlCommand(Constantes.generar_tareas_mod, mycn);
                    SqlDataReader resultado = consulta.ExecuteReader();
                    Item item;
                    while (resultado.Read())
                    {
                        item = new Item();
                        item.titulo = resultado.GetValue(1).ToString();
                        item.fecha_creacion = resultado.GetValue(2).ToString();
                        item.nivel = resultado.GetValue(3).ToString();
                        item.estado = resultado.GetValue(4).ToString();
                        item.contenido = resultado.GetValue(5).ToString();
                        item.fecha_modificacion = resultado.GetValue(6).ToString();
                        item.fecha_entrega = resultado.GetValue(7).ToString();
                        lista.Add(item);

                    }
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Item> generarnivel(int tip)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                List<Item> lista = new List<Item>();
                if (tip == 1)
                {
                    SqlCommand consulta = null;
                    consulta = new SqlCommand(Constantes.generar_notas_niv, mycn);
                    SqlDataReader resultado = consulta.ExecuteReader();
                    Item item;
                    while (resultado.Read())
                    {
                        item = new Item();
                        item.titulo = resultado.GetValue(1).ToString();
                        item.fecha_creacion = resultado.GetValue(2).ToString();
                        item.nivel = resultado.GetValue(3).ToString();
                        item.contenido = resultado.GetValue(4).ToString();
                        item.fecha_modificacion = resultado.GetValue(5).ToString();
                        lista.Add(item);
                    }
                }
                else
                {
                    SqlCommand consulta = new SqlCommand(Constantes.generar_tareas_niv, mycn);
                    SqlDataReader resultado = consulta.ExecuteReader();
                    Item item;
                    while (resultado.Read())
                    {
                        item = new Item();
                        item.titulo = resultado.GetValue(1).ToString();
                        item.fecha_creacion = resultado.GetValue(2).ToString();
                        item.nivel = resultado.GetValue(3).ToString();
                        item.estado = resultado.GetValue(4).ToString();
                        item.contenido = resultado.GetValue(5).ToString();
                        item.fecha_modificacion = resultado.GetValue(6).ToString();
                        item.fecha_entrega = resultado.GetValue(7).ToString();
                        lista.Add(item);

                    }
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Item> generarallfecha()
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                List<Item> lista = new List<Item>();
                SqlCommand consulta = null;
                consulta = new SqlCommand(Constantes.generar_lista_fecha, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                Item item;
                while (resultado.Read())
                {
                    item = new Item();
                    item.tipo = resultado.GetValue(0).ToString();
                    item.titulo = resultado.GetValue(1).ToString();
                    item.fecha_creacion = resultado.GetValue(2).ToString();
                    item.nivel = resultado.GetValue(3).ToString();
                    item.estado = resultado.GetValue(4).ToString();
                    item.contenido = resultado.GetValue(5).ToString();
                    item.fecha_modificacion = resultado.GetValue(6).ToString();
                    item.fecha_entrega = resultado.GetValue(7).ToString();
                    lista.Add(item);
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Item> generarallfechamod()
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                List<Item> lista = new List<Item>();
                SqlCommand consulta = null;
                consulta = new SqlCommand(Constantes.generar_lista_mod, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                Item item;
                while (resultado.Read())
                {
                    item = new Item();
                    item.tipo = resultado.GetValue(0).ToString();
                    item.titulo = resultado.GetValue(1).ToString();
                    item.fecha_creacion = resultado.GetValue(2).ToString();
                    item.nivel = resultado.GetValue(3).ToString();
                    item.estado = resultado.GetValue(4).ToString();
                    item.contenido = resultado.GetValue(5).ToString();
                    item.fecha_modificacion = resultado.GetValue(6).ToString();
                    item.fecha_entrega = resultado.GetValue(7).ToString();
                    lista.Add(item);
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Item> generarallnivel()
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                List<Item> lista = new List<Item>();
                SqlCommand consulta = null;
                consulta = new SqlCommand(Constantes.generar_lista_nivel, mycn);
                SqlDataReader resultado = consulta.ExecuteReader();
                Item item;
                while (resultado.Read())
                {
                    item = new Item();
                    item.tipo = resultado.GetValue(0).ToString();
                    item.titulo = resultado.GetValue(1).ToString();
                    item.fecha_creacion = resultado.GetValue(2).ToString();
                    item.nivel = resultado.GetValue(3).ToString();
                    item.estado = resultado.GetValue(4).ToString();
                    item.contenido = resultado.GetValue(5).ToString();
                    item.fecha_modificacion = resultado.GetValue(6).ToString();
                    item.fecha_entrega = resultado.GetValue(7).ToString();
                    lista.Add(item);
                }
                mycn.Close();
                return lista;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void eliminar_nota(String id)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                String com = Constantes.eliminar_nota + id + "'";
                SqlCommand consulta = new SqlCommand(com, mycn);
                consulta.ExecuteReader();
                mycn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message);
            }
        }

        public static void eliminar_tarea(String id)
        {
            try
            {
                SqlConnection mycn = new SqlConnection(Constantes.conexion);
                mycn.Open();
                String com = Constantes.eliminar_tarea + id + "'";
                SqlCommand consulta = new SqlCommand(com, mycn);
                consulta.ExecuteReader();
                mycn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message);
            }
        }
    }
}
