namespace MasterDev
{
    public class Perro : ISonido
    {
        public async Task<string> HacerSonido(string nombreSonido)
        {
            var sonido = string.IsNullOrWhiteSpace(nombreSonido) ? "guau" : nombreSonido;
            return await Task.FromResult($"El gato hace {sonido}!");
        }
    }
}
