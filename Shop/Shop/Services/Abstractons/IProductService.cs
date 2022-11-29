﻿using Shop.Data.Entities;

namespace Shop.Repositories.Abstractions
{
    public interface IProductService
    {
        Task<int> AddProductAsync(
            int supplierID,
            int categoryID,
            string sKU,
            string iDSKU,
            int vendorProductId,
            string productName,
            string productDescription,
            int quantityPerUnit,
            decimal unitPrice,
            string mSRP,
            string availableSize,
            string availableColors,
            string size,
            string color,
            decimal discount,
            string unitWeight,
            int unitsInStock,
            int unitsOnOrder,
            string reorderLevel,
            bool productAvailable,
            bool discountAvailable,
            string picture,
            int ranking,
            string note);
        Task<bool> DeleteProductAsync(int id);
        Task<bool> UpdateProductAsync(int id, string property, string value);
        Task<ProductModel?> GetProductAsync(int id);
        Task<IReadOnlyList<ProductModel>?> GetProductByCategoryIdAsync(int id);
        Task<IReadOnlyList<ProductModel>?> GetProductBySupplierIdAsync(int id);
    }
}