using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Dom
{
    public interface ILan
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Position { get; set; }
        DateTime CreateDate { get; set; }
        decimal Salary { get; set; }
        Gender Gender { get; set; }
    }
}
