using System;
using Xunit;
using Fisher.Bookstore.Models.Book.cs;

namespace tests
{
    public class BookTest
    {
        [Fact]
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            //Act
            book.ChangePublicationDate(DateTime.Now.AddMonths(2));

            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();
            Assert.Equal(DateTime.Now.AddMonths(2), book.PublishDate);

        }
    }
}
