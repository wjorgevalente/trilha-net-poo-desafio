using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smart Nokia");
Smartphone nokia = new Nokia(numero: "64739", modelo: "Nokia G8", imei: "fjdh2736", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smart iPhone");
Smartphone iphone = new Iphone(numero: "333411", modelo: "Modelo iPhone14", imei: "fd456d", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceBook");