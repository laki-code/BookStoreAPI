﻿using BookStore.Application.DataTransfer;
using BookStore.Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Application.Queries
{
    public interface IGetUseCaseQuery : IQuery<UseCaseLogSearch,PagedResponse<UseCaseLogDto>>
    {
    }
}
