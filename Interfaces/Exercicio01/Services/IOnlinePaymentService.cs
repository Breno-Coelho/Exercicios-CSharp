using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Services
{
    interface IOnlinePaymentService
    {
        float PaymentFee(float amount);

        float Interest(float amount, int months);
        
    }
}
