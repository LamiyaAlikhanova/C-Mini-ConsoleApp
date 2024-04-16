namespace Task105_A.L._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom classrom = new Classroom();
            bool exit = false;
            do
            {
                Console.WriteLine("1.Classrom yarat");
                Console.WriteLine("2.student yarat");
                Console.WriteLine("3.Butun Telebeleri ekrana cixart");
                Console.WriteLine("4.Telebe sil");
                Console.WriteLine("5.Telebeni tap");
                Console.WriteLine("0.Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Classroom yarat.");
                        Classroom classroom1 = createclassroom();
                        Console.WriteLine("Classroom yaradildi.");
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Student yarat");
                            Student student = createcstudent();

                            Console.WriteLine("Student elave et");
                            classrom.StudentAdd(student);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "3":
                        classrom.ShowAllInfo();
                        Console.WriteLine("Butun sagirdleri gorursuz");
                        break;
                    case "4":
                        try
                        {

                            Console.WriteLine("Id daxil edin");
                            int id = Convert.ToInt32(Console.ReadLine());
                            classrom.RemoveStudent(id);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "5":
                        try
                        {

                            Console.WriteLine("Id daxil edin");
                            int id = Convert.ToInt32(Console.ReadLine());
                            classrom.FindId(id);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "0":
                        exit = true;
                        break;

                }




            } while (exit != true);




        }
        static Classroom createclassroom()
        {
            Classroom classroom1 = new Classroom();
            Console.WriteLine("clasroomun adini daxil edin:");
            classroom1.Name = Console.ReadLine();
            Console.WriteLine("Tipini daxil edin:");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    classroom1.Type = Typeenum.Fronted;
                    break;
                case "2":
                    classroom1.Type = Typeenum.Backend;
                    break;
                default:
                    Console.WriteLine("Classroom tapilmadi");
                    break;
            }
            return classroom1;


        }


        static Student createcstudent()
        {

            Classroom students = null;

            if (students == null)
            {
                throw new classroomdontfound("Classroom tapilmadi");
            }
            else
            {
                Student student = new Student();
                Console.WriteLine("Adi daxil edin:");
                student.Name = Console.ReadLine();
                Console.WriteLine("Soyadi daxil edin:");
                student.Surname = Console.ReadLine();

                return student;
            }
        }
    }
}
