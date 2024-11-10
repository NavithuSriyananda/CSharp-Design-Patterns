namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. IComponent.
            // IComponent means the class that implements the IComponent Interface
            //Creating Leaf Objects or you can say child objects
            IComponent hardDisk = new LeafClass("Hard Disk", 2000);
            IComponent ram = new LeafClass("RAM", 3000);
            IComponent cpu = new LeafClass("CPU", 2000);
            IComponent mouse = new LeafClass("Mouse", 2000);
            IComponent keyboard = new LeafClass("Keyboard", 2000);
            //Creating Composite Objects
            CompositeClass motherBoard = new CompositeClass("MotherBoard");
            CompositeClass cabinet = new CompositeClass("Cabinet");
            CompositeClass peripherals = new CompositeClass("Peripherals");
            CompositeClass computer = new CompositeClass("Computer");
            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            //Adding Mother Board and Hard Disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            //Adding Mouse and Keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            //Adding Cabinet and Peripherals in Computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine("Price of Computer Composite Components");
            computer.DisplayPrice();
            //To display the Price of the Keyboard
            Console.WriteLine("\nPrice of Keyboard Child or Leaf Component:");
            keyboard.DisplayPrice();

            //To display the Price of the Cabinet
            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.DisplayPrice();
            Console.Read();
        }
    }
}
