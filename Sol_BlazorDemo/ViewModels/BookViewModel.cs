using Sol_BlazorDemo.Models;
using Sol_BlazorDemo.UiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_BlazorDemo.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<BookModel> bookListVM { get; set; }
        public BookUiModel bookUi { get; set; } 
    }
}
