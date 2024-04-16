// Class that defines the attributes of a pizza according to the API. Reminds me of models in React.
namespace ContosoPizza.Models;

// Defining pizza class
public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }

    // This is an original attribute added by me
    public double Price {get; set;}
}
