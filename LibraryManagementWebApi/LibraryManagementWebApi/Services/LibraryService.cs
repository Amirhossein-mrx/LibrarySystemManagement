using LibraryManagementWebApi.Model.Context;
using LibraryManagementWebApi.Model.Entity;
using LibraryManagementWebApi.Model.ViewModel;
using LibraryManagementWebApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Services
{
    public class LibraryService : ILibrary
    {
        private readonly LibraryDbContext _libraryDbContext;

        public LibraryService()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool AddNewBook(string name, string genre, int authorId, int publisherId)
        {

            var newbook = new Book
            {
                BookName = name,
                AuthorId = authorId,
                Genre = genre
            };

            try
            {

                _libraryDbContext.Books.Add(newbook);
                _libraryDbContext.SaveChanges();
                var newbook1 = _libraryDbContext.Books.Where(x => x.BookName == name).ToList();
                                   
                var newbook2 = new BookInPublisher
                {
                    BookId = newbook1[0].Id,
                    PublisherId = publisherId
                };


                _libraryDbContext.BookInPublishers.Add(newbook2);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool DeliverBook(int borrowId, int bookId)
        {
            var neew = new BorrowingHistory
            {
                BookId = bookId,
                BorrowId = borrowId,
                DeliveryDate = DateTime.Now,
                ReturnDate = null
            };
            try
            {
                _libraryDbContext.BorrowingHistorys.Add(neew);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<BookNameViewModel> GetBooksWithBorrower(int borrowId)
        {

            var borrowbooks = _libraryDbContext.BorrowingHistorys.Where(x => x.BorrowId == borrowId)
                .Select(x => new BookNameViewModel
                {
                    BookName = x.Books.BookName
                })
                .ToList();

            return borrowbooks;
        }

        public List<BookNameViewModel> GetBooksWithGenre(string genre)
        {
            var books = _libraryDbContext.Books.Where(x => x.Genre.Contains(genre))
                .Select(x => new BookNameViewModel
                {
                    BookName = x.BookName
                })
                .ToList();
            return books;
        }

        public List<AuthorCountBookViewModel> GetCountOfBooks()
        {
            var authors1 = _libraryDbContext.Books
                .Select(x => new AuthorCountBookViewModel
                {
                    AuthorName = x.authors.AuthorName,
                    BookCount = x.authors.Books.Count()
                }).Distinct().ToList();


            return authors1;

        }

        public List<AuthorViewModel> GetListOfAuthor()
        {
            var author = _libraryDbContext.Authors
               .Select(x => new AuthorViewModel
               {
                   Id = x.Id,
                   authorName = x.AuthorName

               }).ToList();
            return author;
        }

        public List<BookDetailsViewModel> GetListOfBookWithDetails()
        {
            var detailBook = _libraryDbContext.BookInPublishers
                .Select(x => new BookDetailsViewModel
                {
                    BookId=x.BookId,
                    BookName = x.Books.BookName,
                    AuthorName = x.Books.authors.AuthorName,
                    PublisherName = x.Publishers.PublisherName,
                    Genre = x.Books.Genre

                }).ToList();

            return detailBook;
        }

        public List<BorrowCountBookViewModel> GetListOfBorrowCount()
        {
            var borrow = _libraryDbContext.BorrowingHistorys
             .Select(x => new BorrowCountBookViewModel
             {
                 BorrowName = x.Borrows.UserName,
                 BookCount = x.Borrows.borrowinghistory.Count()
             }).Distinct().ToList();
            //var a = borrow.Select(x=>x.BookCount);
            return borrow;
        }

        public List<BorrowersAndBorrwingHiostory> GetListOfborrowersAndborrowinghistory()
        {
            var borrower = _libraryDbContext.BorrowingHistorys
                .Select(x => new BorrowersAndBorrwingHiostory
                {
                    BorrwerName = x.Borrows.UserName,
                    BookName = x.Books.BookName,
                    DeliveryDate = x.DeliveryDate.ToString(),
                    ReturnDate = x.ReturnDate.ToString()
                }).ToList();
            return borrower;
        }

        public bool ReturnBook(int borrowId, int bookId)
        {
            try
            {
                var returnbook = _libraryDbContext.BorrowingHistorys.FirstOrDefault(x => x.BorrowId == borrowId && x.BookId == bookId);
                if (returnbook == null)
                {
                    throw new NotImplementedException();
                }
                returnbook.ReturnDate = DateTime.Now;
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<BookNameViewModel> ReturnBookWithbooknameOrAutherName(string name)
        {
            try
            {
                var returnbook = _libraryDbContext.Books.Where(x => x.BookName.Contains(name) || x.authors.AuthorName.Contains(name))
                    .Select(x=>new BookNameViewModel
                    {
                        BookName=x.BookName,
                    }) .ToList();
                return returnbook;
             
            }
            catch (Exception ex)
            {

                return new List<BookNameViewModel>();
            }
        }

        public List<BorrowerViewModel> GetBorrowers()
        {
            try
            {
                var borrowers = _libraryDbContext.Borrows
                    .Select(x=>new BorrowerViewModel
                    {
                        Id=x.Id,
                        BorrowerName=x.UserName,
                    })
                    .ToList();
                   
                return borrowers;

            }
            catch (Exception ex)
            {

                return new List<BorrowerViewModel>();
            }
        }

     
    }
}
