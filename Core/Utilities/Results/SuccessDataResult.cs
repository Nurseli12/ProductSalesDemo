using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
   public class SuccessDataResult<T> :DataResult<T>
    {
        //Bana bir data ve message ver ve işlem sonucu true dur
        public SuccessDataResult(T data,string message) :base(data,true,message)
        {

        }
        //Hiç message olayına girmemek için, data veriyoruz ve işlem sonucu ture
        public SuccessDataResult(T data) :base(data,true)
        {

        }
        //Sadece message vermek isetrsek base kısmına default geçiyoruz.Bu biraz sıkıntılı bir yapı
        //İşlem sonucu farkettiysek hep true neden? çünkü zaten successDataResult sonucunu yapıyoruz.
        public SuccessDataResult(string message) : base(default,true,message)
        {

        }
        //Burada ne mesaj ve data var, sadece işlem sonucu true
        //Default dediğimiz şey dataya karşılık geliyor
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
