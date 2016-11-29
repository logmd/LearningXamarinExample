using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.DataContracts.Responses
{
    public abstract class BaseResponse
    {
        public bool HasError { get; set; }

        public string ErrorMessage { get; set; }
    }
}
