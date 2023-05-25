using System;
using System.Collections;

namespace provasem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador a = new Jogador("Ronaldinho", 9, 260);
            Jogador b = new Jogador("Vini", 2, 2);
            Jogador c = new Jogador("Tafarel", 1, 10);
            Jogador[] v = {a, b, c};
            Array.Sort(v, new NomeComparer()); // usado para aplicar a classe em todo o
                                              // array
            foreach (Jogador j in v)
            {
                Console.WriteLine(j);
            }

        }
    }

    class Jogador: IComparable{ // Usado para comparar em ordem alfabética em strings
                                // Ou crescente com numeros
            private string nome="Sem nome";
            private int camisa = 0, numGols=0;

            public Jogador(string nome, int camisa, int numGols){//Constructor
                if(nome != "") this.nome = nome;
                if (camisa > 0 && camisa < 1000) this.camisa = camisa;
                if (numGols >= 0 ) this.numGols = numGols;
            }
            //PROPRIEDADES
            public string Nome{
                set {if (value != "") this.nome = value;}
                get {return nome;}
            }

            public int Camisa{
                set {if (value > 0 && value < 1000) this.camisa = value;}
                get{return camisa;}
            }

            public int NumGols{
                set{if (value >= 0 ) this.numGols = value;}
                get{return numGols;}
            }

            public override string ToString(){
                return $"Jogador - {nome}\nCamisa - {camisa}\nGols - {numGols}";
            }

            public int CompareTo(object obj){ //Caso use "Array.sort()" ordena em
                                              // ordem alfabética
                Jogador x = obj as Jogador;
                return Nome.CompareTo(x.Nome);
            }
       }
    class CamisaComparer : IComparer{ // Numero crescente de camisas
        public int Compare(object obj1, object obj2){
            Jogador x = obj1 as Jogador;
            Jogador y = obj2 as Jogador;
            return x.Camisa.CompareTo(y.Camisa);
        }
    }

    class GolComparer : IComparer{ //Compara quantidade de gols
        public int Compare(object obj1, object obj2){
            Jogador x = obj1 as Jogador;
            Jogador y = obj2 as Jogador;
            return -x.NumGols.CompareTo(y.NumGols); // utilizando sinal de menos para
                                                    // inverter a ordem
        }
    }

    class NomeComparer : IComparer{ //Nomes em ordem alfabética
        public int Compare(object obj1, object obj2){
            Jogador x = obj1 as Jogador;
            Jogador y = obj2 as Jogador;
            return x.Nome.CompareTo(y.Nome);
        }
    }
}
