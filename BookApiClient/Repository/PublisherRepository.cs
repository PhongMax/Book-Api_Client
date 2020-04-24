using BookApiClient.Models;
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

      
      
        // receive message 
        public string _responseMessage { get; private set; }

        public async Task<bool> DeletePublisherAsync(int publisherId)
        {
            HttpClient client = HttpClients.GetInstance();
           
            HttpResponseMessage response = await client.DeleteAsync("publishers/delete/" + publisherId);
            if (!response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                _responseMessage = message;
                return false;
            }
            return true;
        }


        public async Task<bool> AddNewPublisherAsync(Models.Publisher publisher)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PostAsJsonAsync("publishers/create", publisher);
            if (!response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                _responseMessage = message;
                return false; ;
            }
            return true;
        }



        public async Task<Models.Publisher> GetPublishertAsync(string publisherId)
        {
            HttpClient client = HttpClients.GetInstance();
            Models.Publisher publisher = null;
            HttpResponseMessage response = await client.GetAsync("publishers / getbyid /" + publisherId);
            if (response.IsSuccessStatusCode)
            {
                publisher = await response.Content.ReadAsAsync<Models.Publisher>();
            }else
            {
                string message = await response.Content.ReadAsStringAsync();
                _responseMessage = message;
            }
            return publisher;
        }


        public async Task<List<Models.Publisher>> GetAllPublihersAsync()
        {
            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.GetAsync("product/getallproducts");
            List<Models.Publisher> publiserArr = null;
            if (response.IsSuccessStatusCode)
            {
                 publiserArr = await response.Content.ReadAsAsync<List<Models.Publisher>>();
            }
            else
            {
                string message = await response.Content.ReadAsStringAsync();
                _responseMessage = message;
            }

            return publiserArr;
        }



        public async Task<bool> EditProductAsync(Models.Publisher publisher)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PutAsJsonAsync("publishers/update/", publisher);
            if (!response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                _responseMessage = message;
                return false; ;
            }
            return true;
        }

    }
}
