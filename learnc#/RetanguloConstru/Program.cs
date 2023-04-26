using System;

namespace RetanguloConstru
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}


class Retangulo{
    private double b, h;

    Retangulo(double b, double h){ if(this.b>0 && this.h>0){ this.b = b; this.h = h;}}
    public void SetBase(double b){ if(this.b>0){this.b = b;}}
    public void SetAltura(double h){ if(this.h>0){this.h = h;}}

    public double GetBase(){ return b;}
    public double GetAltura(){ return h;}


    public double CalcArea(){ return (b*h);}
    public double CalcDiagonal(){ return Math.Sqrt((b*b) + (h*h));}

    public override string ToString(){return $"Base = {b} Altura = {h}";}




}
