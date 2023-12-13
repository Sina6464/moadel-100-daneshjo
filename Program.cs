using System.IO;
using film;


string Path = "C:\\Users\\Acer\\Desktop\\c# tamrin\\tamrin\\asli\\asli\\Students.txt";
string[] Lines = File.ReadAllLines(Path);
//mohammadmohammadkazemi

daneshjo[] students = new daneshjo[100];
for (int i = 0; i < students.Length; i++)
{
    string[] line = Lines[i].Split(",");
    daneshjo Student = new daneshjo();
    Student.Name = line[0]; Student.Lastname = line[1]; Student.pishraftre2 = Int32.Parse(line[2]);
    Student.pishrafte1 = Int32.Parse(line[3]); Student.algoritm = Int32.Parse(line[4]); Student.sheygerayi = Int32.Parse(line[5]);
    Student.riazi = Int32.Parse(line[6]); Student.kargah = Int32.Parse(line[7]);
    Student.tarbiat = Int32.Parse(line[8]); Student.tafsir = Int32.Parse(line[9]);
    Student.system = Int32.Parse(line[9]); Student.zaban = Int32.Parse(line[11]);
    students[i] = Student;
}


bool javab = false;
do
{
    Console.WriteLine("=>1:Namayesh Moadel " + "\n=>2:Namayesh Moadel3" +
        "\n=>3:Namayesh Moadel2" + "\n=>4:Namayesh Moadel1" +
      "\n=>5:Namayesh Har 4 Model)" +
      "\n=>6:Namayesh Adad Aval Nomarat Daneshjo" + "\n=>7:Namayesh Grade" +
      "\n=>8:End<=");
    int adadvorodi = Convert.ToInt32(Console.ReadLine());
    switch (adadvorodi)
    {
        case 1:
            foreach (var student in students)
            {
                Console.WriteLine(student.NAMES() + student.Moadel());
            }
            break;
        case 2:
            foreach (var student in students)
            {
                Console.WriteLine(student.NAMES() + student.Moadel3());
            }
            break;
        case 3:
            foreach (var student in students)
            {
                Console.WriteLine(student.NAMES() + student.Moadel2());
            }
            break;
        case 4:
            foreach (var student in students)
            {
                Console.WriteLine(student.NAMES() + student.Moadel1());
            }
            break;
        case 5:
            foreach (var student in students)
            {

                Console.WriteLine("name:" + student.NAMES() + "  moadel: " + student.Moadel() + "  , moadel3: " + student.Moadel3() + "  , :" + $"\nmoadel2 : {student.Moadel2()}" + "  , moadel1  : " + student.Moadel1());
                switch (student.Moadel())
                {
                    case double n when n > 17:
                        Console.WriteLine(" ,  Grade:   A");
                        break;
                    case double n when n > 15 && n <= 17:
                        Console.WriteLine(" ,  Grade:   B");
                        break;
                    case double n when n > 13 && n <= 15:
                        Console.WriteLine(" ,  Grade:   C");
                        break;
                    case double n when n > 10 && n <= 13:
                        Console.WriteLine(" ,  Grade:   D");
                        break;
                    case double n when n > 7 && n <= 10:
                        Console.WriteLine(" ,  Grade:   E");
                        break;
                    case double n when n > 3 && n <= 7:
                        Console.WriteLine(" ,  Grade:   F");
                        break;
                    case double n when n <= 3:
                        Console.WriteLine(" ,  Grade:   G");
                        break;
                }
            }
            break;
        case 6:
            {
                foreach (var student in students)
                {
                    int x = Convert.ToInt32(student.Moadel());
                    if (x < 2) Console.WriteLine(student.NAMES() + " moadel aval nist");
                    for (int i = 2; i <= x; i++)
                    {
                        if (x % i == 0) ; Console.WriteLine(student.NAMES() + " moadel aval nist");
                    }
                    Console.WriteLine(student.NAMES() + ":  " + x);
                }
            }
            break;
        case 7:
            foreach (var student in students)
            {
                switch (student.Moadel())
                {
                    case double n when n > 17:
                        Console.WriteLine(student.NAMES() + " Grade:  A")
                    ;
                        break;
                    case double n when n > 15 && n <= 17:
                        Console.WriteLine(student.NAMES() + " Grade:  B");

                        break;
                    case double n when n > 13 && n <= 15:
                        Console.WriteLine(student.NAMES() + " Grade:  C");

                        break;
                    case double n when n > 10 && n <= 13:
                        Console.WriteLine(student.NAMES() + " Grade:  D");

                        break;
                    case double n when n > 7 && n <= 10:
                        Console.WriteLine(student.NAMES() + " Grade:  E");

                        break;
                    case double n when n > 3 && n <= 7:
                        Console.WriteLine(student.NAMES() + " :  F");

                        break;
                    case double n when n <= 3:
                        Console.WriteLine(student.NAMES() + " :  G");

                        break;
                }
            }
            break;
        case 8:
            Console.WriteLine("TAMAM");
            break;
    }
    Console.WriteLine("\nwant to countinio?(y/n)");
    string A = Convert.ToString(Console.ReadLine());
    if (A == "y")
    { javab = true; }
    else { javab = false; }
} while (javab);

