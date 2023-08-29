namespace PSN_Official.Data
{
    public class BlogComment
    {
        public string Id { get; set; } = "";
        public string BlogId { get; set; } = "";
        public string Comment { get; set; } = "";
        public DateTime Date { get; set; }
        public string Username { get; set; } = "";
    }
}
