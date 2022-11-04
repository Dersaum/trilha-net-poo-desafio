namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("Você não tem saldo suficiente!");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine( nomeApp + " será instalado no seu Nokia.");
        }

        public override void Inicializar()
        {
            Console.WriteLine("Smartphone Nokia.\nModelo: " + Modelo + 
                        " - Memóra disponível: " + Memoria + "kb");
        }
    }
}