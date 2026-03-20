namespace MasterDev
{
    public class Contador
    {

        private int valor;

        public Contador()
        {
            valor = 0;
        }

        
        public int Incrementar()
        {
            return ++valor;
        }

        
        public int Decrementar()
        {
            return --valor;
        }
    }
}