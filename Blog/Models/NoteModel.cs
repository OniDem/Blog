namespace Blog.Models
{
    public class NoteModel
    {
        public int Note_id { get; set; }
        public string Author { get; set; }
        public string Note_Title { get; set;}
        public string Note_Content { get; set; }
        public DateTime Created_date { get; set; }
        public DateTime Last_updated { get; set; }
    }
}
