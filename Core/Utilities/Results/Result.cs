using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

        public Result(bool success, string message):this(success) // Set etmedezdik sadece get verdik ancak constracter içersinde set edeliriz.
        {
            Message = message;
            
        }
        public Result(bool success) //ourloading // sadece bool döndürmesi için mesaj yazdırmassak bunu karşılasın bu şekilde çalışıp hata vermesin diye yazdık.
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
