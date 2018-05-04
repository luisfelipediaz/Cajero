using Modelo;

namespace Banco
{
    public interface IServicioBancario
    {
        Cuenta ObtenerCuenta(string numero);

        void GuardarCambios();
    }
}
