using Microsoft.AspNetCore.Mvc;
using PersonService.WebApp.Repository;

namespace PersonService.WebApp.Controllers;

public class PersonController : Controller
{
    private readonly PersonRepository _personRepository;

    public PersonController()
    {
        _personRepository = new PersonRepository();
    }

    
    public IActionResult GetAll()
    {
        var persons = _personRepository
            //.GetAll();
            .GetAllByPersonOfAgeRange(20,25);
        return View(persons);
    }

    public IActionResult GetById(int id)
    {
        var person = _personRepository.GetById(id);
        return View(person);

    }

    public IActionResult Hakkimizda() {
    
    return View();
    }


}
