using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone( numero: "4002-8922", modelo: "modelo 1", imei: "11111111", memoria:128 );
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("WoozWorld");
Iphone.NumeroSmartphone();
Iphone.TrocarNumero();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "0800-770-7900", modelo: "Modelo 2", imei: "222222222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Huji");
nokia.NumeroSmartphone();
nokia.TrocarNumero();

Console.WriteLine("\n");