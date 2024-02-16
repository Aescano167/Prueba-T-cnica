using System.Data.SqlClient;
using System;
using System.Data;
using System.Net.NetworkInformation;
using MySql.Data.MySqlClient;

namespace Prueba_Tecnica___Angel_Escaño
{
    public partial class frmMantenimientoUsuario : Form
    {
        public frmMantenimientoUsuario()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=pruebas; user=root; password=140926;");

        //EVENTOS DEL FORMULARIO ####################################################
        private void frmMantenimientoUsuario_Load(object sender, EventArgs e)
        {

            txtIdUsuario.Focus();

        }

        //OTROS EVENTOS #############################################################
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            bool GrabarProyecto = false;
            string consulta = "INSERT INTO Usuarios VALUES (@IdUsuario, @Nombre, @Apellido, @IdProyecto)";
            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
            {
                // Asigna valores a los parámetros
                cmd.Parameters.AddWithValue("@IdUsuario", int.Parse(txtIdUsuario.Text));
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);

                string txtIdProyectoValue = txtIdProyecto.Text;
                if (!string.IsNullOrEmpty(txtIdProyectoValue))
                {
                    // Intenta convertir la cadena a un valor numérico
                    if (int.TryParse(txtIdProyectoValue, out int idProyecto))
                    {
                        // Si la conversión es exitosa, asigna el valor al parámetro
                        cmd.Parameters.AddWithValue("@IdProyecto", idProyecto);
                        GrabarProyecto = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdProyecto", null);
                }

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    if (GrabarProyecto)
                    {
                        string insertarEnProyecto = "UPDATE Proyectos SET IdUsuario = @IdUsuario WHERE IdProyecto = @IdProyecto";
                        using (MySqlCommand cmdProyecto = new MySqlCommand(insertarEnProyecto, conexion))
                        {
                            // Asigna valores a los parámetros para la inserción en Usuarios
                            string txtIdProyectoAgregar = txtIdProyecto.Text;
                            int.TryParse(txtIdProyectoAgregar, out int IdProyecto);

                            cmdProyecto.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                            cmdProyecto.Parameters.AddWithValue("@IdUsuario", int.Parse(txtIdUsuario.Text));

                            // Asigna otros valores según la estructura de tu tabla Usuarios
                            cmdProyecto.ExecuteNonQuery();
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

            MessageBox.Show("Registro Agregado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            string consulta = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))

            {

                // Asigna valores a los parámetros
                cmd.Parameters.AddWithValue("@IdUsuario", int.Parse(txtIdUsuario.Text));

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"Se eliminó correctamente el usuario con IdUsuario {int.Parse(txtIdUsuario.Text)}");
                        txtIdUsuario.Text = "";
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtIdProyecto.Text = "";
                        txtIdUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró un usuario con IdUsuario {int.Parse(txtIdUsuario.Text)}");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = @IdUsuario";
            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))

            {
                // Asigna valor al parámetro
                cmd.Parameters.AddWithValue("@IdUsuario", int.Parse(txtIdUsuario.Text));

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
                            int idUsuarioEncontrado = reader.GetInt32("IdUsuario");
                            string nombre = reader.GetString("Nombre");
                            string apellido = reader.GetString("Apellido");

                            // Obtén el índice de la columna IdProyecto
                            int idProyectoIndex = reader.GetOrdinal("IdProyecto");

                            // Verifica si IdProyecto es NULL antes de intentar obtener su valor
                            int? idProyecto = reader.IsDBNull(idProyectoIndex) ? (int?)null : reader.GetInt32(idProyectoIndex);

                            txtNombre.Text = nombre;
                            txtApellido.Text = apellido;
                            txtIdProyecto.Text = idProyecto.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró un usuario con IdUsuario {int.Parse(txtIdUsuario.Text)}");
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

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            bool GrabarProyecto = false;
            string consulta = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, IdProyecto = @IdProyecto WHERE IdUsuario = @IdUsuario";

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
            {
                // Asigna valores a los parámetros
                cmd.Parameters.AddWithValue("@IdUsuario", int.Parse(txtIdUsuario.Text));
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text); 
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);

                string txtIdProyectoValue = txtIdProyecto.Text;
                if (!string.IsNullOrEmpty(txtIdProyectoValue))
                {
                    // Intenta convertir la cadena a un valor numérico
                    if (int.TryParse(txtIdProyectoValue, out int idProyecto))
                    {
                        // Si la conversión es exitosa, asigna el valor al parámetro
                        cmd.Parameters.AddWithValue("@IdProyecto", idProyecto);
                        GrabarProyecto = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdProyecto", null);
                }

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (GrabarProyecto)
                    {
                        string insertarEnProyecto = "UPDATE Proyectos SET IdUsuario = @IdUsuario WHERE IdProyecto = @IdProyecto";
                        using (MySqlCommand cmdProyecto = new MySqlCommand(insertarEnProyecto, conexion))
                        {
                            // Asigna valores a los parámetros para la inserción en Usuarios
                            string txtIdProyectoAgregar = txtIdProyecto.Text;
                            int.TryParse(txtIdProyectoAgregar, out int IdProyecto);

                            cmdProyecto.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                            cmdProyecto.Parameters.AddWithValue("@IdUsuario", int.Parse(txtIdUsuario.Text));

                            // Asigna otros valores según la estructura de tu tabla Usuarios
                            cmdProyecto.ExecuteNonQuery();
                        }
                    }

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"Se actualizó correctamente el usuario con IdUsuario {int.Parse(txtIdUsuario.Text)}");
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró un usuario con IdUsuario {int.Parse(txtIdUsuario.Text)}");
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

        //FUNCIONES Y RUTINAS ########################################################
    }
}
