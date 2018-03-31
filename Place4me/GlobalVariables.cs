using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Place4me
{
    public static class GlobalVariables
    {
        public static HttpClient Place4meWebAPIClient = new HttpClient();

        static GlobalVariables()
        {
            //Place4meWebAPIClient.BaseAddress = new Uri("http://localhost:3284/api/");
            Place4meWebAPIClient.BaseAddress = new Uri("http://place4meapi.somee.com/api/");
            Place4meWebAPIClient.DefaultRequestHeaders.Clear();
            Place4meWebAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}