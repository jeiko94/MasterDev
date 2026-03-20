using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_proyecto
{
    internal class CuentaBancaria
    {
    }
}
public class CuentaBancaria
{

    private double saldo;


    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            saldo += monto;

        }
    }

    public bool Retirar(double monto)
    {
        if (monto > 0 && saldo >= monto)
        {
            saldo -= monto;
            return true;
        }

        return false;
    }


    public double ObtenerSaldo()
    {
        return saldo;
    }


}