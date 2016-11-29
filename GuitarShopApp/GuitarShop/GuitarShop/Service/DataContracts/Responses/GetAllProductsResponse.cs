using GuitarShop.Service.DataContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.DataContracts.Responses
{
    public class GetAllProductsResponse : BaseResponse
    {
        public IEnumerable<ListProductDTO> Products { get; set; }
    }
}
