using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using AutoCare_R_J.Modelos;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorCitas
    {
        //Atributos
        private IList<clsCita> lstCitas;

        private clsManejadorClientes listaClientes;
        private clsManejadorVehiculos listaVehiculos;
        private clsManejadorEmpleados listaEmpleados;

        //constructor de la clase clsManejadorCitas
        public clsManejadorCitas()
        {
            lstCitas = new List<clsCita>();
            listaClientes = new clsManejadorClientes();
            listaVehiculos = new clsManejadorVehiculos();
            listaEmpleados = new clsManejadorEmpleados();

            listaVehiculos.ListarVehiculos();
            listaClientes.ObtenerClientes();
            listaEmpleados.ObtenerEmpleados();
        }

        //Recuperar lista de citas
        public IList<clsCita> ObtenerCitas()
        {

            lstCitas = TraerListaCitas();
            return lstCitas;
        }

        #region CRUD
        //create

        //read
        #region Traer la Lista de Citas
        private IList<clsCita> TraerListaCitas()
        {
            IList<clsCita> listaCitasTemporal = new List<clsCita>();

            using (var con = clsConexion.ObtenerConexion())
            {
                string sql = "SELECT * FROM cita";
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                using (var cmd = new SqliteCommand(sql, con))
                {
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string nombreCliente = listaClientes.BuscarClientePorParametroUnico("codigo", r.GetString(1)).Nombre + " " + listaClientes.BuscarClientePorParametroUnico("codigo", r.GetString(1)).Apellido;
                            string vehiculo = listaVehiculos.BuscarVehiculo(r.GetString(2)).Marca + " " + listaVehiculos.BuscarVehiculo(r.GetString(2)).Modelo + " - " + listaVehiculos.BuscarVehiculo(r.GetString(2)).Placa;
                            string tecnico = listaEmpleados.BuscarEmpleadoPorCodigo(r.GetString(3)).Nombre + " " + listaEmpleados.BuscarEmpleadoPorCodigo(r.GetString(3)).Apellido;
                            clsCita cita = new clsCita
                            (
                                r.GetString(0),
                                nombreCliente,
                                vehiculo,
                                tecnico,
                                r.GetDateTime(4),
                                r.GetString(5),
                                r.GetString(6)
                            );

                            listaCitasTemporal.Add(cita);
                        }

                    }
                }
            }

            return listaCitasTemporal;
        }

        #endregion
        //delete



        #region Modificadores
        //Metodos Modificadores de datos en memoria 

        //Agregar nueva cita a la lista de citas
        public bool AgregarCita(clsCita pCita)
        {
            if (pCita == null)
                return false;

            if (BuscarCitaPorCodigo(pCita.CodigoCita) != null)
                return false;
            using (var con = clsConexion.ObtenerConexion())
            {
                string sql = "INSERT INTO cita (codigo_cita, codigo_cliente, codigo_vehiculo, codigo_tecnico, fecha_hora, estado, observaciones) VALUES (@codigo, @codigo_cliente, @codigo_vehiculo, @codigo_tecnico, @fecha_hora, @estado, @observaciones)";
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                using (var cmd = new SqliteCommand(sql, con))
                {

                    cmd.Parameters.AddWithValue("@codigo", pCita.CodigoCita);
                    cmd.Parameters.AddWithValue("@codigo_cliente", pCita.CodigoCliente);
                    cmd.Parameters.AddWithValue("@codigo_vehiculo", pCita.CodigoVehiculo);
                    cmd.Parameters.AddWithValue("@codigo_tecnico", pCita.CodigoTecnico);
                    cmd.Parameters.AddWithValue("@fecha_hora", pCita.FechaHoraCita);
                    cmd.Parameters.AddWithValue("@estado", pCita.EstadoCita);
                    cmd.Parameters.AddWithValue("@observaciones", pCita.Observaciones);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public void EliminarCita(clsCita pCita)
        {
            lstCitas.Remove(pCita);
        }

        public bool ModificarCita(clsCita pCita)
        {
            if (BuscarCitaPorCodigo(pCita.CodigoCita) == null)
                return false;
            using (var con = clsConexion.ObtenerConexion())
            {
                string sql = "UPDATE cita SET codigo_cliente=@codigo_cliente, codigo_vehiculo=@codigo_vehiculo, codigo_tecnico=@codigo_tecnico, fecha_hora=@fecha_hora, estado=@estado, observaciones=@observaciones WHERE codigo_cita=@codigo";
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", pCita.CodigoCita);
                    cmd.Parameters.AddWithValue("@codigo_cliente", pCita.CodigoCliente);
                    cmd.Parameters.AddWithValue("@codigo_vehiculo", pCita.CodigoVehiculo);
                    cmd.Parameters.AddWithValue("@codigo_tecnico", pCita.CodigoTecnico);
                    cmd.Parameters.AddWithValue("@fecha_hora", pCita.FechaHoraCita);
                    cmd.Parameters.AddWithValue("@estado", pCita.EstadoCita);
                    cmd.Parameters.AddWithValue("@observaciones", pCita.Observaciones);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool eliminarCita(string pCodigo)
        {

            if (BuscarCitaPorCodigo(pCodigo) == null)
                return false;

            using (var con = clsConexion.ObtenerConexion())
            {
                string sql = "DELETE FROM cita WHERE codigo_cita=@codigo";
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", pCodigo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        #endregion
        #region Buscador
        //Buscador de cita por codgio
        public clsCita BuscarCitaPorCodigo(string pCodigo)
        {
            return lstCitas.FirstOrDefault(c => c.CodigoCita == pCodigo);
        }
        #endregion
        //siguiente codigo  
        public string ObtenerSiguienteCodigo()
        {
            string sql = "SELECT MAX(codigo_cita) FROM cita";

            using (var con = clsConexion.ObtenerConexion())
            {

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                        return "CIT-001";

                    int numero = int.Parse(resultado.ToString().Substring(5)) + 1;
                    return $"CIT-{numero:000}";
                }
            }
        }

        internal IList<clsCita> BuscarCitas(string campo, string text)
        {
            if (campo == "Codigo")
            {
                return lstCitas.Where(c => c.CodigoCita.Contains(text)).ToList();
            }
            else if (campo == "Cliente")
            {
                return lstCitas.Where(c => c.CodigoCliente.Contains(text)).ToList();
            }
            else if (campo == "Vehiculo")
            {
                return lstCitas.Where(c => c.CodigoVehiculo.Contains(text)).ToList();
            }
            else if (campo == "Tecnico")
            {
                return lstCitas.Where(c => c.CodigoTecnico.Contains(text)).ToList();
            }
            return new List<clsCita>();
        }


    }
}

    #endregion