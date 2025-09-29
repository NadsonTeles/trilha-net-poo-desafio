using DesafioPOO.Models;

Console.WriteLine("=== Smartphone Nokia ===");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("=== Smartphone iPhone ===");
Smartphone iphone = new Iphone(numero: "789012", modelo: "iPhone 12", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine();
Console.WriteLine("Testes realizados com sucesso!");