namespace MasterDev
{
    public class Vaca : ISonido
    {
        public async Task<string> HacerSonido(string nombreSonido)
        {
            var sonido = string.IsNullOrWhiteSpace(nombreSonido) ? "muuuu" : nombreSonido;

            return await Task.FromResult($"La vaca hace {sonido}!");
        }
    }
}