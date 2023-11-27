using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_.Models
{
    internal class BIgPhotoBook
    {
        private int NumPage;
        public BIgPhotoBook()
        {
            NumPage = 64;
        }

        public int GetPage()
        {
            return NumPage;
        }
    }
}
