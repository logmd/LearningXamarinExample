using GuitarShop.Service.DataContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.DataContracts.Responses
{
    public class GetProductDetailsResponse : BaseResponse
    {
        public ProductDTO Product { get; set; }
    }
}
