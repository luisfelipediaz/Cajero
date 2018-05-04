using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware
{
    public interface IHardware
    {
        string ObtenerNumeroCuenta();
        void EntregarDinero(decimal monto);
        void RecibirDinero(decimal monto);
    }
}
