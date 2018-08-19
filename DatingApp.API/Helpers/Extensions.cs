using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse respone, string message)
        {
            respone.Headers.Add("Application-Error", message);
            respone.Headers.Add("Acces-Control-Expose-Headers", "Application-Error");
            respone.Headers.Add("Acces-Control-Allow-Origin", "*");
        }
    }
}