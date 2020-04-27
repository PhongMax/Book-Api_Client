using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookApiClient.Repository
{
    class AuthorRepository
    {

        public async Task<System.Net.HttpStatusCode> DeleteAuthorAsync(int authorId)
        {
            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.DeleteAsync("authors/delete/" + authorId);
            return response.StatusCode;
        }


        public async Task<bool> AddNewAuthorAsync(Models.Author author)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PostAsJsonAsync("authors/create", author);
            if (!response.IsSuccessStatusCode)
            {
                return false; ;
            }
            return true;
        }



        public async Task<Models.Author> GetAuthorAsync(int authorId)
        {
            HttpClient client = HttpClients.GetInstance();
            Models.Author author = null;
            HttpResponseMessage response = await client.GetAsync("authors/getbyid/" + authorId);
            if (response.IsSuccessStatusCode)   
            {
                author = await response.Content.ReadAsAsync<Models.Author>();
            }
            return author;
        }


        public async Task<List<Models.Author>> GetAllPublihersAsync()
        {
            HttpClient client = HttpClients.GetInstance();

            HttpResponseMessage response = await client.GetAsync("authors/getall");
            List<Models.Author> listAuthor = null;
            if (response.IsSuccessStatusCode)
            {
                listAuthor = await response.Content.ReadAsAsync<List<Models.Author>>();

            }

            return listAuthor;
        }

        public async Task<bool> EditAuthorAsync(Models.Author author)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PutAsJsonAsync("authors/update/", author);
            if (!response.IsSuccessStatusCode)
            {

                return false; ;
            }
            return true;
        }

    }
}
