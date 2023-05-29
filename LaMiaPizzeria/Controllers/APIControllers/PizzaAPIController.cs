using LaMiaPizzeria.Database;
using LaMiaPizzeria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers.APIControllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PizzaAPIController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetPizza()
		{
			using (PizzaContext db = new PizzaContext())
			{
				List<Pizza> pizzas = db.Pizzas.ToList();
				return Ok(pizzas);
			}
		}

		[HttpGet]
		public IActionResult SearchByName(string name)
		{
			using (PizzaContext db = new PizzaContext())
			{
				Pizza? pizzaToSearch = db.Pizzas.Where(pizza => pizza.Name.Contains(name)).FirstOrDefault();

				if (pizzaToSearch != null)
				{
					return Ok(pizzaToSearch);
				}
				else
				{
					return NotFound();
				}
			}
		}

		[HttpGet("{id}")]
		public IActionResult SearchById(int id)
		{
			using (PizzaContext db = new PizzaContext())
			{
				Pizza? pizzaToSearch = db.Pizzas.Where(pizza => pizza.Id == id).FirstOrDefault();

				if (pizzaToSearch != null)
				{
					return Ok(pizzaToSearch);
				}
				else
				{
					return NotFound();
				}
			}
		}


	}
}
