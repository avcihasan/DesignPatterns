namespace DesignPatterns.Composite.Composite
{
    public class BookComponent : IComponent
    {
        public BookComponent(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public int Count()
          => 1;

        public string Display()
            => $"<li class='list-group-item'>{Name}</li>";
    }
}
