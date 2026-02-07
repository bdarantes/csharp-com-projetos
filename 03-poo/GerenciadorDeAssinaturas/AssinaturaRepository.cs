using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

public class AssinaturaRepository 
{
    private string _caminhoArquivo = "assinaturas.json";
    private List<Assinatura> _assinaturas = new List<Assinatura>();


    public AssinaturaRepository()
    {
        CarregarDados();
    }

    public void Adicionar(Assinatura assinatura)
    {
        _assinaturas.Add(assinatura);
        SalvarDados();
    } 

    public List<Assinatura> ListarTodas()
    {
        return _assinaturas;
    }

    private void SalvarDados()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(_assinaturas, options);

        File.WriteAllText(_caminhoArquivo, jsonString);
    }  

    private void CarregarDados()
    {
        if (!File.Exists(_caminhoArquivo))
            return;
        
        string jsonString = File.ReadAllText(_caminhoArquivo);

        _assinaturas = JsonSerializer.Deserialize<List<Assinatura>>(jsonString) ?? new List<Assinatura>();
    } 
    
}