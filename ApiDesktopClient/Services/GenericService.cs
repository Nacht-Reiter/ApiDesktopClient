using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<T>> GetAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                IEnumerable<T> items = JsonConvert.DeserializeObject<IEnumerable<T>>(responseBody);
                return items;
            }
        }

        public async Task Add(T item)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(item));
                await client.PostAsync(URL, content);
            }

        }

        public async Task Update(int id, T item)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(item));
                await client.PutAsync(URL + id.ToString(), content);
            }
        }

        public async Task Delete(int id)
        {
            using (var client = new HttpClient())
            {
                await client.DeleteAsync(URL + id.ToString());
            }
        }
    }
}
