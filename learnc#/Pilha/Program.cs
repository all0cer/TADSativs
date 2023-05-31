using System;
namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaGenerica<string> x = new PilhaGenerica<string>();
            x.Push("Macaco");
            Console.WriteLine(x);
        }
    }

    class PilhaGenerica<T>{
        private T[] objs = new T[10];
        private int k=0;
        public int Count{
            get {return k;}
        }
        public void Push(T obj){
            if(k == objs.Length){
                Array.Resize(ref objs, 2 * objs.Length);
            }
            objs[k] = obj;
            k++;
        }
        public T Pop(){
            if (k == 0){
                throw new InvalidOperationException();
            }
            k--;
            return objs[k];
        }
        public T Peek(){
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
