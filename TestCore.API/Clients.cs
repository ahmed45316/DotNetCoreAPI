using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace TestCore.API
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client> {
            new Client {
               ClientId = "openIdConnectClient",
               ClientName = "Example Implicit Client Application",
               AllowedGrantTypes = GrantTypes.Implicit,
               AllowedScopes = new List<string>
                             {
                              IdentityServerConstants.StandardScopes.OpenId,
                              IdentityServerConstants.StandardScopes.Profile,
                              IdentityServerConstants.StandardScopes.Email,
                                   "role",
                                   "customAPI.write"
                             },
                         //RedirectUris = new List<string> {"https://localhost:44330/signin-oidc"},
                         RedirectUris = new List<string> {"http://localhost:50648/signin-oidc"},
                         //PostLogoutRedirectUris = new List<string> {"https://localhost:44330"}
                          PostLogoutRedirectUris = new List<string> { "http://localhost:50648" }
                       }    
            };
        }
    }
}

