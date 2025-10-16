namespace Undo;

internal class Pilha
{
    public string[] Head { get; private set; }
    public int Contador { get; private set; }

    public Pilha(int qtt)
    {
        Head = new string[qtt];
    }

    public bool EstaVazia()
    {
        if (Head[0] == null)
            return true;
        else
            return false;
    }

    public void Empilhar(string item)
    {
        if (EstaCheia())
        {
            Console.WriteLine("Pilha já está cheia!");
            Console.WriteLine("Limpe o historico para adicionar mais itens");
            return;
        }

        if (EstaVazia())
        {
            Head[0] = item;
            Contador++;
        }
        else
        {
            for (int i = Contador; i >= 0; i--)
            {
                Head[i + 1] = Head[i];

            }
            Head[0] = item;
            Contador++;
        }
    }

    public string Desempilhar()
    {
        var aux = Head[0];
        for (int i = 0; i < Contador; i++)
        {
            Head[i] = Head[i + 1];
        }
        Contador--;
        return aux;
    }

    public string Topo()
    {
        if (EstaVazia())
            return "Pilha vazia";
        else
            return Head[0];
    }

    public bool EstaCheia()
    {
        if (Contador == 10)
            return true;
        else
            return false;

    }

    public void ExibirPilha()
    {
       
        for (int i = 0; i < Contador; i++)
        {
            Console.WriteLine("Historico:");
            Console.WriteLine(Head[i] + "\n\n");
        }
    }
}
