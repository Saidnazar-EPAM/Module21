using Module21.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21.Models
{
    public class Magazine : IDocument
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public int ReleaseNumber { get; set; }
        public DateTime PublishDate { get; set; }

        public override string ToString()
        {
            return $@"
                Type: Book,
                Number: {Number},
                Title: {Title},
                Publisher: {Publisher},
                Release Number: {ReleaseNumber},
                Publish Date: {PublishDate.ToString("d")}
            ";
        }
    }
}
