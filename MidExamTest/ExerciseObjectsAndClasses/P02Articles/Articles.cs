
namespace P02Articles
{
    class Articles
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Articles(string title, string content, string autor)
        {
            this.Title = title;
            this.Content = content;
            this.Author = autor;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
    }
}
