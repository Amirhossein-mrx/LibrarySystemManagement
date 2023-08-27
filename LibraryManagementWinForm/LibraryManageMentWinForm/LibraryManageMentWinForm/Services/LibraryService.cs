using LibraryManageMentWinForm.Model;
using LibraryManageMentWinForm.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageMentWinForm.Services
{

    public class LibraryService : ILibrary
    {
        string Connection = "http://localhost:2692/api";



        //public List<Author> GetListOfAutors()
        //{
        //    List<Author> author = new List<Author>();
        //    try
        //    {
        //        string Url_SelectAll = Connection + "/Cours/getAll";
        //        using (HttpClient Client = new HttpClient())
        //        {
        //            var Result = Client.GetStringAsync(Url_SelectAll).Result;

        //            author = JsonConvert.DeserializeObject<List<Author>>(Result);
        //            return author;
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        return author;
        //    }
        //}

        public List<BookDetails> GetListOfBook()
        {
            List<BookDetails> book = new List<BookDetails>();
            try
            {
                string Url_SelectAll = Connection + "/Library/GetBookDetails";
                using (HttpClient Client = new HttpClient())
                {
                    var Result = Client.GetStringAsync(Url_SelectAll).Result;

                    book = JsonConvert.DeserializeObject<List<BookDetails>>(Result);
                    return book;
                }

            }
            catch (Exception)
            {
                return book;
            }
        }
        public List<Borrower> GetListOfBorrowwres()
        {
            List<Borrower> brrower = new List<Borrower>();
            try
            {
                string Url_SelectAll = Connection + "/Library/GetAllBorrowers";
                using (HttpClient Client = new HttpClient())
                {
                    var Result = Client.GetStringAsync(Url_SelectAll).Result;

                    brrower = JsonConvert.DeserializeObject<List<Borrower>>(Result);
                    return brrower;
                }

            }
            catch (Exception)
            {
                return brrower;
            }
        }

        public bool BorrowBook(BorrowBook bookborrow)
        {
            string Url_SelectAll = Connection + "/Library/DeliverBook";
            try
            {
                using (HttpClient Client = new HttpClient())
                {

                    string jsonString = JsonConvert.SerializeObject(bookborrow);


                    using (HttpContent httpContent = new StringContent(jsonString))
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        HttpResponseMessage response = Client.PostAsync(Url_SelectAll, httpContent).Result;
                    }

                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ReturnBorrowBook(BorrowBook bookborrow)
        {
            string Url_SelectAll = Connection + "/Library/ReturnBook";
            try
            {

                using (HttpClient Client = new HttpClient())
                {
                    string jsonString = JsonConvert.SerializeObject(bookborrow);

                    using (HttpContent httpContent = new StringContent(jsonString))
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        HttpResponseMessage response = Client.PostAsync(Url_SelectAll, httpContent).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<BookDetails> SearchBook(string word)
        {
            string Url_SelectAll = Connection + "/Library/ReturnBookWithbooknameOrAutherName?name="+word;
            List<BookDetails> book = new List<BookDetails>();
            List<BookDetails> book1 = new List<BookDetails>();


            try
            {
                using (HttpClient Client = new HttpClient())
                {
                    var Result = Client.GetStringAsync(Url_SelectAll).Result;

                    book = JsonConvert.DeserializeObject<List<BookDetails>>(Result);

                    //book1 = book.Where(x => x.AuthorName.Contains(word) || x.BookName.Contains(word)).ToList();
                    return book;
                }

            }
            catch (Exception)
            {
                return book;
            }
        }

        public List<BookDetails> SearchWithGenre(string genre)
        {
            var books = GetListOfBook();
            var book1 = books.Where(x => x.Genre == genre).ToList();
            return book1;
        }


    }
}
