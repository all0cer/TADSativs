using System;
namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaGenerica<string> x = new PilhaGenerica<string>();
            x.Push("camaco");
            x.Push("Cojura");
            x.Push("Riçoneronte");
            Console.WriteLine(x.Peek());
        }
    }

    class PilhaGenerica<T>{
        private T[] objs = new T[10];
        private int k=0; //Contar quantos elementos tem na pilha
        public int Count{
            get {return k;}
        }
        public void Push(T obj){ // Adicionar elemento na pilha
            if(k == objs.Length){
                Array.Resize(ref objs, 2 * objs.Length);
            }
            objs[k] = obj;
            k++;
        }
        public T Pop(){  // Retira um da pilha
            if (k == 0){
                throw new InvalidOperationException();
            }
            k--;
            return objs[k];
        }
        public T Peek(){ //Retorna o ultimo da pilha da pilha
            if (k == 0){
                throw new InvalidOperationException();
            }
            return objs[k-1];
        }

        public void Clear(){ //Não apagar os existentes, somente declarar que não há mais 
            k = 0;
        }
    }
}
