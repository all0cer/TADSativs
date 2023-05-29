// See https://aka.ms/new-console-template for more information

class Program{
static void Main(string[] args){
        

}
class Jogador: IComparable{
    private string nome;
    private int camisa;
    private int numGols;

    public Jogador(string nome, int camisa, int numGols){
        Nome = nome;
        Camisa = camisa;
        NumGols = numGols;
    }

    public string Nome{
        set{if(value != "") this.nome = value;}
        get{ return nome;}
    }

    public int Camisa{
        set{if(1000 > value && value >= 0) this.camisa = value;}
        get{return camisa;}
    }

    public int NumGols{
        set{if(value >= 0) this.numGols = value;}
    }

    public override string ToString(){
        return $"{nome}\n{camisa}\n{numGols}";
    }

    public int CompareTo(object obj){
        Jogador x = (Jogador) obj;
        return Nome.CompareTo(x.Nome);
    }
}

class Equipe{
    private Jogador[] jogs = new Jogador[12];
    private int k = 0;
    private string pais;

    public Equipe(string p){
        if(p != ""){ this.pais = p;}
    }

    public void Inserir(Jogador c){
        if(k == jogs.Length){Array.Resize(ref jogs, jogs.Length + 4)}
        jogs[k] = c;
        k++;
    }
}

}