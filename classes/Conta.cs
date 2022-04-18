﻿using DigiBank.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroArgencia = "0001";
            Conta.NumeroContaSequencial++;
            this.Movimentacoes = new List<Extrato>();

        }

        public double Saldo { get; protected set; }
        public string NumeroArgencia { get; private set; }
        public string NumeroConta { get;  protected set; }
        public static int NumeroContaSequencial { get;  private set; }
        private List<Extrato> Movimentacoes;

        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Depositar(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual,"Deposito" ,valor));
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(valor > this.ConsultaSaldo())
                return false;

            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Saque", -valor));

            this.Saldo += valor;
            return true;
        }

        public string GetCodigoBanco()
        {
            return this.CodigoBanco;
        }

        public string GetNomeBanco()
        {
            return this.NomeBanco;
        }

        public string GetNumeroArgencia()
        {
            return this.NumeroArgencia;
        }

        public string GetNumeroConta()
        {
           return this.NumeroConta;    
        }

        public List<Extrato> Extrato()
        {
            return this.Movimentacoes;
        }
    }
}
