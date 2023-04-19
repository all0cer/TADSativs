using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas x = new Notas();
            Console.WriteLine("Digite o nome da matéria: ");
            x.SetNome(Console.ReadLine());
            Console.WriteLine("Digite a primeira nota: ");
            x.Setnota1(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a segunda nota: ");
            x.Setnota2(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a terceira nota: ");
            x.Setnota3(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a quarta nota: ");
            x.Setnota4(int.Parse(Console.ReadLine()));
            int media = x.CalcMediaParcial();
            if(media>=60)Console.WriteLine("Aluno Aprovado!");
            else{Console.WriteLine("Digite a nota da prova final: "); x.SetnotaFinal(int.Parse(Console.ReadLine()));}
            

            if(x.CalcMediaFinal()>=60){Console.WriteLine("Aluno aprovado!");}
            else Console.WriteLine("Reprovado, estude mais");
        }
    }
}

/*class circulo{
    private double raio;
    public double Setraio(double v){// encapsulamento para o Raio receber somente caso for maior que zero, "filtro"
        if (v >= 0) raio = v;
    }
    public double Getraio(){
        return raio;
    }
    public double AreaCirculo(){
        return 3.14 * (raio * raio);
    }
    public double circunferencia(){
        return 2*3.14*raio;
    }
}*/


class Notas{
    // atributos
    private int b1, b2, b3, b4, pv;
    private string nome;

    //métodos
    public void SetNome(string s){if(!string.IsNullOrEmpty(s)) nome = s; else nome = "anonimo"; }
    public void Setnota1(int n){if (n>=0){ b1 = n;}}
    public void Setnota2(int n){if (n>=0){ b2 = n;}}
    public void Setnota3(int n){if (n>=0){ b3 = n;}}
    public void Setnota4(int n){if (n>=0){ b4 = n;}}
    public void SetnotaFinal(int n){if (n>=0){ pv = n;}}
    public string GetNome(){return nome;}
    public int GetNota1(){return b1;}
    public int GetNota2(){return b2;}
    public int GetNota3(){return b3;}
    public int GetNota4(){return b4;}
    public int GetNotaFinal(){return pv;}
    public int CalcMediaParcial(){return ((b1*2)+(b2*2)+(b3*3)+(b4*3))/10;}
    public int CalcMediaFinal(){return (CalcMediaParcial()+pv)/2;}



}