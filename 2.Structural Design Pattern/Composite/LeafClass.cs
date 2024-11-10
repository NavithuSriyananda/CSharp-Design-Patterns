namespace Composite
{
    // The Leaf class represents the end objects. 
    // A leaf can't have any children.
    // The Leaf object is the Object which does the actual work
    public class LeafClass : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public LeafClass(string name, int price)
        {
            Price = price;
            Name = name;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"\tComponent Name: {Name} and Price: {Price}");
        }
    }
}
