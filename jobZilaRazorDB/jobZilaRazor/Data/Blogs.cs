namespace jobZilaRazor.Data
{
    public class Blogs
    {
        public int id { get; set; }
        public  string title { get; set; }
        public  string user { get; set; }
        public DateOnly creationdate { get; set; }
        public string content { get; set; }
        
    }
}
