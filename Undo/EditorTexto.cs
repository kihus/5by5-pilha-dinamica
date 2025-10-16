namespace Undo;

internal class EditorTexto
{
    public Pilha Historico { get; set; }


    public EditorTexto(int qtt)
    {
        Historico = new Pilha(qtt);
    }

    public void Digitar(string texto)
    {
        Historico.Empilhar(texto);
        Console.WriteLine("Texto adicionado!");
    }

    public string Desfazer()
    {
        return Historico.Desempilhar();
    }

    public void MostrarHistorico()
    {
        Historico.ExibirPilha();
    }

}
