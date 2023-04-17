using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            circulo x = new circulo();
            
        }
    }
}

class circulo{
    public double raio;
    public double AreaCirculo(){
        return 3.14 * (raio * raio);
    }
    public double circunferencia(){
        return 2*3.14*raio;
    }
}


class Notas{
    // atributos
    public double b1, b2, b3, b4, pv;
    public string disciplina;

    //métodos
    public double MediaParcial(){
            return (b1*2) + (b2*2) + (b3*3) + (b4*3);
        }
     
}