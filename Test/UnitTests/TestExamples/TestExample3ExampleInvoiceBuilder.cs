﻿// Copyright (c) 2023 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using Saas.InvoiceCode.AppStart;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Test.UnitTests.TestExamples
{
    public class TestSaasExampleInvoiceBuilder
    {
        private readonly ITestOutputHelper _output;

        public TestSaasExampleInvoiceBuilder(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(ExampleInvoiceTypes.Computer, 3)]
        [InlineData(ExampleInvoiceTypes.Office, 4)]
        [InlineData(ExampleInvoiceTypes.Travel, 7)]
        public void TestCreateExampleInvoice(ExampleInvoiceTypes type, int numItems)
        {
            //SETUP
            var builder = new ExampleInvoiceBuilder(".");

            //ATTEMPT
            var invoice = builder.CreateExampleInvoice(type, type.ToString(), "Company");

            //VERIFY
            invoice.LineItems.Count.ShouldEqual(numItems);
        }

        [Fact]
        public void TestCreateRandomInvoice()
        {
            //SETUP
            var builder = new ExampleInvoiceBuilder(".");

            //ATTEMPT
            var invoice = builder.CreateRandomInvoice("Company");

            //VERIFY
            invoice.LineItems.Count.ShouldBeInRange(3,7);
        }
    }
}