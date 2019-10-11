using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace LWT.Magneefire.Authentication.Configuration
{
    public static class Config
    {
        internal static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("Try2", "Magneefire Application api")
            };
        }

        internal static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "new client 2",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("sldkjfljsdlkflksdj".Sha256())
                    },
                    AllowedScopes = { "Try2" },
                    AccessTokenLifetime = 100
                }
            };

        }
    }
}
