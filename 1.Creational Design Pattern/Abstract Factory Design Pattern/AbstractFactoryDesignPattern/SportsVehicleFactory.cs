﻿using AbstractFactoryDesignPattern.AbstractProducts;
using AbstractFactoryDesignPattern.Products;

namespace AbstractFactoryDesignPattern
{
    // The ConcreteFactory2 class
    // Concrete Factories produce a family of products that belong to a single variant. 
    // The following Concrete Factory Produces Sports Bike and Sports Car which are compatible
    // The signatures of the Concrete Factory's methods return an abstract product (IBike) and (ICar) 
    // while inside the method a concrete product (new SportsBike and new SportsCar) is instantiated.
    internal class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
