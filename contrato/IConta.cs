using DigiBank.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.contrato
{
    public interface IConta
    {

        void Depositar(double valor);
        bool Saca(double valor);
        double ConsultaSaldo();
        string GetCodigoBanco();
        string GetNomeBanco();
        string GetNumeroArgencia();
        string GetNumeroConta();
        List<Extrato> Extrato();

    }
}
