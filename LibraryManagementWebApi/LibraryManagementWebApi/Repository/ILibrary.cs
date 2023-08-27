using LibraryManagementWebApi.Model.Entity;
using LibraryManagementWebApi.Model.ViewModel;
using System;
using System.Collections.Generic;

namespace LibraryManagementWebApi.Repository
{
    public interface ILibrary
    {
        List<BookDetailsViewModel> GetListOfBookWithDetails();
        List<AuthorViewModel> GetListOfAuthor();
        List<BorrowersAndBorrwingHiostory> GetListOfborrowersAndborrowinghistory();
        bool DeliverBook(int borrowId, int BookId);
        bool ReturnBook(int borrowId, int BookId);
        bool AddNewBook(string name,string genre, int authorId,int publisherId);


        List<BookNameViewModel> GetBooksWithGenre(string genre);
        List<BookNameViewModel> GetBooksWithBorrower(int borrowId);
        List<AuthorCountBookViewModel> GetCountOfBooks();
        List<BorrowCountBookViewModel> GetListOfBorrowCount();

        List<BookNameViewModel> ReturnBookWithbooknameOrAutherName(string name);
        List<BorrowerViewModel> GetBorrowers();
       

    }
}
