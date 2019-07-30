using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WhatIsCooking.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        #region " - - - - - - Constructors - - - - - - "

        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        #endregion //Constructors
    }
}
