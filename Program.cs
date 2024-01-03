using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Ola mundo");

Iphone celular1 = new Iphone(numero:"2737567", modelo:"8 plus", imei: "777777", memoria: "128");
celular1.ReceberLigacao();
celular1.Ligar();
celular1.InstalarAplicativo("Facebok");

Console.WriteLine("**********************************************************************");

Nokia celular2 = new Nokia(numero:"1194775647", modelo:"pro10", imei: "101010", memoria: "64");
celular2.ReceberLigacao();
celular2.Ligar();
celular2.InstalarAplicativo("Instagram");