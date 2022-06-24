using taofitserver.Data;
using taofitserver.Data.Models;

namespace taofitserver.Services
{
    public class MealsService
    {
        private readonly DataContext _context;

        public MealsService(DataContext context)
        {
            _context = context;
        }

        public List<Meal> GetAllMeals()
        {
            return _context.Meals.ToList();
        }

        public Meal GetMealById(int mealId)
        {
            return _context.Meals.Find(mealId);
        }

        public void AddMeal(Meal meal)
        {
            var _meal = new Meal()
            {
                MealName = meal.MealName,
                Date = meal.Date,
                Time = meal.Time
            };
            _context.Meals.Add(_meal);
            _context.SaveChanges();
        }

        public Meal UpdateMealById(int mealId, Meal meal)
        {
            var _meal = _context.Meals.FirstOrDefault(m => m.MealId == mealId);
            if (_meal != null)
            {
                _meal.MealName = meal.MealName;
                _meal.Date = meal.Date;
                _meal.Time = meal.Time;
                _meal.Foods = meal.Foods;

                _context.SaveChanges();
            }

            return _meal;
        }

        public void DeleteMealById(int mealId)
        {
            var _meal = _context.Meals.FirstOrDefault(m => m.MealId == mealId);
            if (_meal != null)
            {
                _context.Meals.Remove(_meal);
                _context.SaveChanges();
            }
        }

    }
}
