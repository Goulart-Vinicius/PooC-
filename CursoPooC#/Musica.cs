namespace CursoPooC_;
internal class Musica
{
    public string nome;
    public string artista;
    public float duracao;
    public bool disponivel;

    public void showMusic()
    {
        Console.WriteLine($"Nome : {this.nome}");
        Console.WriteLine($"Artista : {this.artista}");
        Console.WriteLine($"Duração : {this.duracao}s");
        Console.WriteLine(this.disponivel ? "Musica esta disponivel" : "Musica não disoponivel");
    }
}
