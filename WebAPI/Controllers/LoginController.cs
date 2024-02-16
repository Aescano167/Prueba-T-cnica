using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using WebAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly string connectionString = "server=localhost; database=pruebas; user=root; password=140926;";

    [HttpPost]
    public ActionResult<string> VerificarLogin(Login login)
    {
        using MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        using MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Login WHERE Usuario = @Usuario AND Contraseña = @Contraseña", connection);
        cmd.Parameters.AddWithValue("@Usuario", login.Usuario);
        cmd.Parameters.AddWithValue("@Contraseña", login.Contraseña);

        int count = Convert.ToInt32(cmd.ExecuteScalar());

        if (count > 0)
        {
            return Ok("Usuario existe");
        }
        else
        {
            return NotFound("Usuario no encontrado");
        }
    }
}
