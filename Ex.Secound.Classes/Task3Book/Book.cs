namespace Ex.Secound.Classes.Task3Book
{
    class Book
    {
        private Title tit = new Title();
        private Author auth = new Author();
        private Content cont = new Content();

        public void SetTitle(string title)
        {
            tit.SetTitle(title);
        }

        public void SetAuthor(string author)
        {
            auth.SetAuthor(author);
        }

        public void SetContent(string content)
        {
            cont.SetContent(content);
        }

        public void ShowAll()
        {
            tit.Show();
            auth.Show();
            cont.Show();
        }
    }
}
