using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //Bana bir data ve message ver ve işlem sonucu true dur
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //Hiç message olayına girmemek için, data veriyoruz ve işlem sonucu ture
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //Sadece message vermek isetrsek base kısmına default geçiyoruz.Bu biraz sıkıntılı bir yapı
        //İşlem sonucu farkettiysek hep true neden? çünkü zaten successDataResult sonucunu yapıyoruz.
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //Burada ne mesaj ve data var, sadece işlem sonucu true
        //Default dediğimiz şey dataya karşılık geliyor
        public ErrorDataResult() : base(default, false)
        {

        }
    }

}
