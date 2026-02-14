namespace DesignPatternChallenge;

public class StripeFactory : IPayment
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando R$ {amount}...");
        return $"Stripe-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }

    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("4");
    }

    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}