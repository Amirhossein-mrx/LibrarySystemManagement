using LibraryManageMentWinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageMentWinForm.Repository
{
    public interface ILibrary
    {
        List<BookDetails> GetListOfBook();
        List<Borrower> GetListOfBorrowwres();

        bool BorrowBook(BorrowBook bookborrow);
        bool ReturnBorrowBook(BorrowBook bookborrow);
        List<BookDetails> SearchBook(string word);
        List<BookDetails> SearchWithGenre(string genre);
    };
}
