using lesson9_.Models;

namespace lesson9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            PhotoBook book = new PhotoBook();
            Console.WriteLine(book.GetNumbersPages());
           Console.WriteLine(book.SetPage(24));

            BIgPhotoBook bigBook = new BIgPhotoBook();

            Console.WriteLine(bigBook.GetPage());



        }
    }
}