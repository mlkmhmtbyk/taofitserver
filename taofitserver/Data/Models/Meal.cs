namespace taofitserver.Data.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public List<Food>? Foods { get; set; }
    }
}
