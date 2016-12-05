using GuitarShop.Service.DataContracts.Requests;
using GuitarShop.Service.DataContracts.Responses;
using System.Threading.Tasks;

namespace GuitarShop.Service.ServiceContract
{
    public interface IProductService
    {
        Task<GetAllProductsResponse> GetAllProducts(GetAllProductsRequest request);

        Task<GetAllFavouriteProductsResponse> GetAllFavouriteProducts(GetAllFavouriteProductsRequest request);

        Task<GetProductDetailsResponse> GetProductDetails(GetProductDetailsRequest request);

        Task<AddFavouriteProductResponse> AddFavouriteProduct(AddFavouriteProductRequest request);

        Task<DeleteFavouriteProductResponse> DeleteFavouriteProduct(DeleteFavouriteProductRequest request);
    }
}