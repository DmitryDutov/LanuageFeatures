using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanuageFeatures.Models
{
    public class MyAsyncMethods
    {
        //Асинхронный метод с использованием ключевых слов async и await
        public async static Task<long?> GetPageLenght()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apres.com");

            return httpMessage.Content.Headers.ContentLength;
        }
    }
}

