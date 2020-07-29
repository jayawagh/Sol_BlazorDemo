using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_BlazorDemo.Repository;
using Sol_BlazorDemo.UiModels;
using Sol_BlazorDemo.ViewModels;

namespace Sol_BlazorDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository = null;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
            bookVM = new BookViewModel();
        }

        [BindProperty]
        public BookViewModel bookVM { get; set; }
        
        public async Task<IActionResult> Index()
        {
            bookVM.bookListVM = (await this.bookRepository.GetBookList()).ToList();
            bookVM.bookUi = new BookUiModel();
            bookVM.bookUi.tableCss = "table table-light";

            return View(bookVM);
        }
    }
}