using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Secound.Classes.Task3Book
{
    class Book
    {
        Title tit = new Title();
        Author auth = new Author();
        Content cont = new Content();

        public void SetTitle(string title)
        {
            tit.title = title;

        }

        public void SetAuthor(string author)
        {
            auth.author = author;
        }

        public void SetContent(string content)
        {
            cont.content = content;
        }

        public void ShowAll()
        {
            tit.Show();
            auth.Show();
            cont.Show();
        }
    }
}
