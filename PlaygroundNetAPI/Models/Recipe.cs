namespace PlaygroundNetAPI.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string? GUID { get; set; }
        public string? Name { get; set; }
        public List<RawIngredient>? Ingredients { get; set; }
        public string? Description { get; set; }
        public DateTime Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
    }
}
