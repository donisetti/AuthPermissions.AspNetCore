# Example1.RazorPages.IndividualAccounts

Este projeto contém um exemplo de uso da biblioteca AuthPermissions.
AspNetCore no aplicativo da Web de página Razor ASP.NET Core com dados de usuário fornecidos pela abordagem de contas individuais.
Essa é uma das abordagens mais simples de usar:

Este artigo (!!! LINK !!!) detalha como esse exemplo foi criado e como ele funciona.

- **Application**: ASP.NET Core, Razor Pages
- **AuthorizationProvider**: ASP.NET Core's individual accounts
- **CookieOrToken**: Cookie
- **MultiTenant**: not used
- **Databases**: Two databases
  - Individual accounts: InMemoryDatabase:
  - AuthPermissions: In-memory database (uses SQLite in-memory).
- **Focused on**: The basics of the AuthPermissions authorization system.

The ASP.NET Core code comes comes from the [ASP.NET Core documentation on building razor page web app individual accounts authorization](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/secure-data), but the handling of the visibilty of the contact manager features are handled by the AuthPermissions.AspNetCore library.

The AuthPermissions.AspNetCore code/features used in this example

- Adding the AuthPermissions into your ASP.NET Core application.
- Bulk loading AuthPermissions Roles and Users. 
- Mapping the user's Roles to Permissions.
- Authorization in razor pages via the `[HasPermission(<enum permission>)]` attribute on the `PageModel` class.
- Authorization in razor pages via the `User.HasPermission(<enum permission>)` method.
- Add SuperUser on startup feature.

NOTE: This example does not include the admin pages for 

*NOTE: [This article](https://blog.francium.tech/asp-net-core-basic-authentication-authorization-in-razor-pages-with-postgresql-b1f2888b21d0) provides a good overview of the standard ASP.NET Core authorization approaches.*

