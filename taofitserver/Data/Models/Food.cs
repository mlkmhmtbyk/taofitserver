namespace taofitserver.Data.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Amount { get; set; }
        public string Calory { get; set; }

        //Navigation Property
        public int? MealId { get; set; }
    }
}
