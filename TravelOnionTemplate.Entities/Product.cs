namespace TravelOnionTemplate.Entities
{
    public class Product
    {
        public Product( string name )
        {
            this.Id = Guid.NewGuid().ToString();    
            this.Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}
