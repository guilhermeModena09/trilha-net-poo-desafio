using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

        Nokia nokia = new Nokia("1234567890", "Nokia 3310", "123456789012345", 16);

        // Instalar aplicativo no Nokia
        nokia.InstalarAplicativo("WhatsApp");

        // Criar um objeto Iphone
        Iphone iphone = new Iphone("9876543210", "Iphone 13", "987654321098765", 128);

        // Instalar aplicativo no Iphone
        iphone.InstalarAplicativo("Instagram");

        Console.ReadLine();
    