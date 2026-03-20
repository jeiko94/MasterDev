namespace MasterDev
{
    public interface ISonido
    {
        Task<string> HacerSonido(string nombreSonido);
    }
}
