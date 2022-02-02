using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleTables;
using Newtonsoft.Json;

namespace HttpClientJsonGet
{
    class Model
    {
        public int userId { get; set; } 
        public int id   { get; set; }
        public string title  { get; set; }
        public string body { get; set; }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient httpClient=new HttpClient();
            HttpResponseMessage httpResponseMessage=await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
            httpResponseMessage.EnsureSuccessStatusCode();
            string responseBody=await httpResponseMessage.Content.ReadAsStringAsync();
            var result=JsonConvert.DeserializeObject<List<Model>>(responseBody); 
            var table=new ConsoleTable("User id","id");

            foreach (var item in result){
                table.AddRow(item.userId,item.id);
            }
            table.Write();
            {
                
            }
        }
    }
}
