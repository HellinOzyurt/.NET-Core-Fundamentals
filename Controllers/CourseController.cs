using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{

    public IActionResult Details(int? id)
    {

        if (id == null)
        {
            return RedirectToAction("List", "Course");
        }
        var kurs = Reporsitory.GetById(id);
        return View(kurs);
    }
    public IActionResult List()
    {
        return View("CourseList", Reporsitory.Courses);
    }


}