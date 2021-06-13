using Microsoft.AspNetCore.Mvc;

namespace ReactDemo.Controllers
{
    public class TicTacController : Controller
    {
        public IActionResult TicTacToe()
        {
            return View();
        }
    }
}
