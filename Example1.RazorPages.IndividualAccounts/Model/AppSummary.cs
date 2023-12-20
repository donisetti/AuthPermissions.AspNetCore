// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

namespace Example1.RazorPages.IndividualAccounts.Model;

public class AppSummary
{
    public string Application { get; } = "ASP.NET Core, Páginas Razor";
    public string AuthorizationProvider { get; } = "Contas individuais do ASP.NET Core";
    public string CookieOrToken { get; } = "Cookie";
    public string MultiTenant { get; } = "- não utilizado -";
    public string[] Databases { get; } = new []
    {
        "Individual accounts: InMemory Database",
        "AuthPermissions: In-memory database (usa o  SQLite na memória)"
    };
    public string Note { get; } = "Mostra noções básicas de funções e permissões, além de suporte a vários idiomas.";
}