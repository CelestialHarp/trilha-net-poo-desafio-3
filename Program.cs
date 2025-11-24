using System.ComponentModel;
using System.Xml;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Por via das dúvidas, implementei os mesmos testes que o professor realizou no vídeo.
Console.WriteLine("Testando no Nokia:");
Smartphone nokia = new Nokia(numero: "321436541", modelo: "Modelo GX", imei: "3136154351", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("Testando no iPhone:");
Smartphone iphone = new Iphone(numero: "68756456", modelo: "Modelo 0", imei: "564365354", memoria: 64);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Calculadora");