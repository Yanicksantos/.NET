namespace Servicos
{
    class PaypalService : IPagamentoOnline
{

    private const double FeePercentage = 0.02;
    private const double MonthlyInterest = 0.01;

    public double Interesse(double montante, int mes)
    {
        return montante * MonthlyInterest * mes;
    }

    public double TaxaDePagamento(double montante)
    {
        return montante * FeePercentage;
    }
}
}