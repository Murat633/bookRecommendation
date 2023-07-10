using BookRecommendation.Core.Interfaces.UnitOfWorks;
using BookRecommendation.Core.Services;
using BookRecommendation.Repository;
using BookRecommendation.Repository.Entities;
using BookRecommendation.Repository.Repositories;
using BookRecommendation.Service.Services;
using BookRecommendation.Service.UnitOfWorks;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml.Linq;

namespace bookRecommendation
{
    public partial class Form1 : Form
    {
        public DbContext _efContext;
        public IGenericService<Author> _authorService;
        public IGenericService<Book> _bookService;
        public IGenericService<BookOfTheDay> _bookOfTheDayService;
        public IGenericService<Category> _categoryService;
        public IUnitOfWorks _unitOfWorks;
        public Form1()
        {
            InitializeComponent();
            _efContext = new EfDbContext();
            _authorService = new AuthorService(new GenericRepository<Author>(_efContext));
            _bookService = new BookService(new GenericRepository<Book>(_efContext));
            _bookOfTheDayService = new BookOfTheDayService(new GenericRepository<BookOfTheDay>(_efContext));
            _categoryService = new CategoryService(new GenericRepository<Category>(_efContext));

            _unitOfWorks = new UnitOfWorks(_efContext);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            writeToDgwBooksAndAuthors();
            writeToCbxAuthor();

            var day = DateTime.Today;

            var todayCurrentBook = _bookOfTheDayService.GetByAnyQuery(x => x.Created == day);
            if (todayCurrentBook == null)
            {
                var books = _bookService.GetAllAsync().ToList();
                var random = new Random().Next(0, books.Count);
                var todayBook = books[random];
                BookOfTheDay bookOfTheDay = new BookOfTheDay
                {
                    Name = todayBook.Name,
                    Description = todayBook.Description,
                    AuthorId = todayBook.AuthorId,
                    Created = day,
                };

                _bookOfTheDayService.Add(bookOfTheDay);
                _unitOfWorks.SaveChangesAsync();
                lblRecommendedBookName.Text = todayBook.Name;

            }
            else
            {
                lblRecommendedBookName.Text = todayCurrentBook.Name;
            }

        }

        private void gbxAddBook_Enter(object sender, EventArgs e)
        {

        }

        public void writeToCbxAuthor()
        {
            var authors = _authorService.GetAllAsync().ToList();

            cbxAddAuthor.DataSource = authors;
            cbxAddAuthor.DisplayMember = "Name";
            cbxAddAuthor.ValueMember = "Id";

            cbxBooksUpdateAuthor.DataSource = authors;
            cbxBooksUpdateAuthor.DisplayMember = "Name";
            cbxBooksUpdateAuthor.ValueMember = "Id";
        }

        public void writeToDgwBooksAndAuthors()
        {
            dgwBooks.DataSource = _bookService.GetAllAsync().ToList();
            dgwBooks.Columns[4].Visible = false;

            dgwAuthors.DataSource = _authorService.GetAllAsync().ToList();

        }



        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var name = tbxBookAddName.Text.ToString();
            var description = tbxBookAddDescription.Text.ToString();

            var authorId = cbxAddAuthor.SelectedValue.ToString();


            Book newbook = new Book()
            {
                Name = name,
                Description = description,
                AuthorId = int.Parse(authorId)
            };
            if (name == "" || description == "" || authorId == "")
            {
                MessageBox.Show("Lütfen Tum Alanlarý Doðru bir formatta doldurun!");
            }
            else
            {
                _bookService.Add(newbook);
                _unitOfWorks.SaveChanges();
                writeToCbxAuthor();
                writeToDgwBooksAndAuthors();
            }

        }



        private void dgwBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgwBooks.CurrentRow.Cells[0].Value.ToString();
            var name = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            var description = dgwBooks.CurrentRow.Cells[2].Value.ToString();
            var authorId = dgwBooks.CurrentRow.Cells[3].Value.ToString();


            gbxUpdateBook.Visible = true;
            tbxBooksUpdateId.Text = id;
            tbxBooksUpdateName.Text = name;
            tbxBooksUpdateDescription.Text = description;
            cbxBooksUpdateAuthor.SelectedValue = int.Parse(authorId);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            var id = tbxBooksUpdateId.Text;
            var name = tbxBooksUpdateName.Text;
            var description = tbxBooksUpdateDescription.Text;

            var authorId = cbxBooksUpdateAuthor.SelectedValue.ToString();




            Book newbook = new Book()
            {
                Id = int.Parse(id),
                Name = name,
                Description = description,
                AuthorId = int.Parse(authorId)
            };

            if (name == "" || description == "" || authorId == "")
            {
                MessageBox.Show("Lütfen Tum Alanlarý Doðru bir formatta doldurun!");
            }
            else
            {
                _bookService.Update(newbook);
                _unitOfWorks.SaveChanges();

                writeToDgwBooksAndAuthors();
                writeToCbxAuthor();
                gbxUpdateBook.Visible = false;
            }

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            var id = dgwBooks.CurrentRow.Cells[0].Value.ToString();
            if (id != "")
            {
                _bookService.Delete(int.Parse(id));
                _unitOfWorks.SaveChanges();
                writeToDgwBooksAndAuthors();
                writeToCbxAuthor();
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            var id = dgwAuthors.CurrentRow.Cells[0].Value.ToString();
            if (id != "")
            {
                _authorService.Delete(int.Parse(id));
                _unitOfWorks.SaveChanges();
                writeToDgwBooksAndAuthors();
                writeToCbxAuthor();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var name = tbxAddAuthorName.Text;
            if (name == "")
            {
                MessageBox.Show("Lütfen Tum Alanlarý Doðru bir formatta doldurun!");
            }
            else
            {

                _authorService.Add(new Author { Name = name });
                _unitOfWorks.SaveChanges();
                writeToCbxAuthor();
                writeToDgwBooksAndAuthors();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = tbxUpdateAuthorId.Text;
            var name = tbxUpdateAuthorName.Text;

            if (name == "" || id == "")
            {
                MessageBox.Show("Lütfen Tum Alanlarý Doðru bir formatta doldurun!");
            }
            else
            {

                _authorService.Update(new Author { Id = int.Parse(id), Name = name });
                _unitOfWorks.SaveChanges();

                gbxUpdateAuthor.Visible = false;
                writeToCbxAuthor();
                writeToDgwBooksAndAuthors();
            }
        }

        private void dgwAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgwAuthors.CurrentRow.Cells[0].Value.ToString();
            var name = dgwAuthors.CurrentRow.Cells[1].Value.ToString();

            tbxUpdateAuthorId.Text = id;
            tbxUpdateAuthorName.Text = name;
            gbxUpdateAuthor.Visible = true;

        }
    }
}