using Sol_BlazorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_BlazorDemo.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookModel>> GetBookList();
    }
}
