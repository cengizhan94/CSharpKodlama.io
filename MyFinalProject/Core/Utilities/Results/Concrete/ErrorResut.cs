using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
