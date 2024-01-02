// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using AuthPermissions.BaseCode.SetupCode;

namespace Facil.Infra.IOC.PermissionsCode
{
    public static class AppAuthSetupData
    {

        public static readonly List<BulkLoadRolesDto> RolesDefinition = new List<BulkLoadRolesDto>()
        {
            new("SuperAdmin", "Superadministrador - use apenas para configuração", "AccessAll"),
            new("App Admin", "Administrador geral do aplicativo",
                "UserRead, UserSync, UserChange, UserRolesChange, UserChangeTenant, UserRemove, " +
                "RoleRead, RoleChange, PermissionRead, IncludeFilteredPermissions, " +
                "TenantList, TenantCreate, TenantUpdate, TenantMove, TenantDelete, " +
                "AppStatusList, AppStatusAllDown, AppStatusTenantDown, AppStatusRemove"),
            new("Tenant Admin", "Administração em nível de locatário", "EmployeeRead, UserRead, UserRolesChange, RoleRead"),
            new("Tenant Director", "CEO da empresa, pode ver estoque/vendas e funcionários", "EmployeeRead, StockRead, SalesRead"),
            new("Area Manager", "Gerente de área - verificar estoque e vendas", "StockRead, SalesRead"),
            new("Store Manager", "Gerente de vendas da loja - acesso total", "StockRead, StockAddNew, StockRemove, SalesRead, SalesSell, SalesReturn"),
            new("Sales Assistant", "Assistente de vendas da loja - apenas vende", "StockRead, SalesSell"),
        };

        public static readonly List<BulkLoadTenantDto> TenantDefinition = new List<BulkLoadTenantDto>()
        {
            new("4U Ltda.", null, new BulkLoadTenantDto[]
            {
                new ("Suldeste", null, new BulkLoadTenantDto[]
                {
                    new ("São Paulo", null, new BulkLoadTenantDto[]
                    {
                        new ("Dress4U"),
                        new ("Tie4U")
                    }),
                    new ("Rio de Janeiro", null, new BulkLoadTenantDto[]
                    {
                        new ("Shirt4U"),
                    })
                }),
                new ("Sul", null, new BulkLoadTenantDto[]
                {
                    new ("Curitiba Dress4U"),
                    new ("Porto Alegre Shirt4U"),
                })
            }),
            new("Pets2 Ltd.", null, new BulkLoadTenantDto[]
            {
                new ("Curitiba-PR", null, new BulkLoadTenantDto[]
                {
                    new ("Cats Pets"),
                    new ("Kitten Pets")
                }),
            })
        };

        public static readonly List<BulkLoadUserWithRolesTenant> UsersRolesDefinition = new List<BulkLoadUserWithRolesTenant>
        {
            new ("Super@g1.com", null, "SuperAdmin"),
            new ("AppAdmin@g1.com", null, "App Admin"),
            //4U Ltda.
            new ("admin@4uInc.com", null,
                "Tenant Admin, Area Manager", tenantNameForDataKey: "4U Ltda."),
            new ("director@4uInc.com", null,
                "Tenant Director, Area Manager", tenantNameForDataKey: "4U Ltda."),
            new ("westCoastManager@4uInc.com", null,
                "Area Manager", tenantNameForDataKey: "4U Ltda. | Suldeste"),
            new ("eastCoastManager@4uInc.com", null,
                "Area Manager", tenantNameForDataKey: "4U Ltda. | Sul"),
            //Dress4U
            new ("Dress4UManager@4uInc.com", null,
                "Store Manager", tenantNameForDataKey: "4U Ltda. | Suldeste | São Paulo | Dress4U"),
            new ("Dress4USales@4uInc.com", null,
                "Sales Assistant", tenantNameForDataKey: "4U Ltda. | Suldeste | São Paulo | Dress4U"),
            //Tie4U
            new ("Tie4UManager@4uInc.com", null,
                "Store Manager", tenantNameForDataKey: "4U Ltda. | Suldeste | São Paulo | Tie4U"),
            new ("Tie4USales@4uInc.com", null,
                "Sales Assistant", tenantNameForDataKey: "4U Ltda. | Suldeste | São Paulo | Tie4U"),
            //Shirt4U
            new ("Shirt4UManager@4uInc.com", null,
                "Store Manager", tenantNameForDataKey: "4U Ltda. | Suldeste | Rio Janeiro | Shirt4U"),
            new ("Shirt4USales@4uInc.com", null,
                "Sales Assistant", tenantNameForDataKey: "4U Ltda. | Suldeste | Rio Janeiro | Shirt4U"),

            //Pets2 Ltd.
            new ("admin@Pets2.com", null,
                "Tenant Admin, Area Manager", tenantNameForDataKey: "Pets2 Ltd."),
            new ("director@Pets2.com", null,
                "Tenant Director, Area Manager", tenantNameForDataKey: "Pets2 Ltd."),
            //Dress4U
            new ("CatsManager@Pets2.com", null,
                "Store Manager", tenantNameForDataKey: "Pets2 Ltd. | Curitiba | Cats Pets"),
            new ("CatsSales@Pets2.com", null,
                "Sales Assistant", tenantNameForDataKey: "Pets2 Ltd. | Curitiba | Cats Pets"),
            //Tie4U
            new ("KittenManager@Pets2.com", null,
                "Store Manager", tenantNameForDataKey: "Pets2 Ltd. | Curitiba | Kitten Pets"),
            new ("KittenSales@Pets2.com", null,
                "Sales Assistant", tenantNameForDataKey: "Pets2 Ltd. | Curitiba | Kitten Pets"),
        };
    }
}