namespace SingletonPattern.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        static Product _instance;
        private Product(){}
        static Product()
        {
            _instance=new Product() { Name="Kalem",Price=20};
        }
        static public Product GetInstance()
            => _instance;

        //public static Product GetInstance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new Product();
        //        return _instance;
        //    }
        //}

    }
}
