using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_lab_2.Models
{
    public class Constants
    {
        public class Strings
        {
            public const string DataFolder = "AppData";
            public const string BooksLibrary = "BooksLibrary.xml";
            public const string AuthorsLibrary = "AuthorsLibrary.xml";
            public const string PublishersLibrary = "PublishersLibrary.xml";
        }

        public class Errors
        {
            public const string IncorrectIndex = "Incorrect index";
            public const string IncorrectTitle = "Incorrect title.";
            public const string NullAuthor = "Incorrect author.";
            public const string NullPublisher = "Incorrect publisher.";
            public const string IncorrectYear = "Incorrect year";
            public const string BookExist = "This book is already exist.";
            public const string IncorrectAuthorName = "Incorrect author name.";
            public const string AuthorNameExist = "Author with this name is already exist.";
            public const string IncorrectPublisherName = "Incorrect publisher name.";
            public const string PublisherNameExist = "Publisher with this name is already exist.";
        }

    }
}
