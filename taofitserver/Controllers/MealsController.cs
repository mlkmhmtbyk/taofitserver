using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taofitserver.Data.Models;
using taofitserver.Services;

namespace taofitserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        public MealsService _mealsService;
        public MealsController(MealsService mealsService)
        {
            _mealsService = mealsService;
        }

        [HttpGet("GetAllMeals")]
        public IActionResult GetMeals()
        {
            var allMeals = _mealsService.GetAllMeals();
            return Ok(allMeals);
        }

        [HttpGet("GetAllMealsWithFoods")]
        public IActionResult GetMealsWithFoods()
        {
            var allMeals = _mealsService.GetAllMealsWithFoods();
            return Ok(allMeals);
        }

        [HttpGet("GetMealById{mealId}")]
        public IActionResult GetMealsById(int mealId)
        {
            var meal = _mealsService.GetMealById(mealId);
            return Ok(meal);
        }

        [HttpPost("AddMeal")]
        public IActionResult AddMeal([FromBody]Meal meal)
        {
            _mealsService.AddMeal(meal);
            return Ok();
        }

        [HttpPut("UpdateMealById{mealId}")]
        public IActionResult UpdateMealById(int mealId, [FromBody] Meal meal)
        {
            var updatedMeal = _mealsService.UpdateMealById(mealId, meal);
            return Ok(updatedMeal);
        }

        [HttpDelete("DeleteMealById{mealId}")]
        public IActionResult DeleteMeal(int mealId)
        {
            _mealsService.DeleteMealById(mealId);
            return Ok();
        }
    }
}
