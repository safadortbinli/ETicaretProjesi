using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // true dönerse.
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true , message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
