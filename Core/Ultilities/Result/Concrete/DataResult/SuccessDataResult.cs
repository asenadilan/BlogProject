using Core.Ultilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultilities.Result.Concrete.DataResult
{
    public class SuccessDataResult<T>: DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message) { }
        public SuccessDataResult(T data):base(data,true) { }
    
    }
}
