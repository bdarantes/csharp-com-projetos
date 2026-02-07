using System;
using System.Collections.Generic;


List<INotificacao> filaDeEnvio = new List<INotificacao>();

filaDeEnvio.Add(new Email());
filaDeEnvio.Add(new Sms());
filaDeEnvio.Add(new Email());


Console.WriteLine("--- Disparando Alertas ---");

foreach (var item in filaDeEnvio) 
{
    item.Enviar("Seu pedido saiu para entrega!");
}

public interface INotificacao 
{
    void Enviar(string mensagem);
}


public class Email : INotificacao 
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando Email: {mensagem}");
    }
}

public class Sms : INotificacao
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}