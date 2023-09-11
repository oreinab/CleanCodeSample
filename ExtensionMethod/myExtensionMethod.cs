using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExtensionMethod
{
    public static class myExtensionMethod
    {
        public static string toShamsi(this DateTime value)
        {
            PersianCalendar pc=new PersianCalendar();
            return pc.GetYear(value).ToString() +"/"+ pc.GetMonth(value).ToString("00")+"/"+pc.GetDayOfMonth(value).ToString();
          
        }
    }
}
