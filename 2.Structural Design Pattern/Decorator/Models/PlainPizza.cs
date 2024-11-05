namespace Decorator.Models
{
    // Concrete Components provide default implementations of the operations.
    public class PlainPizza : Pizza
    {
        //The following MakePizza method returns the default Pizza
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
