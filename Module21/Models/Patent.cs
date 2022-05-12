using Module21.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21.Models
{
    public class Patent : IDocument
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid UniqueId { get; set; }

        public override string ToString()
        {
            return $@"
                Type: Patent,
                Number: {Number},
                Title: {Title},
                Authors: {Authors},
                Date Published: {DatePublished.ToString("d")},
                Expiration Date: {ExpirationDate.ToString("d")},
                Unique Id: {UniqueId}
            ";
        }
    }
}
