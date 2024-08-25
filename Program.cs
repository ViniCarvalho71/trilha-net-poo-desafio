using DesafioPOO.Models;

Iphone proMax = new Iphone("14 996164842","15 ProMax", "e2w3q4234324", 8);
Nokia nokia = new Nokia("14 996164842", "nokia", "ee32432e2343254", 2);

proMax.InstalarAplicativo("Minecraft");
nokia.InstalarAplicativo("Jogo da cobrinha");

proMax.Ligar();
nokia.ReceberLigacao();