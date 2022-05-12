using Module21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21.Interfaces
{
    public interface IFindDocument
    {
        IEnumerable<string> FindByNumber(int number);
    }
}
