using taofitserver.Data;
using taofitserver.Data.Models;

namespace taofitserver.Services
{
    public class FoodsService
    {
        private readonly DataContext _context;

        public FoodsService(DataContext context)
        {
            _context = context;
        }
        public List<Food> GetAllFoods()
        {
            return _context.Foods.ToList();
        }

        public Food GetFoodById(int foodId)
        {
            return _context.Foods.Find(foodId);
        }

        public void AddFood(Food food)
        {
            var _food = new Food()
            {
                FoodName = food.FoodName,
                Amount = food.Amount,
                Calory = food.Calory
            };
            _context.Foods.Add(_food);
            _context.SaveChanges();
        }

        public Food UpdateFoodById(int foodId, Food food)
        {
            var _food = _context.Foods.FirstOrDefault(f => f.FoodId == foodId);
            if(_food != null)
            {
                _food.FoodName = food.FoodName;
                _food.Amount = food.Amount;
                _food.Calory = food.Calory;

                _context.SaveChanges();
            }

            return _food;
        }

        public void DeleteFoodById(int foodId)
        {
            var _food = _context.Foods.FirstOrDefault(f => f.FoodId == foodId);
            if(_food != null)
            {
                _context.Foods.Remove(_food);
                _context.SaveChanges();
            }
        }

        public void AddFoodToMealById(int mealId, Food food)
        {
            var _food = new Food()
            {
                FoodName = food.FoodName,
                Amount = food.Amount,
                Calory = food.Calory,
                MealId = mealId
            };
            _context.Foods.Add(_food);
            _context.SaveChanges();
        }
    }
}
