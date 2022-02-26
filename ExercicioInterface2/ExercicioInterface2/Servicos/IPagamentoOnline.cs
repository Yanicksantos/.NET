namespace Servicos
{
    interface IPagamentoOnline
    {

        double TaxaDePagamento(double montante);
        double Interesse(double montante, int meses);
    }
}