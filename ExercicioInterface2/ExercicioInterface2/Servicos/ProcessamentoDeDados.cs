using System;
using Entities;

namespace Servicos
{
    class ContractService
    {

        private IPagamentoOnline PagamentoOnline;

        public ContractService(IPagamentoOnline pagamentoOnline)
        {
            PagamentoOnline = pagamentoOnline;
        }

        public void ProcessarContrato(Contract contract, int months)
        {
            double CotaBasica = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime data = contract.Date.AddMonths(2);
                double CotaAtualizada = CotaBasica + PagamentoOnline.Interesse(CotaBasica, i);
                double CotaCompleta = CotaAtualizada + PagamentoOnline.TaxaDePagamento(CotaAtualizada);
                contract.AddParcela(new Parcela(data, CotaCompleta));
            }
        }
    }
}