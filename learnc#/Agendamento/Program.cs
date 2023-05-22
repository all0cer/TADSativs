using System;
using System.Globalization;
using System.Threading;
namespace Loja
{
    class Program
    {   
        private static Agenda agenda = new Agenda();
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            int op = Menu();
            while (op != 0) {
            switch (op) {
            case 1 : Inserir(); break;
            case 2 : Excluir(); break;
            case 3 : Listar(); break;
        }
      op = Menu();
        }
    }

    public static int Menu() {
    Console.Write("0-Fim, 1-Inserir, 2-Excluir, 3-Listar, 4-Pesquisar: ");
    return int.Parse(Console.ReadLine());
  }



    public static void Inserir() {
    Console.WriteLine("Inserir novo compromisso");
    Console.Write("Informe o assunto: ");
    string assunto = Console.ReadLine();
    Console.Write("Informe o local: ");
    string local = Console.ReadLine();
    Console.Write("Informe a data: ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Compromisso c = new Compromisso { Assunto = assunto, Local = local, Data = data};
    agenda.Inserir(c);
    Console.WriteLine("Compromisso inserido com sucesso");
  }

    public static void Excluir() {
    Console.WriteLine("Excluir um compromisso");
    int n = 0;
    foreach (Compromisso c in agenda.Listar())
      Console.WriteLine($"{n++} - {c}");
    Console.Write("Informe o número do compromisso para remover: ");
    n = int.Parse(Console.ReadLine()); 
    Compromisso x = agenda.Listar()[n];
    agenda.Excluir(x);
    Console.WriteLine("Compromisso excluído com sucesso");    
  }


  public static void Listar() {
    Console.WriteLine("Listar os compromissos");
    foreach (Compromisso c in agenda.Listar())
      Console.WriteLine(c);
  }



    class Compromisso{
        public string Assunto{
            get;
            set;
            }
        public string Local{
            get;
            set;

        }
        public DateTime Data{
            get;
            set;
        }

        public override string ToString(){
            return $"{Assunto}\n{Local}\n{Data}";
        }




    }
    class Agenda{
        private Compromisso[] comps  =  new Compromisso[2];
        private int k;

        public int Qtd{
            get {return comps.Length();}
        }
        // Métodos
        public Compromisso Listar(Compromisso[] c){
            foreach (Compromisso x in c)
            {
                return x;
            }
        }

        void Inserir(Compromisso c){
            if (k == comps.Length()){
                Array.Resize(ref comps, 2*comps.Length());
            }
            comps[k] = c;
            k++;
        }

        void Excluir(Compromisso c){
            Compromisso [] novo = new Compromisso[k-1];
            foreach (Compromisso x in comps){
                if(x != c){Array.Copy(comps, novo, k-1);}
            }
            comps = novo;
        }

    }
}
}
