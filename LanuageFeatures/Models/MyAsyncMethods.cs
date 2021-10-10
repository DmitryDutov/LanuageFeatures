using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanuageFeatures.Models
{
    public class MyAsyncMethods
    {
        //Асинхронный метод без ключевых слов async и await
        public static Task<long?> GetPageLenght()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://apres.com");

            return httpTask.ContinueWith((Task<HttpResponseMessage> antecednt)
                =>
            { return antecednt.Result.Content.Headers.ContentLength; });
        }
    }
}

