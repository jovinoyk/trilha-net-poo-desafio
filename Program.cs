using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero:"123456",modelo: "Modelo 1", imei:"111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"1456",modelo: "Modelo 13", imei: "112112", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IFood");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone2 = new Iphone(numero:"15456",modelo: "Modelo 3", imei: "1132112", memoria: 128);
iphone2.Ligar();
iphone2.InstalarAplicativo("Telegram");

