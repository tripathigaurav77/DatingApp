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

        public static int GetUserId(this ClaimsPrincipal user)
        {
            //From Token service getting the claims
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}