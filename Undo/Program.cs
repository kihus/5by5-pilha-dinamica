using Undo;

var editor = new EditorTexto(10);
var usando = true;
var opcao = "";
do
{
    Console.Clear();

    Console.WriteLine("[1] Digitar novo texto\r\n[2] Desfazer última ação\r\n[3] Mostrar hitórico\r\n[0] Sair");
    Console.Write("-> ");
    opcao = Console.ReadLine() ?? "";

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Escreva o texto que será armazenado");
            var texto = Console.ReadLine();

            editor.Digitar(texto);
            break;

        case "2":
            Console.Clear();
            var historico = editor.Desfazer();
            Console.WriteLine($"movimento desfeito: {historico}");
            break;

        case "3":
            Console.Clear();
            editor.MostrarHistorico();
            break;

        case "0":
            Console.WriteLine("Obrigado por utilizar nosso programa.");
            usando = false;
            break;

        default:

            Console.WriteLine("Comando não reconhecido, tente novamente");
            break;
    }

    Console.WriteLine("\nPressione enter para continuar...");
    Console.ReadKey();

} while (usando);

