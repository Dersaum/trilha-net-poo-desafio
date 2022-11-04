namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação a cobrar!");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Seu Iphone irá iniciar a instalação do aplicativo: {nomeApp}.");
        }

        public override void Inicializar()
        {
            Console.WriteLine("Smartphone Iphone.\nModelo: " + Modelo + 
                            " - Memóra disponível: " + Memoria + "Tb");
        }
    }
}