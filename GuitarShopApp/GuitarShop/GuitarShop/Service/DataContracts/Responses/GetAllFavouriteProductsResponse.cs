using GuitarShop.Service.DataContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.DataContracts.Responses
{
    public class GetAllFavouriteProductsResponse : BaseResponse
    {
        public IEnumerable<ListProductDTO> Products { get; set; }
    }
}
