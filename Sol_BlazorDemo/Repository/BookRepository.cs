using Sol_BlazorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_BlazorDemo.Repository
{
    public class BookRepository : IBookRepository
    {
        Task<IEnumerable<BookModel>> IBookRepository.GetBookList()
        {
            try
            {
                var bookList = new List<BookModel>() {
                    new BookModel()
                    {
                        Id=1,
                        Name="Wings of Fire",
                        CoverImage="images\\wingsoffire.jpg",
                        Details="An Autobiography of A P J Abdul Kalam (1999), former President of India. It was written by Dr. Kalam and Arun Tiwari."
                    },
                    new BookModel()
                    {
                        Id=2,
                        Name="You Can Win",
                        CoverImage="images\\youcanwin.png",
                        Details="An easy to read, practical, common-sense approach that will take you from ancient wisdom to contemporary thinking, You Can Win helps you dispel confusion in daily life and clarify values."
                    },
                    new BookModel()
                    {
                        Id=3,
                        Name="Wings of Fire",
                        CoverImage="images\\wingsoffire.jpg",
                        Details="An Autobiography of A P J Abdul Kalam (1999), former President of India. It was written by Dr. Kalam and Arun Tiwari."
                    },
                    new BookModel()
                    {
                        Id=4,
                        Name="You Can Win",
                        CoverImage="images\\youcanwin.png",
                        Details="An easy to read, practical, common-sense approach that will take you from ancient wisdom to contemporary thinking, You Can Win helps you dispel confusion in daily life and clarify values."
                    }

                };

                return Task.FromResult<IEnumerable<BookModel>>(bookList);
            } 
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
