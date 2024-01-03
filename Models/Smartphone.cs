namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string imie;
        private int memoria;

        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public string Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, string memoria) 
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        protected Smartphone(string numero, string imie, string modelo, int memoria)
        {
            Numero = numero;
            this.imie = imie;
            Modelo = modelo;
            this.memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}