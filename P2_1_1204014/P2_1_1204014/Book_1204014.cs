using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204014
{
    public class Book: ProductTest_1204014
    {
        protected string pageCount;

        public Book(string type, string title, string pagecount)
            : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}
