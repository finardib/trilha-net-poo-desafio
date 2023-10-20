using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "78910", modelo: "Modelo 2", imei: "2222", memoria: 128);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("pinterest");