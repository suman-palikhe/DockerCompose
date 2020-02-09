using InfoTrack.Net.Http;
using System;

namespace PrivateRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new HttpClient("http://spalikhe.com");
            var resp = a.GetAsync("").GetAwaiter().GetResult();


            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(resp));
        }
    }
}
