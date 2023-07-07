using System.Security.Claims;

namespace API.Extensions
{
  public static class ClaimsPrincipalExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            //From Token service getting the claims
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static string GetUserId(this ClaimsPrincipal user)
        {
            //From Token service getting the claims
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}