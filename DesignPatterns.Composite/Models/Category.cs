namespace DesignPatterns.Composite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int ReferenceId { get; set; }
        public List<Product> Products { get; set; }
    }
}
