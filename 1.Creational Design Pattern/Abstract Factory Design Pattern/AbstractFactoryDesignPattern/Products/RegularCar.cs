﻿using AbstractFactoryDesignPattern.AbstractProducts;

namespace AbstractFactoryDesignPattern.Products
{
    // The ProductA2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following RegularCar Product Belongs to the Car product family
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}
