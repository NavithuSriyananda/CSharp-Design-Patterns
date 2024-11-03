namespace AbstractFactoryDesignPattern.AbstractProducts
{
    // The 'AbstractProductB' interface
    // Each distinct product of the Car product family should have a base interface.
    // All variants of the Car products must implement this ICar interface.
    internal interface ICar
    {
        void GetDetails();
    }
}
