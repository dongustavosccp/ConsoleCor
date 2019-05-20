namespace GameTop.Interface
{
    public interface IJogador
    {
        string Nome { get; set; }
        string Chutar();
        string Correr();
        string Passar();
    }
}