using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public interface ITransaccion
    {
        void Logear();

        string Retirar(decimal monto);
        string Consignar(decimal monto);
        decimal ConsultarSaldo();
    }
}
