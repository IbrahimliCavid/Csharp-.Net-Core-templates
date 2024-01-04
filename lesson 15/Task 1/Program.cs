using System.Collections;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<string> listStr = new MyList<string>();
            listStr.Add("Hi"); 
            listStr.Add("Hello");
            listStr.Add("Hallo");
            listStr.Add("Privet");

            // listStr.Clear();

            listStr.Remove("Hi");

            if (listStr.Contains("Hello"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            

            foreach (var item in listStr)
            {
                Console.WriteLine(item);
            }
           
        }
    }

    public class MyList<T> : IEnumerable<T>
    {
        private List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }
        public  void Add(T item)
        {
            _list.Add(item);
           
        }

        public T  GetValueList(int i)
        {
            return _list[i];
        }

        public void Clear()
        {
           _list.Clear();
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public int Count
        {
            get 
            {
                return _list.Count;
            }
        }
    }
}