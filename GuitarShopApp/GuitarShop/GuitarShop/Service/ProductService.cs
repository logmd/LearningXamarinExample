using System;
using System.Collections.Generic;
using System.Linq;
using GuitarApp.Infrastructure.UnitOfWork;
using GuitarShop.BusinessObjects;
using GuitarShop.DAL;
using GuitarShop.Service.DataContracts.DTO;
using GuitarShop.Service.DataContracts.Requests;
using GuitarShop.Service.DataContracts.Responses;
using GuitarShop.Service.Extensions;
using GuitarShop.Service.ServiceContract;
using GuitarShop.Service.ThirdParty;

namespace GuitarShop.Service
{
    public class ProductService : IProductService
    {
        private readonly IInventoryFacade _inventory;
        private readonly IRepository<Favourite, int> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IRepository<Favourite, int> repository, IUnitOfWork unitOfWork, IInventoryFacade inventory)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _inventory = inventory;
        }

        public AddFavouriteProductResponse AddFavouriteProduct(AddFavouriteProductRequest request)
        {
            var response = new AddFavouriteProductResponse();

            try
            {
                var favourite = new Favourite
                {
                    ProductNumber = request.ProductNumber
                };

                _repository.Add(favourite);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public DeleteFavouriteProductResponse DeleteFavouriteProduct(DeleteFavouriteProductRequest request)
        {
            var response = new DeleteFavouriteProductResponse();

            try
            {
                var favourite = new Favourite
                {
                    ProductNumber = request.ProductNumber
                };

                _repository.Remove(favourite);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public GetAllFavouriteProductsResponse GetAllFavouriteProducts(GetAllFavouriteProductsRequest request)
        {
            var response = new GetAllFavouriteProductsResponse();
            var favouriteList = new List<ListProductDTO>();

            try
            {
                var favourites = _repository.FindAll();
                var products = _inventory.GetAllProducts();

                foreach (var favourite in favourites)
                {
                    var product = products.FirstOrDefault(p => p.ProductNumber == favourite.ProductNumber);

                    if (product != null)
                        favouriteList.Add(product.ConvertToListProductDTOFromProduct());
                }
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            response.Products = favouriteList;
            return response;
        }

        public GetAllProductsResponse GetAllProducts(GetAllProductsRequest request)
        {
            var response = new GetAllProductsResponse();
            var productList = new List<ListProductDTO>();

            try
            {
                var products = _inventory.GetAllProducts();

                foreach (var product in products)
                    productList.Add(product.ConvertToListProductDTOFromProduct());
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            response.Products = productList;
            return response;
        }

        public GetProductDetailsResponse GetProductDetails(GetProductDetailsRequest request)
        {
            var response = new GetProductDetailsResponse();

            try
            {
                var product = _inventory.GetProductByProductNumber(request.ProductNumber);
                response.Product = product.ConvertToProductDTOFromProduct();
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}