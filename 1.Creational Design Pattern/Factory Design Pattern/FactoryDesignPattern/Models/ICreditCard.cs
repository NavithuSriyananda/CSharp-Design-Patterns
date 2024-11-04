namespace FactoryDesignPattern.Models
{
    // The CreditCard interface declares the operations that all 
    // concrete products must implement.
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
