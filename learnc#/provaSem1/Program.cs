using System;

namespace provaSem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais[] paises = new Pais[10];
            for(int i=0; i<5; i++){
                Console.WriteLine($"Escreva o nome, populacao e área do {i} país:\n");
                string n = Console.ReadLine();
                int p = int.Parse(Console.ReadLine());
                double a = double.Parse(Console.ReadLine());;
                paises[i] = new Pais(n,p,a);
            }
            for(int i=0; i<5; i++){ // Retorna o objeto do país com maior densidade
                double maior = paises[0].Densidade();
                if (paises[i].Densidade()>maior){ 
                    Pais maiorpais = paises[i];
                    maior = paises[i].Densidade();
                    Console.WriteLine($"{maiorpais}");}
            }
  
        }
    }

    class Pais{
        //atributos
        private string nome;
        private int populacao;
        private double area;


        public Pais(string nome, int populacao, double area){ //construtor
            if (nome!=null){
                this.nome = nome;
            }
            if (populacao>0){
                this.populacao = populacao;
            }
            if (area>0){
                this.area = area;
            }
        }




        public void SetNome(string n){
            if (n!=null){
                this.nome = n;
            }
        }

        public void SetPopulacao(int p){
            if (p>0){
                this.populacao = p;
            }
        }

        public void SetArea(double a){
            if (a>0){
                this.area = a;
            }
        }

        public string GetNome(){
            return nome;
        }

        public int GetPopulacao(){
            return populacao;
        }

        public double GetArea(){
            return area;
        }

        public double Densidade(){
            return populacao/area;
        }

        public override string ToString(){
            if(nome!=null && area>0 && populacao>0){
                return $"Nome = {nome}\nPopulacao = {populacao}\nArea = {area}";
            }
            return "";
        }
    }
}