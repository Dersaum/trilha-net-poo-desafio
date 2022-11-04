namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }

        public string IMEI
        {
            get => _imei;
            set => _imei = value;
        }

        public int Memoria
        {
            get => _memoria;
            set => _memoria = value;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public virtual void Inicializar()
        {
            Console.WriteLine("Smartphone sendo inicializado!");
        }
    }
}