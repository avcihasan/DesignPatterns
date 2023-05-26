namespace AbstractFactoryPattern.Cache
{
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine($"{nameof(RedisCache)} - {data}");
        }
    }
}
