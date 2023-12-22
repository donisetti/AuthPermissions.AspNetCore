using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AuthPermissions.AspNetCore;
using AuthPermissions.BaseCode.PermissionsCode;
using Saas.InvoiceCode.AppStart;
using Saas.InvoiceCode.Dtos;
using Saas.InvoiceCode.EfCoreClasses;
using Saas.InvoiceCode.EfCoreCode;
using Saas.InvoiceCode.Services;
using Saas.MvcWebApp.IndividualAccounts.PermissionsCode;
using Microsoft.EntityFrameworkCore;

namespace Saas.MvcWebApp.IndividualAccounts.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly InvoicesDbContext _context;

        public InvoiceController(InvoicesDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string message)
        {
            ViewBag.Message = message;

            var listInvoices = User.HasPermission(Permissions.InvoiceRead)
                ? await InvoiceSummaryDto.SelectInvoices(_context.Invoices)
                    .OrderByDescending(x => x.DateCreated)
                    .ToListAsync()
                : null;
            return View(listInvoices);
        }

        [HasPermission(Permissions.InvoiceCreate)]
        public IActionResult CreateInvoice()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [HasPermission(Permissions.InvoiceCreate)]
        public async Task<IActionResult> CreateInvoice(Invoice invoice)
        {
            var builder = new ExampleInvoiceBuilder(null);
            var newInvoice = builder.CreateRandomInvoice(AddTenantNameClaim.GetTenantNameFromUser(User), invoice.InvoiceName);
            _context.Add(newInvoice);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { message = $"Added the invoice '{newInvoice.InvoiceName}'." });
        }

    }
}
