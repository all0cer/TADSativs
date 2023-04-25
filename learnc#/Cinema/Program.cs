using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingressos x = new Ingressos();

            x.SetHorario(17);
            x.SetDia("quarta");
            Console.WriteLine(x.GetDia());
            Console.WriteLine(x.GetHorario());
            Console.WriteLine(x.GetValor());
        }
    }
}


class Ingressos{
    private double  horario, entradaNormal;
    private string dia;

    public void SetHorario(double h){
         if (h>=17 || h==00) {
              horario=h; entradaNormal = entradaNormal*0.50;
        }
        else horario=h;
    }
    public void SetDia(string d){ 
                                  if(d == "segunda" || d == "terca" || d == "quinta"){dia = d;}
                                  if(d == "quarta"){ dia = d; entradaNormal = 10;}
                                  else dia = d; entradaNormal = 20;
                                }



    public double GetHorario(){ return horario;}
    public string GetDia(){ return dia;}
    public double GetValor(){return entradaNormal;}
}

