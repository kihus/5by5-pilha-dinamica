using PilhaDinamica;

var pilha = new Pilha();

var usando = false;
do
{
    Console.Clear();
    Console.WriteLine("1 - Inserir Roupa | 2 - Remover Roupa | 3 - Exibir Roupas | 4 - Sair");
    Console.Write("-> ");
    var opcao = int.Parse(Console.ReadLine() ?? "");

    switch (opcao)
    {
        case 1:
            Console.Write("Escreva uma descrição da roupa: ");
            var nome = Console.ReadLine();

            Console.Write("Escreva a cor da roupa: ");
            var corRoupa = Console.ReadLine();
            var roupa = new Roupa(nome, corRoupa);

            pilha.InserirPilha(roupa);
            break;
        case 2:
            var aux = pilha.Desempilhar();
            Console.WriteLine($"Roupa removida:\n {aux}\n\r");
            break;
        case 3:
            Console.WriteLine("\nPilha:\n");
            pilha.MostrarPilha();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Obrigado por usar nosso programa");
            usando = true;
            break;
        default:
            Console.WriteLine("\nDigite corretamente");
            break;
    }
    Console.WriteLine("Aperte o enter para continuar...");
    Console.ReadKey();

} while (!usando);