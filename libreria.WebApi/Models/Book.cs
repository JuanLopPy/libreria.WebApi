namespace libreria.WebApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public DateTime Publication { get; set; }
        public string Image { get; set; }
        public string reviw { get; set; }

        public double Rating { get; set; }

        public int UserId { get; set; } 

        public User User { get; set; }

    }
}
