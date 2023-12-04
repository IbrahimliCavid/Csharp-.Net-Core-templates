namespace Task_2
{
    internal class Program
    {
        const string MyDb= "C:\\lineDataBase";
        static void Main()
        {
            Console.WriteLine("What are you doing : 1 - Add a new person. 2 - Find the person information.");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    var person = CreatePerson();
                    RegisterPersonInDb(person);
                    break;
                case 2:
                    GetContextInFile();
                    break;

                default:
                    Console.WriteLine("Please change the correct button. (1 or 2)");
                    break;
            }
          
          
        }

        static Person CreatePerson()
        {
            var person = new Person();

            Console.WriteLine("Please enter a name: ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Please enter a surname: ");
            person.Surname = Console.ReadLine();

            Console.WriteLine("Please enter a ID: ");
            person.Id = int.Parse(Console.ReadLine());


           
          
          

            return person;
        }


        static void RegisterPersonInDb(Person person) 
        {
            string file = Path.Combine(MyDb, person.Id + ".txt");
            
           

            if (File.Exists(file))
            {
                Console.WriteLine("This person has already been registered.");
            }
            else
            {
                var fileText = $"{nameof(person.Name)} : {person.Name}\n" +
              $"{nameof(person.Surname)} : {person.Surname}\n" +
              $"{nameof(person.Id)} : {person.Id}";
                File.WriteAllText(file, fileText);
                Console.WriteLine("Registered successfully");

            }
        }


        static void GetContextInFile()
        {
            var directory = new DirectoryInfo(MyDb);
            Console.WriteLine("Please enter person ID:");
            string userInput = Console.ReadLine();
            var files = directory.GetFiles();
            bool isTrue = true;
            foreach ( var file in files)
            {
 
                if (file.Name.Split(".")[0].Trim() == userInput)
                {
                    Console.WriteLine("Please enter needed line: (FE - 1, 2, 3)");
                    int line = int.Parse(Console.ReadLine());
                    var fileLines = File.ReadAllLines(file.FullName);
                    Console.WriteLine(fileLines[line-1]);
                    isTrue = false;
                    break;
                    
                }
         
                
            }

            if(isTrue)
            {
                Console.WriteLine("This person has not find in database");
            }

        }



    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
    }
}