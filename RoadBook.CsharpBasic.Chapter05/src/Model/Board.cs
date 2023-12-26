using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src.Model
{
    /// <summary>
    /// Board
    /// </summary>
    class Board
    {
       /// post number
       public int Number { get; set; }
       /// post title
       public string Title { get; set; }
        /// post contents
       public string Contents { get; set; }
       /// post writer
       public string Writer { get; set; } 
       /// post date
       public DateTime CreateDate { get; set; }
        ///updateDate 
       public DateTime UpdateDate { get; set; }

    }
}
