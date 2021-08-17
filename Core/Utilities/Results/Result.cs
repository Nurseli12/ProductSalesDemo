using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //Construct da set edilebilir, Neden bunu yaptık, Çünkü Business katmanında set edlilemesin
        public Result(bool success, string message):this(success) //Burada 2 parametre çalışoıyor. Ama bu
            //Çalışdığında sen git success constractur ımı da çalıştır diyoruz
        {
            Message = message;
            //Success = success; //Buna gerek yok aslında neden?
            // çünkü Alttaki success kısmında Zaten çalışıyor. Ama Bu kod çalıştığında 
            
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
