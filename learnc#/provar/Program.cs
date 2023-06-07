using System;
using System.Collections;
namespace provar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamar as duas classes  e testar todos os metodos
        }
    }

    class ContaReceber: IComparable{
        private string cliente;
        private double valor;
        private bool recebido;
        private DateTime dataVencimento;
        public ContaReceber(string c, double v, bool r, DateTime d){
            Cliente = c;
            DataVencimento = d;
            Valor = v;
            // validar cada propriedade
        } 
        public string Cliente{
            set{if(value != "")this.cliente = value;}
            get{ return cliente;}
        }
        public DateTime DataVencimento{
            set{this.dataVencimento = value;}
            get{ return dataVencimento;}
        }
        public double Valor{
            set{if(value > 0)this.valor = value;}
            get{ return valor;}
        }
        public bool Recebido{
            set{this.recebido = value;}
            get{return recebido;}
        }
        public void Receber(){
            this.recebido =true;

        }
        public int CompareTo(object obj){
            ContaReceber x = obj as ContaReceber;
            return dataVencimento.CompareTo(x.dataVencimento);

        }
        public override string ToString(){
                return $"Cliente: {cliente}\nValor: {valor}\nData: {dataVencimento}";
        }
    }


    class Financeiro: IEnumerable{
        private ContaReceber[] contas = new ContaReceber[10];
        private int k;
        public void Inserir(ContaReceber conta){
             if(k == contas.Length){Array.Resize(ref contas, contas.Length * 2);}
                contas[k++] = conta;
            k++;
        }
        public ContaReceber[] Listar(){
            ContaReceber[] aux = new ContaReceber[k];
            Array.Copy(contas, aux, k);
            Array.Sort(aux);
            return aux;
        }
        public ContaReceber[] ContasRecebidas(){
            ContaReceber[] aux = new ContaReceber[k];
            int c = 0;
            foreach(ContaReceber conta in Listar())
             if (conta.Recebido) aux[c++] = conta;
            Array.Resize(ref aux, c);
            return aux;
        }
        public ContaReceber[] ContasAReceber(){
            ContaReceber[] aux = new ContaReceber[k];
            int c = 0;
            foreach(ContaReceber conta in Listar())
             if (!conta.Recebido && 
             conta.DataVencimento >= DateTime.Today &&
             conta.DataVencimento < DateTime.Today.AddDays(15)) 
                aux[c++] = conta;
            Array.Resize(ref aux, c);
            return aux;
        }
        public ContaReceber[] ContasVencidas(){
            ContaReceber[] aux = new ContaReceber[k];
            int c = 0;
            foreach(ContaReceber conta in Listar())
             if (!conta.Recebido && 
             conta.DataVencimento <= DateTime.Today) 
                aux[c++] = conta;
            Array.Resize(ref aux, c);
            return aux;
        }
        public IEnumerator GetEnumerator(){
            return Listar().GetEnumerator(); 
        }
        public override string ToString(){
            return $"{ContasAReceber().Length} conta(s) a receber";
        }
    }
}
