using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBai2
{
    class Book
    {

            public int Id { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public int PublisherId { get; set; }
            public int YearPublished { get; set; }
            public decimal Price { get; set; }
        
    }
}
