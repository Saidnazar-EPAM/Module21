using Module21.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21.Models
{
    public class LocalizedBook : IBookDocument
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? OriginalPublisher { get; set; }
        public string? CountryOfLocalization { get; set; }
        public string? LocalPublisher { get; set; }
        public DateTime DatePublished { get; set; }

        public override string ToString()
        {
            return $@"
                Type: Localized Book,
                Number: {Number},
                ISBN: {ISBN},
                Title: {Title},
                Authors: {Authors},
                Number Of Pages: {NumberOfPages},
                Original Publisher: {OriginalPublisher},
                Country Of Localization: {CountryOfLocalization},
                Local Publisher: {LocalPublisher},
                Date Published: {DatePublished.ToString("d")}
            ";
        }
    }
}
