using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        Connect conn = new Connect();
        [HttpGet]
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            conn.Connection.Open();

            string sql = "SELECT * FROM books";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                var book = new Book()
                {
                    Id = dr.GetInt32(0),
                    Title = dr.GetString(1),
                    Author = dr.GetString(2),
                    ReleaseDate = dr.GetDateTime(3),
                };
                books.Add(book);
            }

            conn.Connection.Close();
            return new List<Book>();
        }
        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            return new Book();
        }
    }
}
