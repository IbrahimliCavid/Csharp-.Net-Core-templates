using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_.Models
{
    internal class PhotoBook
    {
        private int NumPage;
        public PhotoBook()
        {
            NumPage = 16;
        }

        public int GetNumbersPages()
        {
            return NumPage;
        }
        public int SetPage(int newPage)
        {
            NumPage = newPage;
            return NumPage;
        }

    }
}
