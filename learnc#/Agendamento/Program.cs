using System;
    class Program
{   

    private static Agenda agenda = new Agenda();
    static void Main(string[] args){
        int op = Menu();
        while(op != 0){
            switch(op){
                case 1: Inserir(); break;
                case 2: Listar(); break;
                case 3: Excluir(); break;
            }
        op = Menu();
        }
    }
    public static int Menu(){
    Console.WriteLine("0-FIM 1-INSERIR 2-LISTAR 3-EXCLUIR");
    return int.Parse(Console.ReadLine());
    }

    public static void Inserir(){
        Console.WriteLine("Escreva o assunto que deseja inserir: ");
        string assunto = Console.ReadLine();
        Console.WriteLine("Escreva o local do compromisso: ");
        string local = Console.ReadLine();
        Console.WriteLine("Escreva a Data no formato dd/mm/yyyy: ");
        DateTime data = DateTime.Parse(Console.ReadLine());
        Compromisso novo_compromisso= new Compromisso{Assunto = assunto,Local = local, Data = data};
        agenda.Inserir(novo_compromisso);
        Console.WriteLine("Compromisso inserido na agenda!");
    }

    public static void Listar(){
        Console.WriteLine("Seus compromissos: ");
        foreach (Compromisso x in agenda.Listar())
        {
            Console.WriteLine(x);
        }
    }

    public static void Excluir(){
        int n = 0;
        foreach(Compromisso x in agenda.Listar()){
            Console.WriteLine($" {n++} - {x}");
        }
        Console.WriteLine("Escolha o numero do Compromisso que deseja excluir: ");
        int excluirNoIndex = int.Parse(Console.ReadLine());
        Compromisso excluido = agenda.Listar()[excluirNoIndex];
        agenda.Excluir(excluido);
        Console.WriteLine("Excluido com sucesso!");
    }
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
        return $"Local: {Local}\nAssunto: {Assunto}\nData: {Data}\n";
    }
}


class Agenda{
    private Compromisso[] comps = new Compromisso[2];
    private int k; //quantidade de compromissos inseridos
    public int Quantidade{
        get{ return k;}
    }

    public void Inserir(Compromisso c){
        if(k == comps.Length){Array.Resize(ref comps, comps.Length * 2);}
            comps[k] = c;
        k++;
    }

    public Compromisso[] Listar(){
        Compromisso[] aux = new Compromisso[k];
        Array.Copy(comps, aux, k);
        return aux;
        }
    public void Excluir(Compromisso c){
        Compromisso[] atualiza_lista = new Compromisso[k-1];
        int k_novo=0;
        foreach(Compromisso i  in Listar()){if(i != c) { atualiza_lista[k_novo++] = i;}}
        k--;
        comps = atualiza_lista;
    }

}

