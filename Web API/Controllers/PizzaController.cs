// Actions that double as HTTP endpoints inside the web API controller. Due to naming conventions, this file handles requests to
// https://localhost:{PORT}/pizza
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

// This attribute implies that the Pizza parameter will be found in the request body
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

    // POST action, inserts the request body's Pizza object into the in-memory cache
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {            
    PizzaService.Add(pizza);
    return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    // PUT action, handles updating any information on the requested pizza, the id attribute will be included in the URL segment after "pizza/"
    [HttpPut("{id}")]
    
    // Returns IActionResult, because the ActionResult return type isn't known until runtime
    public IActionResult Update(int id, Pizza pizza)
    {
    if (id != pizza.Id)
        return BadRequest();
           
    var existingPizza = PizzaService.Get(id);
    if(existingPizza is null)
        return NotFound();
   
    PizzaService.Update(pizza);           
   
    return NoContent();
    }

    // DELETE action, works by quering the in-memory cache for a pizza that matches the provided id parameter
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
    var pizza = PizzaService.Get(id);
   
    if (pizza is null)
        return NotFound();
       
    PizzaService.Delete(id);
   
    return NoContent();
    }
}