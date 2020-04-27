using BookApiClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookApiClient
{
    class PublisherRepository
    {

        public async Task<System.Net.HttpStatusCode> DeletePublisherAsync(int publisherId)
        {
            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.DeleteAsync("publishers/delete/" + publisherId);
            return response.StatusCode;     
        }


        public async Task<bool> AddNewPublisherAsync(Models.Publisher publisher)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PostAsJsonAsync("publishers/create", publisher);
            if (!response.IsSuccessStatusCode)
            {
                return false; ;
            }
            return true;
        }



        public async Task<Models.Publisher> GetPublisherAsync(int publisherId)
        {
            HttpClient client = HttpClients.GetInstance();
            Models.Publisher publisher = null;
            HttpResponseMessage response = await client.GetAsync("publishers/getbyid/" + publisherId);
            if (response.IsSuccessStatusCode)
            {
                publisher = await response.Content.ReadAsAsync<Models.Publisher>();
            }
            return publisher;
        }


        public async Task<List<Models.Publisher>> GetAllPublihersAsync()
        {
            HttpClient client = HttpClients.GetInstance();

            HttpResponseMessage response = await client.GetAsync("publishers/getall");
            List<Models.Publisher> listPublisher = null;
            if (response.IsSuccessStatusCode)
            {
                listPublisher = await response.Content.ReadAsAsync<List<Models.Publisher>>();

            }

            return listPublisher;
        }

        public async Task<bool> EditProductAsync(Models.Publisher publisher)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PutAsJsonAsync("publishers/update/", publisher);
            if (!response.IsSuccessStatusCode)
            {
             
                return false; ;
            }
            return true;
        }

    }
}
