using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco x = new Banco();
            x.SetTitular(Console.ReadLine());
            x.SetnumConta(Console.ReadLine());
            x.SetSaldo(double.Parse(Console.ReadLine()));
            Console.WriteLine(x.GetSaldo());

        }
    }
}



class Banco{
    private string titular = "Anonimo";
    private string numConta = "Sem Conta";
    private double saldo = 0;

    public void SetTitular(string t) {if (t != ""){titular = t;}}
    public void SetnumConta(string n) {if (n != ""){titular = n;}}
    public void SetSaldo(double s){if (s >= 0) {saldo = s;}}
    public void Depositar(double d) {if(d<0){throw new ArgumentOutOfRangeException();} else saldo += d;}
    public void Saque(double z) {if (z <= saldo)saldo -= z; else throw new ArgumentOutOfRangeException();}

    public string GetTitular(){return titular;}
    public string GetnumConta(){return numConta;}
    public double GetSaldo(){return saldo;}
}