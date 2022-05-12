using Module21.Interfaces;

namespace Module21.Models
{
    public class Book : IBookDocument
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? Publisher { get; set; }
        public DateTime DatePublished { get; set; }

        public override string ToString()
        {
            return $@"
                Type: Book,
                Number: {Number},
                ISBN: {ISBN},
                Title: {Title},
                Authors: {Authors},
                Number Of Pages: {NumberOfPages},
                Publisher: {Publisher},
                Date Published: {DatePublished.ToString("d")},
            ";
        }
    }
}
