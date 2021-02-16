using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıçlar
    public interface IResult
    {
        bool Success { get; } // İşlem başarılı mı?,başarısız mı? True,False döndürür.
        string Message { get; }//Kullanıcıya mesaj döndürür
    }
}
