using System;
using System.Collections.Generic;
using System.Text;
using Exercicio01.Entities;

namespace Exercicio01.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contrato, int meses)
        {
            float AliquotaBasica = contrato.TotalValue / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Date.AddMonths(i);
                float AliquotaAtualizada = AliquotaBasica + _onlinePaymentService.Interest(AliquotaBasica, i);
                float AliquotaTotal = AliquotaAtualizada + _onlinePaymentService.PaymentFee(AliquotaAtualizada);
                contrato.AdicionaParcela(new Installment(data, AliquotaTotal));
            }
        }
    }
}
