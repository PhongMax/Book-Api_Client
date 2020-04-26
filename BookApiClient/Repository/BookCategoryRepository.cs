using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookApiClient.Repository
{
    class BookCategoryRepository
    {
        public async Task<System.Net.HttpStatusCode> DeleteBookCategoryAsync(int BookCategoryID)
        {
            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.DeleteAsync("bookcategories/delete/" + BookCategoryID);
            return response.StatusCode;
        }


        public async Task<bool> AddNewBookCategoryAsync(Models.BookCategory BookCategory)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PostAsJsonAsync("bookcategories/create", BookCategory);
            if (!response.IsSuccessStatusCode)
            {
                return false; ;
            }
            return true;
        }



        public async Task<Models.BookCategory> GetBookCategoryAsync(int BookCategoryID)
        {
            HttpClient client = HttpClients.GetInstance();
            Models.BookCategory bookCategory = null;
            HttpResponseMessage response = await client.GetAsync("bookcategories/getbyid/" + BookCategoryID);
            if (response.IsSuccessStatusCode)
            {
                bookCategory = await response.Content.ReadAsAsync<Models.BookCategory>();
            }
            return bookCategory;
        }


        public async Task<List<Models.BookCategory>> GetAllBookCategoryAsync()
        {
            HttpClient client = HttpClients.GetInstance();

            HttpResponseMessage response = await client.GetAsync("bookcategories/getall");
            List<Models.BookCategory> listBookCategory = null;
            if (response.IsSuccessStatusCode)
            {
                listBookCategory = await response.Content.ReadAsAsync<List<Models.BookCategory>>();

            }

            return listBookCategory;
        }

        public async Task<bool> EditBookCategoryAsync(Models.BookCategory BookCategory)
        {

            HttpClient client = HttpClients.GetInstance();
            HttpResponseMessage response = await client.PutAsJsonAsync("bookcategories/update", BookCategory);
            if (!response.IsSuccessStatusCode)
            {

                return false; ;
            }
            return true;
        }
    }
}
