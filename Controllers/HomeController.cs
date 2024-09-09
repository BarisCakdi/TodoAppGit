using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoAppGit.Models;
using Dapper;


namespace TodoAppGit.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = "Server=104.247.162.242\\MSSQLSERVER2019;Initial Catalog=bariscak_git;User Id=bariscak_gitDbUser;Password=dw7rR80#8; TrustServerCertificate=True";

        public IActionResult Index()
        {
            return View();
        }
    }
}
