using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21.Interfaces
{
    public interface IDocument
    {
        Guid Id { get; set; }
        int Number { get; set; }
        string Title { get; set; }
    }
}
