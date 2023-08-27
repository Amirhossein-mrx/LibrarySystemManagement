using LibraryManagementWebApi.Model.Context;
using LibraryManagementWebApi.Model.ViewModel;
using LibraryManagementWebApi.Repository;
using LibraryManagementWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
         ILibrary _LibraryService;
      
        public LibraryController()
        {
            _LibraryService = new LibraryService();
        }


        [HttpGet("GetBookDetails")]
        public IActionResult GetBookDetails()
        {
            var Books = _LibraryService.GetListOfBookWithDetails();
            return Ok(Books);
        }

        [HttpGet("GetAuthers")]
        public IActionResult GetAuthers()
        {
            var Authers = _LibraryService.GetListOfAuthor();
            return Ok(Authers);
        }

        [HttpGet("GetBorrowerAndHistory")]
        public IActionResult GetBorrowerAndHistory()
        {
            var borrower = _LibraryService.GetListOfborrowersAndborrowinghistory();
            return Ok(borrower);
        }

        [HttpPost("AddNewBook")]
        public IActionResult AddNewBook(AddnewBookViewModel book)
        {
            var borrower = _LibraryService.AddNewBook(book.bookName, book.genre,book.AutherId,book.publisherId);
            if (borrower)
            {
                return Ok("Done");
            }
            else
            {
                return Ok("fail");
            }
        }

        [HttpPost("DeliverBook")]
        public IActionResult DeliverBook(DelvOrRetBookViewModel book)
        {
            var borrower = _LibraryService.DeliverBook(book.BorrowId, book.BookId);
            if (borrower)
            {
                return Ok("Done");
            }
            else
            {
                return Ok("fail");
            }
        }

        [HttpPost("ReturnBook")]
        public IActionResult ReturnBook(DelvOrRetBookViewModel book)
        {
            var borrower = _LibraryService.ReturnBook(book.BorrowId, book.BookId);
            if (borrower)
            {
                return Ok("Done");
            }
            else
            {
                return BadRequest();
            }
        }

        //Advance Queries

        [HttpPost("bookswithspecificgenre")]
        public IActionResult bookswithspecificgenre(GenreViewModel genre)
        {
            var book = _LibraryService.GetBooksWithGenre(genre.Genre);
         
            return Ok(book);
        }

        [HttpPost("bookswithspecificborrow")]
        public IActionResult bookswithspecificborrow(bookSpecificBorrowViewModel borrower)
        {
            var book = _LibraryService.GetBooksWithBorrower(borrower.BorrowId);

            return Ok(book);
        }

        [HttpGet("AuthorCountBook")]
        public IActionResult AuthorCountBook()
        {
            var book = _LibraryService.GetCountOfBooks();

            return Ok(book);
        }

        [HttpGet("BorrowCountBook")]
        public IActionResult BorrowCountBook()
        {
            var book = _LibraryService.GetListOfBorrowCount();
            //var a = book.Max(x => x.BookCount);
            return Ok(book);
        }

        [HttpGet("ReturnBookWithbooknameOrAutherName")]
        public IActionResult ReturnBookWithbooknameOrAutherName(string name)
        {
            var book = _LibraryService.ReturnBookWithbooknameOrAutherName(name);
            //var a = book.Max(x => x.BookCount);
            return Ok(book);
        }

        [HttpGet("GetAllBorrowers")]
        public IActionResult GetAllBorrowers()
        {
            var book = _LibraryService.GetBorrowers();
            //var a = book.Max(x => x.BookCount);
            return Ok(book);
        }



    }
}
