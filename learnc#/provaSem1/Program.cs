using System;

namespace provaSem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais paises = new Pais[10];
            for(int i=0; i<10; i++){
                Console.WriteLine($"Escreva o nome, populacao e área do {i} país:\n");
                paises[i] = new Pais(Console.ReadLine(),  int.Parse(Console.ReadLine()),  double.Parse(Console.ReadLine()));
            }



        }
    }
}



class Pais{
    //atributos
    private string nome;
    private int populacao;
    private double area;


    Pais(string nome, int populacao, double area){ //construtor
        if (this.nome!=null){
        this.nome = nome;
        }
        if (this.populacao>0){
            this.populacao = populacao;
        }
        if (this.area>0){
            this.area = area;
    }
    }




    static void SetNome(string n){
         if (n!=null){
        this.nome = n;
        }
    }

    static void SetPopulacao(int p){
        if (p>0){
            this.populacao = p;
        }

    }

    static void SetArea(double a){
         if (a>0){
        this.area = area;
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
            return $"Nome = {nome}\nPopulacao = {populacao}\nArea = {area}";}
    }



}
