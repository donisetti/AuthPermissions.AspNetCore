namespace Facil.Dominio.Entidades;

public class Sistema
{
    public Sistema(string versao, string data, string ambiente, string conexao)
    {
        Versao = versao;
        Data = data;
        Ambiente = ambiente;
        Conexao = conexao;
    }

    public string Versao { get; set; }
    public string Data { get; set; }
    public string Ambiente { get; set; }
    public string Conexao { get; set; }
}
