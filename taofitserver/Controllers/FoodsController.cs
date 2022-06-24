using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taofitserver.Data.Models;
using taofitserver.Services;

namespace taofitserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        public FoodsService _foodsService;
        public FoodsController(FoodsService foodsService)
        {
            _foodsService = foodsService;
        }


        [HttpGet("GetAllFoods")]
        public IActionResult GetFoods()
        {
            var allFoods = _foodsService.GetAllFoods();
            return Ok(allFoods);
        }

        [HttpGet("GetFoodById{foodId}")]
        public IActionResult GetFoodsById(int foodId)
        {
            var food = _foodsService.GetFoodById(foodId);
            return Ok(food);
        }

        [HttpPost("AddFood")]
        public IActionResult AddFood([FromBody]Food food)
        {
            _foodsService.AddFood(food);
            return Ok();
        }

        [HttpPut("UpdateFoodById{foodId}")]
        public IActionResult UpdateFoodById(int foodId, [FromBody] Food food)
        {
            var updatedFood = _foodsService.UpdateFoodById(foodId, food);   
            return Ok(updatedFood);
        }

        [HttpDelete("DeleteFoodById{foodId}")]
        public IActionResult DeleteFood(int foodId)
        {
            _foodsService.DeleteFoodById(foodId);
            return Ok();
        }

    }
}
