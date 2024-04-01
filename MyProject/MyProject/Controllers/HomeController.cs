using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var objects = new List<MyObject>
        {
            new MyObject { ID = 1, Name = "Object 1", Price = 10 },
            new MyObject { ID = 2, Name = "Object 2", Price = 20 },
            new MyObject { ID = 3, Name = "Object 3", Price = 30 }
        };

        return View(objects);
    }
}
