using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ApiDesktopClient.Models;
using Newtonsoft.Json;

namespace ApiDesktopClient.Services
{
    public class GenericService<T> where T: class
    {
        private string URL;

        public GenericService(string url)
        {
            URL = url;
        }

        public async Task<List<T>> GetAll()
        {

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(URL).Result;  //doesn`t work with await, and don`t ask me why
                string responseBody = await response.Content.ReadAsStringAsync();
                IEnumerable<T> items = JsonConvert.DeserializeObject<IEnumerable<T>>(responseBody);
                return items.ToList();
            }

        }

        public async Task Add(T item)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(URL, content);
            }

        }

        public async Task Update(int id, T item)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                var response = await client.PutAsync(URL + id.ToString(), content);

            }
        }

        public async Task Delete(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(URL + id.ToString());
            }
        }
    }
}
