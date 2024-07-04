//using System.ComponentModel.DataAnnotations;

namespace CodingWiki_Model.Models
{
    public class Book
        {
            //[Key]                             // will specify a primary key
            //public int Id { get; set; }       // if the field is id then it will be regarded as primary key
            public int BookId { get; set; }     // if the field name is ended with "id",it will be used as primary key
            public string Title { get; set; }
            public string ISBN { get; set; }
            public double Price { get; set; }
        }
}
