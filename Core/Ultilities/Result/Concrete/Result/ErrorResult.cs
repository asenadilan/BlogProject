using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultilities.Result.Concrete
{
    public class ErrorResult: Result
    {
        ErrorResult(string message) : base(false,message) { }
        ErrorResult() : base(false) { }
    }
}
