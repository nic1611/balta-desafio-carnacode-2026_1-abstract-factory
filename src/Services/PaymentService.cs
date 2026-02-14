namespace DesignPatternChallenge;

public class PaymentService
{
    private readonly IPayment _payment;

    public PaymentService(IPayment payment)
    {
        _payment = payment;
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_payment.ValidateCard(cardNumber))
        {
            Console.WriteLine("Cartão inválido");
            return;
        }

        var result = _payment.ProcessTransaction(amount, cardNumber);
        _payment.Log($"Transação processada: {result}");
    }
}