namespace DesignPatternChallenge;

public interface IPayment
{
    string ProcessTransaction(decimal amount, string cardNumber);
    bool ValidateCard(string cardNumber);
    void Log(string message);
}