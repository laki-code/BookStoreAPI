using BookStore.Application.DataTransfer;
using BookStore.Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Application.Queries
{
    public interface IGetProductsQuery : IQuery<ProductSearch,PagedResponse<ProductDto>>
    {
    }
}
