// Actions that double as HTTP endpoints inside the web API controller. Due to naming conventions, this file handles requests to
// https://localhost:{PORT}/pizza
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GETS all the pizzas from the API. The attribute below denotes it only responds to HTTP GET verb
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
    // Calls the GetAll() function in the Pizza Service file
    PizzaService.GetAll();

    // GET an individual pizza by Id, also a GET request but because parameters are different exists as a seperate route
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
    var pizza = PizzaService.Get(id);

    if(pizza == null)
        return NotFound();

    return pizza;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {            
    PizzaService.Add(pizza);
    return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    // PUT action

    // DELETE action
}