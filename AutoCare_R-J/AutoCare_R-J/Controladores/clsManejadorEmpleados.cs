using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorEmpleados
    {
        //Atributos
        private IList<clsEmpleado> lstEmpleados;
        private int intContadorEmpleados;


        //Recuperar lista de empleados
        public IList<clsEmpleado> ObtenerEmpleados()
        {
            lstEmpleados = TraerEmpleadosDB();
            return lstEmpleados;
        }

        public int TotalEmpleados
        {
            get { return intContadorEmpleados; }
            set { intContadorEmpleados = value; }
        }

        //Constructor
        public clsManejadorEmpleados()
        {
            lstEmpleados = new List<clsEmpleado>();
        }

        //Read
        #region Obtener Empleados DB

        //obtener todos los empleados de la base de datos
        private IList<clsEmpleado> TraerEmpleadosDB()
        {
            IList<clsEmpleado> empleadosEncontrados = new List<clsEmpleado>();

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                string sql = "SELECT * FROM empleados ORDER BY codigo";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            clsEmpleado empleadoTemporal = new clsEmpleado(
                                r.GetString(0), //codigo
                                r.GetString(1), //nombres
                                r.GetString(2), //apellidos
                                r.GetString(3), //dpi
                                r.GetString(4),//telefono
                                r.GetString(5),//correo
                                r.GetString(6),//direccion
                                r.GetString(7), //estado
                                r.GetString(8), //usuario
                                r.GetString(9), //contraseña
                                r.GetString(10), //rol
                                r.GetDecimal(11) //sueldo

                                );

                            empleadosEncontrados.Add(empleadoTemporal);

                        }
                    }
                }

                return empleadosEncontrados;
            }

        }



        #endregion

        #region Modificadores

        //Metodos Modificadores de datos en memoria
        public void AgregarEmpleado(clsEmpleado pEmpleado)
        {
            lstEmpleados.Add(pEmpleado);
        }

        //Delete
        #region Eliminar Empleado

        public bool EliminarEmpleado(string pCodigo)
        {

            string sql = "DELETE FROM empleados WHERE codigo = @codigo";

            using (var con = clsConexion.ObtenerConexion())
            {
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

        public void ModificarEmpleado(clsEmpleado pEmpleado)
        {
            clsEmpleado empleadoExistente = BuscarEmpleadoPorCodigo(pEmpleado.Codigo);
            if (empleadoExistente != null)
            {
                empleadoExistente.Nombre = pEmpleado.Nombre;
                empleadoExistente.Apellido = pEmpleado.Apellido;
                empleadoExistente.Correo = pEmpleado.Correo;
                empleadoExistente.Telefono = pEmpleado.Telefono;
                empleadoExistente.Direccion = pEmpleado.Direccion;
            }
        }

        #endregion


        #region Buscadores

        #region Busquedas por Valores Unicos

        public clsEmpleado BuscarEmpleadoPorCodigo(string pCodigoEmpleado)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Codigo.Equals(pCodigoEmpleado, StringComparison.OrdinalIgnoreCase));
        }


        public clsEmpleado BuscarEmpleadoPorDPI(string pDPIEmpleado)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.DPI.Equals(pDPIEmpleado, StringComparison.OrdinalIgnoreCase));
        }

        public clsEmpleado BuscarEmpleadoPorUsuario(string pUsuarioEmpleado)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Usuario.Equals(pUsuarioEmpleado, StringComparison.OrdinalIgnoreCase));
        }

        public clsEmpleado BuscarEmpleadoPorTelefono(string pTelefono)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Telefono.Equals(pTelefono, StringComparison.OrdinalIgnoreCase));
        }

        public clsEmpleado BuscarEmpleadoPorCorreo(string pCorreo)
        {
            return lstEmpleados.FirstOrDefault(cl => cl.Correo.Equals(pCorreo, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Busquedas por valores repetibles
        public IList<clsEmpleado> BuscarEmpleadosPorNombre(string pNombreEmpleado)
        {
            return lstEmpleados.Where(cl => cl.Nombre.Equals(pNombreEmpleado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorApellido(string pApellidoEmpleado)
        {
            return lstEmpleados.Where(cl => cl.Apellido.Equals(pApellidoEmpleado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorDireccion(string pDireccion)
        {
            return lstEmpleados.Where(cl => cl.Direccion.Equals(pDireccion, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorEstado(string pEstado)
        {
            return lstEmpleados.Where(cl => cl.Estado.Equals(pEstado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public IList<clsEmpleado> BuscarEmpleadosPorRol(string pRol)
        {
            return lstEmpleados.Where(cl => cl.Rol.Equals(pRol, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        #endregion

        //siguiente codigo  
        public string ObtenerSiguienteCodigo()
        {
            string sql = "SELECT MAX(codigo) FROM empleados";

            using (var con = clsConexion.ObtenerConexion())
            {

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                using (var cmd = new SqliteCommand(sql, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                        return "EM-001";

                    int numero = int.Parse(resultado.ToString().Substring(3)) + 1;
                    return $"EM-{numero:000}";
                }
            }
        }


        #endregion


    }
}
