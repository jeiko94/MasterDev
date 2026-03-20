namespace MasterDev
{
    public class Gato : ISonido
    {
        public async Task<string> HacerSonido(string nombreSonido)
        {
           var sonido = string.IsNullOrWhiteSpace(nombreSonido) ? "miau" : nombreSonido;
            return await Task.FromResult($"El gato hace {sonido}!");
        }
    }
}
