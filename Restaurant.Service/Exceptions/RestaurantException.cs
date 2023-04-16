using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.Exceptions
{
    public class RestaurantException : Exception
    {
        public int Code { get; set; }

        public RestaurantException(int code,string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
