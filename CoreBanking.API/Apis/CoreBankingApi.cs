﻿using CoreBanking.API.Models;
using CoreBanking.API.Services;

namespace CoreBanking.API.Apis
{
    public static class CoreBankingApi
    {
        public static IEndpointRouteBuilder MapCoreBankingApi(this IEndpointRouteBuilder builder)
        {
            var vApi = builder.NewVersionedApi("CoreBanking");
            var v1 = vApi.MapGroup("/api/v{version:apiVersion}/corebanking").HasApiVersion(1, 0);
            v1.MapGet("/customer", GetCustomers);
            v1.MapPost("/customer", CreateCustomers);
            v1.MapGet("/accounts", GetAccounts);
            v1.MapPost("/accounts", CreateAccounts);
            v1.MapPut("/accounts/{id:guid}/deposit", Deposit);
            v1.MapPut("/accounts/{id:guid}/withdraw", Withdraw);
            v1.MapPut("/accounts/{id:guid}/transfer", Transfer);

            //builder.MapGet("/api/v1/corebanking/customer", GetCustomers);
            //builder.MapPost("/api/v1/corebanking/customer", CreateCustomers);

            return builder;
        }

        private static async Task Transfer(Guid id)
        {
            throw new NotImplementedException();
        }

        private static async Task Withdraw(Guid id)
        {
            throw new NotImplementedException();
        }

        private static async Task Deposit(Guid id)
        {
            throw new NotImplementedException();
        }

        private static async Task CreateAccounts(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task GetAccounts(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task CreateCustomers(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task GetCustomers(
            [AsParameters] CoreBankingServices services,
            [AsParameters] PaginationRequest pagination 
            )
        {
            throw new NotImplementedException();
        }
    }
}
