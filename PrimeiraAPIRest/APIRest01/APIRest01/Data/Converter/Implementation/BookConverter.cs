using APIRest01.Data.Converter.Contract;
using APIRest01.Data.Vo;
using APIRest01.Model;
using System.Collections.Generic;
using System.Linq;

namespace APIRest01.Data.Converter.Implementation {

    public class BookConverter : IParser<BookVo, Book>, IParser<Book, BookVo> {
        public Book Parse(BookVo origin) {

            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public List<Book> Parse(List<BookVo> origin) {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public BookVo Parse(Book origin) {
            if (origin == null) return null;
            return new BookVo {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public List<BookVo> Parse(List<Book> origin) {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}