using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookApiClient.Repository
{
    class BookRepository
    {
        public async Task<System.Net.HttpStatusCode> DeleteBookAsync(int bookId)
        {
            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.DeleteAsync("books/delete/" + bookId);
            return response.StatusCode;
        }


        public async Task<bool> AddNewBookAsync(Models.Book book)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PostAsJsonAsync("books/create", book);
            if (!response.IsSuccessStatusCode)
            {
                return false; ;
            }
            return true;
        }



        public async Task<Models.Book> GetBookAsync(int bookId)
        {
            HttpClient client = HttpClients.GetInstance();
            Models.Book book = null;
            HttpResponseMessage response = await client.GetAsync("books/getbyid/" + bookId);
            if (response.IsSuccessStatusCode)
            {
                book = await response.Content.ReadAsAsync<Models.Book>();
            }
            return book;
        }


        public async Task<List<Models.Book>> GetAllBooksAsync()
        {
            HttpClient client = HttpClients.GetInstance();

            HttpResponseMessage response = await client.GetAsync("books/getall");
            List<Models.Book> listBook = null;
            if (response.IsSuccessStatusCode)
            {
                listBook = await response.Content.ReadAsAsync<List<Models.Book>>();

            }

            return listBook;
        }

        public async Task<bool> EditBookAsync(Models.Book book)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PutAsJsonAsync("books/update/", book);
            if (!response.IsSuccessStatusCode)
            {

                return false; ;
            }
            return true;
        }

    }
}

