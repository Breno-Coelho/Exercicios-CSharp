using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities.Enums
{
    enum OrderStatus : int
    {
        PagamentoPendente = 0,
        ProcessandoPagamento = 1,
        Enviado = 2,
        Entregue = 3,
    }
}
