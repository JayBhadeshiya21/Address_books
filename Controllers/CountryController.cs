using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace Address_books.Controllers
{
    public class CountryController : Controller
    {
        private IConfiguration configuration;

        public CountryController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IActionResult From_Country()
        {
            return View();
        }

        public IActionResult List_Country()
        {
            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PR_Country_GETALL";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        }
    }
}
