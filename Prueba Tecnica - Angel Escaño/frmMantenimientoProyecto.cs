using System.Data.SqlClient;
using System;
using System.Data;
using System.Net.NetworkInformation;
using MySql.Data.MySqlClient;

namespace Prueba_Tecnica___Angel_Escaño
{
    public partial class frmMantenimientoProyecto : Form
    {
        public frmMantenimientoProyecto()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=pruebas; user=root; password=140926;");

        //EVENTOS DEL FORMULARIO ####################################################
        private void frmMantenimientoProyecto_Load(object sender, EventArgs e)
        {

        }

        //OTROS EVENTOS #############################################################
        private void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            bool GrabarUsuario = false;
            string consulta = "INSERT INTO Proyectos VALUES (@IdProyecto, @NombreProyecto, @Descripcion, @IdUsuario)";

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
            {
                // Asigna valores a los parámetros
                cmd.Parameters.AddWithValue("@IdProyecto", int.Parse(txtIdProyecto.Text));
                cmd.Parameters.AddWithValue("@NombreProyecto", txtNombreProyecto.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                string txtIdUsuarioValue = txtIdUsuario.Text;
                if (!string.IsNullOrEmpty(txtIdUsuarioValue))
                {
                    // Intenta convertir la cadena a un valor numérico
                    if (int.TryParse(txtIdUsuarioValue, out int idProyecto))
                    {
                        // Si la conversión es exitosa, asigna el valor al parámetro
                        cmd.Parameters.AddWithValue("@IdUsuario", idProyecto);
                        GrabarUsuario = true;

                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", null);
                }

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    if (GrabarUsuario)
                    {
                        string insertarEnUsuarios = "UPDATE Usuarios SET IdProyecto = @IdProyecto WHERE IdUsuario = @IdUsuario";
                        using (MySqlCommand cmdUsuarios = new MySqlCommand(insertarEnUsuarios, conexion))
                        {
                            // Asigna valores a los parámetros para la inserción en Usuarios
                            string txtIdUsuarioAgregar = txtIdUsuario.Text;
                            int.TryParse(txtIdUsuarioAgregar, out int idUsuario);

                            cmdUsuarios.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdUsuarios.Parameters.AddWithValue("@IdProyecto", int.Parse(txtIdProyecto.Text));

                            // Asigna otros valores según la estructura de tu tabla Usuarios
                            cmdUsuarios.ExecuteNonQuery();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }

            MessageBox.Show("Proyecto Agregado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {

            string consulta = "DELETE FROM Proyectos WHERE IdProyecto = @IdProyecto";
            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))

            {

                // Asigna valores a los parámetros
                cmd.Parameters.AddWithValue("@IdProyecto", int.Parse(txtIdProyecto.Text));

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"Se eliminó correctamente el proyecto con Id {int.Parse(txtIdProyecto.Text)}");
                        txtIdProyecto.Text = "";
                        txtNombreProyecto.Text = "";
                        txtDescripcion.Text = "";
                        txtIdUsuario.Text = "";
                        txtIdProyecto.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró un usuario con Id {int.Parse(txtIdProyecto.Text)}");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al ejecutar la consulta de eliminación: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        private void btnModificarProyecto_Click(object sender, EventArgs e)
        {
            bool GrabarUsuario = false;
            string consulta = "UPDATE Proyectos SET IdUsuario = @IdUsuario, NombreProyecto = @NombreProyecto, Descripcion = @Descripcion WHERE IdProyecto = @IdProyecto";

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
            {
                // Asigna valores a los parámetros
                cmd.Parameters.AddWithValue("@IdProyecto", int.Parse(txtIdProyecto.Text));
                cmd.Parameters.AddWithValue("@NombreProyecto", txtNombreProyecto.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                string txtIdUsuarioValue = txtIdUsuario.Text;
                if (!string.IsNullOrEmpty(txtIdUsuarioValue))
                {
                    // Intenta convertir la cadena a un valor numérico
                    if (int.TryParse(txtIdUsuarioValue, out int idProyecto))
                    {
                        // Si la conversión es exitosa, asigna el valor al parámetro
                        cmd.Parameters.AddWithValue("@IdUsuario", idProyecto);
                        GrabarUsuario = true;

                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", null);
                }

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (GrabarUsuario)
                    {
                        string insertarEnUsuarios = "UPDATE Usuarios SET IdProyecto = @IdProyecto WHERE IdUsuario = @IdUsuario";
                        using (MySqlCommand cmdUsuarios = new MySqlCommand(insertarEnUsuarios, conexion))
                        {
                            // Asigna valores a los parámetros para la inserción en Usuarios
                            string txtIdUsuarioAgregar = txtIdUsuario.Text;
                            int.TryParse(txtIdUsuarioAgregar, out int idUsuario);

                            cmdUsuarios.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdUsuarios.Parameters.AddWithValue("@IdProyecto", int.Parse(txtIdProyecto.Text));

                            // Asigna otros valores según la estructura de tu tabla Usuarios
                            cmdUsuarios.ExecuteNonQuery();
                        }
                    }

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"Se actualizó correctamente el proyecto con Id {int.Parse(txtIdProyecto.Text)}");
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró un proyecto con Id {int.Parse(txtIdProyecto.Text)}");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al ejecutar la consulta de actualización: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string consulta = "SELECT * FROM Proyectos WHERE IdProyecto = @IdProyecto";
            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))

            {
                // Asigna valor al parámetro
                cmd.Parameters.AddWithValue("@IdProyecto", int.Parse(txtIdProyecto.Text));

                try
                {
                    conexion.Open();

                    // Utiliza un MySqlDataReader para leer los resultados
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Verifica si hay filas
                        if (reader.Read())
                        {
                            // Accede a los valores de las columnas según sea necesario
                            int IdProyectoEncontrado = reader.GetInt32("IdProyecto");
                            string NombreProyecto = reader.GetString("NombreProyecto");
                            string Descripcion = reader.GetString("Descripcion");

                            // Obtén el índice de la columna IdProyecto
                            int IdUsuarioIndex = reader.GetOrdinal("IdUsuario");

                            // Verifica si IdProyecto es NULL antes de intentar obtener su valor
                            int? idUsuario = reader.IsDBNull(IdUsuarioIndex) ? (int?)null : reader.GetInt32(IdUsuarioIndex);

                            txtNombreProyecto.Text = NombreProyecto;
                            txtDescripcion.Text = Descripcion;
                            txtIdUsuario.Text = idUsuario.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró un proyecto con Id {int.Parse(txtIdProyecto.Text)}");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        //FUNCIONES Y RUTINAS ########################################################

    }
}
