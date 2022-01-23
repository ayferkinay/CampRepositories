using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullationn
{
    internal class Book
    {

        private int pageSize;
        private string bookName, bookWriter;

        public Book(int PageSize, string BookName, string BookWriter)
        {
            this.bookName = BookName;
            this.bookWriter = BookWriter;

            if (pageSize < 1)
            {
                this.pageSize = 10;
            }
            else
            {
                this.pageSize=PageSize;
            }
        }

        public int getPageSize()
        {
            return this.pageSize;
        }

        public void setPageSize(int PageSize)
        {
            if (pageSize < 1)
            {
                this.pageSize = 10;
            }
            else
            {
                this.pageSize = PageSize;
            }
        }
    }
}
