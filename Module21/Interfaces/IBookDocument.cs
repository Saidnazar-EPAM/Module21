using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21.Interfaces
{
    public interface IBookDocument : IDocument
    {
        string ISBN { get; set; }
        int NumberOfPages { get; set; }
    }
}
