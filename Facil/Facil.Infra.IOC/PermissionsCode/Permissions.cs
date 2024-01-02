// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;


namespace Facil.Infra.IOC.PermissionsCode
{
    /// <summary>
    /// Este é um exemplo de como você pode criar um aplicativo real
    /// Observe que há muitas permissões - a ideia é ter um controle muito detalhado sobre seu software
    /// Essas permissões são combinadas para criar uma função, que será mais voltada para o ser humano
    /// </summary>
    public enum Permissions : ushort // Deve ser ushort para funcionar com o AuthP
    {
        NotSet = 0, // condição de erro

        // Aqui está um exemplo de controle detalhado sobre algum recurso

        [Display(GroupName = "Estoque", Name = "Read", Description = "Pode ler estoque")]
        StockRead = 10,
        [Display(GroupName = "Estoque", Name = "Add new", Description = "Pode adicionar um novo item de estoque")]
        StockAddNew = 13,
        [Display(GroupName = "Estoque", Name = "Remove", Description = "Pode remover o estoque")]
        StockRemove = 14,

        [Display(GroupName = "Vendas", Name = "Read", Description = "Pode ler qualquer venda")]
        SalesRead = 20,
        [Display(GroupName = "Vendas", Name = "Sell", Description = "Pode vender itens do estoque")]
        SalesSell = 21,
        [Display(GroupName = "Vendas", Name = "Return", Description = "Pode devolver um item ao estoque")]
        SalesReturn = 22,

        [Display(GroupName = "Funcionarios", Name = "Read", Description = "Pode ler os funcionários da empresa")]
        EmployeeRead = 30,

        //----------------------------------------------------
        // Este é um exemplo do que fazer com uma permissão que não é mais usada.
        // Você não quer que seu número seja reutilizado, pois isso pode causar problemas 
        // Basta marcá-la como obsoleta e o código PermissionDisplay não a mostrará

        [Obsolete]
        [Display(GroupName = "Old", Name = "Not used", Description = "example of old permission")]
        OldPermissionNotUsed = 1_000,

        //----------------------------------------------------
        // Um membro do enum sem <see cref="DisplayAttribute"/> pode ser usado, mas não é mostrado no PermissionDisplay de forma alguma
        // Útil se estiver trabalhando em novas permissões, mas não quiser que elas sejam usadas por ninguém ainda 
        AnotherPermission = 2_000,

        //----------------------------------------------------
        // Seção de administração

        //40_000 - Usuário administrador
        [Display(GroupName = "UserAdmin", Name = "Read users", Description = "Pode listar usuários")]
        UserRead = 40_000,
        [Display(GroupName = "UserAdmin", Name = "Sync users", Description = "Sincroniza o provedor de autorização com o AuthUsers")]
        UserSync = 40_001,
        [Display(GroupName = "UserAdmin", Name = "Alter users", Description = "Pode acessar a alteração de usuário")]
        UserChange = 40_002,
        [Display(GroupName = "UserAdmin", Name = "Alter user's roles", Description = "Pode adicionar / remover funções de um usuário")]
        UserRolesChange = 40_003,
        [Display(GroupName = "UserAdmin", Name = "Move a user to another tenant", Description = "Podem controlar o locatário em que estão")]
        UserChangeTenant = 40_004,
        [Display(GroupName = "UserAdmin", Name = "Remove user", Description = "Pode excluir o usuário")]
        UserRemove = 40_005,

        //41_000 - Roles admin
        [Display(GroupName = "RolesAdmin", Name = "Read Roles", Description = "Pode listar Função")]
        RoleRead = 41_000,
        //This is an example of grouping multiple actions under one permission
        [Display(GroupName = "RolesAdmin", Name = "Change Role", Description = "Pode criar, atualizar ou excluir uma função", AutoGenerateFilter = true)]
        RoleChange = 41_001,

        //41_100 - Permissions 
        [Display(GroupName = "RolesAdmin", Name = "See permissions", Description = "Pode exibir a lista de permissões", AutoGenerateFilter = true)]
        PermissionRead = 41_100,
        [Display(GroupName = "RolesAdmin", Name = "See all permissions", Description = "incluirá a lista Permission filtrada ", AutoGenerateFilter = true)]
        IncludeFilteredPermissions = 41_101,

        //42_000 - tenant admin
        [Display(GroupName = "TenantAdmin", Name = "Read Tenants", Description = "Pode listar locatários")]
        TenantList = 42_000,
        [Display(GroupName = "TenantAdmin", Name = "Create new Tenant", Description = "Pode criar novos locatários", AutoGenerateFilter = true)]
        TenantCreate = 42_001,
        [Display(GroupName = "TenantAdmin", Name = "Alter Tenants info", Description = "Pode atualizar o nome do locatário", AutoGenerateFilter = true)]
        TenantUpdate = 42_002,
        [Display(GroupName = "TenantAdmin", Name = "Move tenant to another parent", Description = "Pode mover o locatário para outro pai ( ADVERTÊNCIA)", AutoGenerateFilter = true)]
        TenantMove = 42_003,
        [Display(GroupName = "TenantAdmin", Name = "Delete tenant", Description = "Pode excluir o locatário (ADVERTÊNCIA)", AutoGenerateFilter = true)]
        TenantDelete = 42_004,

        //43_000
        [Display(GroupName = "AppStatus", Name = "list active app statues", Description = "Pode listar status ativos", AutoGenerateFilter = true)]
        AppStatusList = 43_000,
        [Display(GroupName = "AppStatus", Name = "Stop all users accessing app", Description = "Interromper todos os usuários, exceto o usuário que definiu isso", AutoGenerateFilter = true)]
        AppStatusAllDown = 43_002,
        [Display(GroupName = "AppStatus", Name = "Stop users linked to specific tenant", Description = "Interromper usuários vinculados a um locatário específico", AutoGenerateFilter = true)]
        AppStatusTenantDown = 43_003,
        [Display(GroupName = "AppStatus", Name = "Remove an active app statue", Description = "Pode desativar qualquer status ativo", AutoGenerateFilter = true)]
        AppStatusRemove = 43_005,


        // Definir o AutoGenerateFilter como true na exibição permite excluir essas permissões
        // para usuários administradores que não têm permissão para alterar essas permissões
        // Útil na primeira configuração de um aplicativo

        [Display(GroupName = "SuperAdmin", Name = "AccessAll", 
            Description = "Isso permite que o usuário acesse todos os recursos", AutoGenerateFilter = true)]
        AccessAll = ushort.MaxValue,
    }
}