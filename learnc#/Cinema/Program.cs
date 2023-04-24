using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingressos x = new Ingressos();

            x.SetHorario(14);
            x.SetDia(terca);
            x.GetDia();
            x.GetHorario();
        }
    }
}


class Ingressos{
    private int dia, horario, entradaNormal=16, MeiaEntrada=entradaNormal/2;

    public void SetHorario(int h){
         if (h>=17 or h==00) {
              horario=h; entradaNormal = entradaNormal*0.50;
        }
    }


    public void SetDia(string d){ 
                                  if(d = "segunda" or d = "terca" or d = "quinta"){dia = d;}
                                  if(d ='quarta'){ dia = d; entradaNormal = MeiaEntrada, SetHorario(0);}
                                  else dia = d; entradaNormal = 20;
                                }
    public int GetHorario(){ return horario};
    public int GetDia(){ return dia};
}

