using AutoCare_R_J.MetodosGlobales;
using AutoCare_R_J.Modelos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_R_J.Controladores
{
    internal class clsManejadorEmpleados
    {
        //Atributos
        private IList<clsEmpleado> lstEmpleados;

        //Recuperar lista de empleados
        public IList<clsEmpleado> ObtenerEmpleados()
        {
            lstEmpleados = TraerEmpleadosDB();
            return lstEmpleados;
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
        public bool AgregarEmpleado(clsEmpleado nuevoEmpleado)
        {

            if(!ValidarClienteExistente(nuevoEmpleado.Codigo, nuevoEmpleado.DPI, nuevoEmpleado.Usuario))
                return false;   

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                //sujeto a revision (codigo, nombres, apellidos, dpi, telefono, correo, direccion, estado, usuario, contraseña, rol, sueldo)
                string sql = @"INSERT INTO empleados
             (codigo, nombres, apellidos, dpi, telefono, correo, direccion, estado, usuario, contrasenia, rol, sueldo)
             VALUES (@codigo, @nombres, @apellidos, @dpi, @telefono, @correo, @direccion, @estado, @usuario, @contrasenia, @rol, @sueldo)";
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", nuevoEmpleado.Codigo);
                    cmd.Parameters.AddWithValue("@nombres", nuevoEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@apellidos", nuevoEmpleado.Apellido);
                    cmd.Parameters.AddWithValue("@dpi", nuevoEmpleado.DPI);
                    cmd.Parameters.AddWithValue("@telefono", nuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@correo", nuevoEmpleado.Correo);
                    cmd.Parameters.AddWithValue("@direccion", nuevoEmpleado.Direccion);
                    cmd.Parameters.AddWithValue("@estado", nuevoEmpleado.Estado);
                    cmd.Parameters.AddWithValue("@usuario", nuevoEmpleado.Usuario);
                    cmd.Parameters.AddWithValue("@contrasenia", nuevoEmpleado.Contrasenia);
                    cmd.Parameters.AddWithValue("@rol", nuevoEmpleado.Rol);
                    cmd.Parameters.AddWithValue("@sueldo", nuevoEmpleado.Sueldo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        
        //validar si el cliente existe
        private bool ValidarClienteExistente(string pCodigo, string pDPI, string pUsuario)
        {
            string[] parametrosDeBusqueda = new string[] { pCodigo, pDPI, pUsuario };
            IList<clsEmpleado> listaClientesTemporal = BuscarEmpleadoParaValidaciones(parametrosDeBusqueda);

            foreach (clsEmpleado empleado in listaClientesTemporal)
            {
                if (empleado.Codigo == pCodigo)
                {
                    MessageBox.Show("Ya existe un empleado con el mismo código");
                    return false;
                }
                if (empleado.DPI == pDPI)
                {
                    MessageBox.Show("Ya existe un empleado con el mismo DPI");
                    return false;
                }
                if (empleado.Usuario == pUsuario)
                {
                    MessageBox.Show("Ya existe un empleado con el mismo usuario");
                    return false;
                }

            }

            return true; // No hay empleados existentes con los mismos datos
        }

        private IList<clsEmpleado> BuscarEmpleadoParaValidaciones(string[] parametrosDeBusqueda)
        {
            IList<clsEmpleado> empleadosEncontrados = new List<clsEmpleado>();
            clsEmpleado empleadoTemporal;
            try
            {
                // Codigo, DPI,  Nit,  Correo, Telefono
                string sql = @"SELECT * FROM empleados WHERE 
codigo = @pCodigo OR
dpi = @pDPI OR
usuario = @pUsuario";

                //hacer la conexion
                using (var con = clsConexion.ObtenerConexion())
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();

                    using (var cmd = new SqliteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@pCodigo", parametrosDeBusqueda[0]);
                        cmd.Parameters.AddWithValue("@pDPI", parametrosDeBusqueda[1]);
                        cmd.Parameters.AddWithValue("@pUsuario", parametrosDeBusqueda[2]);

                        using (var r = cmd.ExecuteReader())
                        {

                            while (r.Read())
                            {
                                empleadoTemporal = new clsEmpleado(
                                    r.GetString(0),
                                    r.GetString(1),
                                    r.GetString(2),
                                    r.GetString(3),
                                    r.GetString(4),
                                    r.GetString(5),
                                    r.GetString(6),
                                    r.GetString(7),
                                    r.GetString(8),
                                    r.GetString(9),
                                    r.GetString(10),
                                    r.GetDecimal(11)
                                    );

                                empleadosEncontrados.Add(empleadoTemporal);
                            }


                        }
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show($"Error encontrado:\n{e}");

            }


            return empleadosEncontrados;
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

        //Update
        #region Actualizar Cliente
        public bool ModificarEmpleado(clsEmpleado empleadoModificado)
        {

            using (var con = clsConexion.ObtenerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                //Crear sentencia sql para actualizar registro
                string sql = @"UPDATE empleados 
SET nombres = @Nombres, apellidos = @Apellidos, telefono = @Telefono, correo = @Correo, direccion = @Direccion, 
estado = @Estado,contrasenia = @Contrasenia, rol = @Rol, sueldo = @Sueldo WHERE codigo = @Codigo";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", empleadoModificado.Codigo);
                    cmd.Parameters.AddWithValue("@Nombres", empleadoModificado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", empleadoModificado.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", empleadoModificado.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", empleadoModificado.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", empleadoModificado.Direccion);
                    cmd.Parameters.AddWithValue("@Estado", empleadoModificado.Estado);
                    cmd.Parameters.AddWithValue("@Contrasenia", empleadoModificado.Contrasenia);
                    cmd.Parameters.AddWithValue("@Rol", empleadoModificado.Rol);
                    cmd.Parameters.AddWithValue("@Sueldo", empleadoModificado.Sueldo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        #endregion


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
