using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Smartphone celularNokia1 = new Nokia(numero: "33717-8945", modelo: "Tijolão", imei: "524896", memoria: 2);

celularNokia1.Inicializar();
celularNokia1.InstalarAplicativo("Chess");
celularNokia1.Ligar();

System.Console.WriteLine();

Smartphone celularIphone1 = new Iphone("45882-9663", "19S Pro Ultra Max Plus", "7558", 77);

celularIphone1.Inicializar();
celularIphone1.InstalarAplicativo("Waze");
celularIphone1.ReceberLigacao();