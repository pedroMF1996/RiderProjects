namespace LambdaDelegatesLINQ009.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }

        public Category(int id, string name, int tier)
        {
            ID = id;
            Name = name;
            Tier = tier;
        }
    }
}