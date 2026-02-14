namespace DesignPatternChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Pagamentos ===\n");
        const decimal amount = 150.00m;
        const string cardNumber = "1234567890123456";

        // Problema: Cliente precisa saber qual gateway está usando
        // e o código de processamento está todo acoplado
        var pagSeguroService = new PaymentService(new PagSeguroFactory());
        pagSeguroService.ProcessPayment(amount, cardNumber);

        Console.WriteLine();

        var mercadoPagoService = new PaymentService(new MercadoPagoFactory());
        mercadoPagoService.ProcessPayment(amount, cardNumber);

        Console.WriteLine();

        var stripeService = new PaymentService(new StripeFactory());
        stripeService.ProcessPayment(amount, cardNumber);
    }
}