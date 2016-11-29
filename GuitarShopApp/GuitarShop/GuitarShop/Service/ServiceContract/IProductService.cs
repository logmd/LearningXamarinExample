using GuitarShop.Service.DataContracts.Requests;
using GuitarShop.Service.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.ServiceContract
{
    public interface IProductService
    {
        GetAllProductsResponse GetAllProducts(GetAllProductsRequest request);

        GetAllFavouriteProductsResponse GetAllFavouriteProducts(GetAllFavouriteProductsRequest request);

        GetProductDetailsResponse GetProductDetails(GetProductDetailsRequest request);

        AddFavouriteProductResponse AddFavouriteProduct(AddFavouriteProductRequest request);

        DeleteFavouriteProductResponse DeleteFavouriteProduct(DeleteFavouriteProductRequest request);
    }
}
