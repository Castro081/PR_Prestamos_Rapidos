using DocumentFormat.OpenXml.Wordprocessing;
using ProyectoPrestamo.Modales;
using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace ProyectoPrestamo.Logica
{
    internal class AhorroLogica
    {
        private static AhorroLogica _instancia = null;

        public AhorroLogica()
        {
        }

        public static AhorroLogica Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new AhorroLogica();
                return _instancia;
            }
        }

        public int RegistrarAhorro(Ahorro oAhorro, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO Ahorro (idCliente, Monto, fecha, totalahorrado, firma, multa, IdTipoMoneda)");
                    query.AppendLine("VALUES (@idCliente, @Monto, @fecha, @totalahorrado, @firma, @multa, @IdTipoMoneda);");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idCliente", oAhorro.IdCliente);
                    cmd.Parameters.AddWithValue("@Monto", oAhorro.Monto);
                    cmd.Parameters.AddWithValue("@fecha", oAhorro.Fecha);
                    cmd.Parameters.AddWithValue("@totalahorrado", oAhorro.TotalAhorrado);
                    cmd.Parameters.AddWithValue("@firma", oAhorro.Firma);
                    cmd.Parameters.AddWithValue("@multa", oAhorro.Multa);
                    cmd.Parameters.AddWithValue("@IdTipoMoneda", oAhorro.IdTipoMoneda);
                    cmd.Transaction = objTransaccion;

                    respuesta = cmd.ExecuteNonQuery();

                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar el ahorro";
                    }
                    else
                    {
                        objTransaccion.Commit();
                    }
                }
                catch (Exception ex)
                {
                    objTransaccion?.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        public List<Ahorro> ObtenerAhorrosPorCliente(int idCliente)
        {
            List<Ahorro> listaAhorros = new List<Ahorro>();
            string mensaje = string.Empty;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT Monto, fecha, totalahorrado");
                    query.AppendLine("FROM Ahorro");
                    query.AppendLine("WHERE IdCliente = @idCliente;");

                    using (SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ahorro ahorro = new Ahorro
                                {
                                    Monto = reader.GetDecimal(reader.GetOrdinal("Monto")),
                                    Fecha = reader.GetString(reader.GetOrdinal("fecha")),
                                    TotalAhorrado = reader.GetInt32(reader.GetOrdinal("totalahorrado")),
                                    IdTipoMoneda = 0
                                };

                                listaAhorros.Add(ahorro);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
            }

            return listaAhorros;
        }

        public int ObtenerUltimoAhorroPorCliente(int idCliente)
        {
            int totalAhorrado = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT totalahorrado"); 
                    query.AppendLine("FROM Ahorro ");
                    query.AppendLine("WHERE idCliente = @idCliente ");
                    query.AppendLine("ORDER BY IdAhorro DESC LIMIT 1;");

                    using (SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalAhorrado = reader.GetInt32(reader.GetOrdinal("totalahorrado"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return totalAhorrado;
        }

        // Método para buscar clientes por número de documento (sin cambios necesarios aquí)
        public Clientes BuscarClientePorNumeroDocumento(string numeroDocumento)
        {
            String mensaje = string.Empty;
            Clientes cliente = null;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT * FROM CLIENTES WHERE NumeroDocumento = @numeroDocumento;");

                    using (SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion))
                    {
                        cmd.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = new Clientes
                                {
                                    IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente")),
                                    NombreCompleto = reader.GetString(reader.GetOrdinal("NombreCompleto")),
                                    TipoDocumento = reader.GetString(reader.GetOrdinal("TipoDocumento")),
                                    NumeroDocumento = reader.GetString(reader.GetOrdinal("NumeroDocumento")),
                                    Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
                                    Ciudad = reader.GetString(reader.GetOrdinal("Ciudad")),
                                    Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                    NumeroTelefono = reader.GetString(reader.GetOrdinal("NumeroTelefono"))
                                };
                            }
                            else
                            {
                                mensaje = "No se encontró ningún cliente con el número de documento proporcionado.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
            }

            return cliente;
        }
    }
}
