﻿namespace Composite
{
    // The Composite class represents the complex components that have children. 
    // The Composite objects delegate the actual work to their children and then combine the result.
    public class CompositeClass : IComponent
    {
        public string Name { get; set; }
        //The Object is used to hold all the child components of a composite components
        List<IComponent> components = new List<IComponent>();
        //The Constructor takes the Composite name as the input parameter
        public CompositeClass(string name)
        {
            Name = name;
        }
        //The following Method is used to add Child Components inside the Composite Component
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        //Display the Price of Composite Components
        public void DisplayPrice()
        {
            foreach (var item in components)
            {
                //Delegates the work to the actual leaf object or child components
                item.DisplayPrice();
            }
        }
    }
}
