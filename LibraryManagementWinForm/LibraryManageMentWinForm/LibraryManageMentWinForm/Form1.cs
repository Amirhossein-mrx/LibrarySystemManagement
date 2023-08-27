using LibraryManageMentWinForm.Model;
using LibraryManageMentWinForm.Repository;
using LibraryManageMentWinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManageMentWinForm
{
    public partial class Form1 : Form
    {
        ILibrary library;
        public Form1()
        {
            InitializeComponent();
            library = new LibraryService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            lbBooks.Items.Clear();
            lbAuthers.Items.Clear();
            lbBorrowers.Items.Clear();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            var books = library.GetListOfBook();
            var borrowers = library.GetListOfBorrowwres();
            for (int i = 0; i < books.Count; i++)
            {
                lbBooks.Items.Add(books[i].BookName);
                lbAuthers.Items.Add(books[i].AuthorName);
                comboBox1.Items.Add(books[i].Genre);
            }

            for (int i = 0; i < borrowers.Count; i++)
            {
                lbBorrowers.Items.Add(borrowers[i].borrowerName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem!=null||lbBorrowers.SelectedItem!=null)
            {
                
                var BookName=lbBooks.SelectedItem.ToString();
                var BorrowerName=lbBorrowers.SelectedItem.ToString();

                var books = library.GetListOfBook();
                var borrowers = library.GetListOfBorrowwres();
                var bookId = books.Where(x => x.BookName == BookName).ToList();
                var borrowerId = borrowers.Where(x => x.borrowerName == BorrowerName).ToList();
                BorrowBook borrowbook = new BorrowBook()
                {
                    BookId = bookId[0].BookId,
                    BorrowId = borrowerId[0].Id
                }; 
                if (library.BorrowBook(borrowbook))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null || lbBorrowers.SelectedItem != null)
            {

                var BookName = lbBooks.SelectedItem.ToString();
                var BorrowerName = lbBorrowers.SelectedItem.ToString();

                var books = library.GetListOfBook();
                var borrowers = library.GetListOfBorrowwres();
                var bookId = books.Where(x => x.BookName == BookName).ToList();
                var borrowerId = borrowers.Where(x => x.borrowerName == BorrowerName).ToList();
                BorrowBook borrowbook = new BorrowBook()
                {
                    BookId = bookId[0].BookId,
                    BorrowId = borrowerId[0].Id
                };
                if (library.ReturnBorrowBook(borrowbook))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void btngenre_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var books=library.SearchWithGenre(comboBox1.SelectedItem.ToString());
            lbBooks.Items.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                lbBooks.Items.Add(books[i].BookName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var books= library.SearchBook(textBox1.Text);
            lbBooks.Items.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                lbBooks.Items.Add(books[i].BookName);
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }
    }
}
