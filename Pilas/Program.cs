namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();

            pila.Push(5);
            pila.Push(3);
            pila.Push(10);

            pila.Transversa();

            Console.WriteLine(pila.Pop());

            pila.Transversa();

            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Peek());
            pila.Transversa();
        }
    }
}

