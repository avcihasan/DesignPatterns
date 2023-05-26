namespace AbstractFactoryPattern.Cache
{
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine($"{nameof(MemCache)} - {data}");
        }
    }
}
