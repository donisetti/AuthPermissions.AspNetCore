﻿namespace Facil.WebUI.Models;

public class Estado
{
    public int Id { get; set; }
    public string Sigla { get; set; }
    public string Nome { get; set; }
    public Regiao Regiao { get; set; }
}
