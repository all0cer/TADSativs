using System;
using System.Collections.Generic;
namespace Producao
{
    class Program
    {
        private static NProduto npproduto = new NProduto();
        static void Main(string[] args){
            int op = Menu();
            while(op != 0){
                switch(op){
                    case 1: Inserir(); break;
                    case 2: Listar(); break;
                    //case 3: ListarProduto(); break;
                    //case 4: Atualizar(); break;
                }
            op = Menu();
            }
        }

    public static int Menu(){
    Console.WriteLine("0-FIM 1-INSERIR 2-LISTAR 3-EXCLUIR");
    return int.Parse(Console.ReadLine());
        }
    
    public static void Inserir(){
            Produto produto = new Produto();
            Console.WriteLine("Digite o ID do produto:\n");
            produto.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a descricao do produto:\n");
            produto.descricao = Console.ReadLine();
            Console.WriteLine("Digite o preco do produto:\n");
            produto.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estoque atual do produto:\n");
            produto.estoque = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID da categoria do produto:\n");
            produto.idCategoria = int.Parse(Console.ReadLine());
            npproduto.Inserir(produto);
            Console.WriteLine("Produto Inserido com sucesso!\n");
    }
    public static void Listar(){
        foreach(Produto p in npproduto.Listar()){
            Console.WriteLine(p);
        }
    }
}

    
    class Produto{
        public int id{get;set;}
        public string descricao{get;set;}
        public double preco{get;set;}
        public int estoque{get; set;}
        public int idCategoria{get;set;}
    }

    class NProduto{
        private List<Produto> Produtos = new List<Produto>();

        public List<Produto> Listar(){
            return Produtos;
        }

        public Produto ListarProduto(int id){
            foreach(Produto p in Produtos){
                if(id == p.id){
                    return p;
                }
            }
            return Produtos[0];
        }

        public void Inserir(Produto p){
            Produtos.Add(p);
        }

        public void Atualizar(Produto p){
            
        }


    }
}
