using Labb2_LINQ.DbQueries;

internal class Program
{
    static void Main(string[] args)
    {
        bool showMenu = true;

        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }
    static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Get teacher by course name");
        Console.WriteLine("2. Get every class and their teachers");
        Console.WriteLine("3. Get teacher and students by course name");
        Console.WriteLine("4. Change course name");
        Console.WriteLine("5. Change teacher for course");

        switch (Console.ReadLine())
        {
            case "1":
                GetTeacherByCourseNameMenu();
                return true;
            case "2":
                GetEveryStudentAndTeacherMenu();
                return true;
            case "3":
                GetStudentsAndTeacherByCourseName();
                return true;
            case "4":
                EditCourseNameMenu();
                return true;
            case "5":
                EditTeacherForCourseMenu();
                return true;
            default:
                return true;
        }
    }
    static void GetTeacherByCourseNameMenu()
    {
        Console.Clear();
        Console.WriteLine("Enter course:");
        var res = DbHandler.GetTeacherByCourseName(Console.ReadLine()!);
        Console.WriteLine(res);
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    static void GetEveryStudentAndTeacherMenu()
    {
        Console.Clear();
        var res = DbHandler.GetEveryStudentAndTeacher();

        foreach (var item in res)
        {
            System.Type type = item.GetType();
            string? className = type.GetProperty("classNames")!.GetValue(item, null) as string;
            List<string>? studentNames = type.GetProperty("studentNames")!.GetValue(item, null) as List<string>;
            List<string>? teacherNames = type.GetProperty("teacherNames")!.GetValue(item, null) as List<string>;

            Console.WriteLine(className);
            Console.WriteLine(" ");
            Console.WriteLine("Teachers:");
            teacherNames!.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(" ");
            Console.WriteLine("Students:");
            studentNames!.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------");
        }
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    static void GetStudentsAndTeacherByCourseName()
    {
        Console.Clear();
        Console.WriteLine("Search: ");
        var res = DbHandler.GetStudentsByCourseName(Console.ReadLine()!);
        Console.Clear();
        System.Type type = res.GetType();
        List<string>? studentNames = (List<string>)type.GetProperty("studentNames")!.GetValue(res, null)!;
        List<string>? teacherNames = (List<string>)type.GetProperty("teacherNames")!.GetValue(res, null)!;

        string courseName = (string)type.GetProperty("courseName")!.GetValue(res, null)!;

        Console.WriteLine(courseName);
        Console.WriteLine("--------");
        Console.WriteLine("Teachers:");

        foreach (string teacherName in teacherNames)

        Console.WriteLine(teacherName);
        Console.WriteLine(" ");
        Console.WriteLine("Students:");

        foreach (string studentName in studentNames)

        Console.WriteLine(studentName);
        Console.WriteLine(" ");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
        Console.Clear();
    }
    static void EditCourseNameMenu()
    {
        Console.Clear();
        Console.WriteLine("Enter course name:");

        var success = DbHandler.ChangeCourseName(Console.ReadLine()!);
        if (success)
            Console.WriteLine("Name changed. Press any key to return");
        Console.ReadKey();
    }
    static void EditTeacherForCourseMenu()
    {
        Console.Clear();
        Console.WriteLine("Enter course name:");
        var success = DbHandler.ChangeTeacherForCourse(Console.ReadLine()!);
        if (success)
            Console.WriteLine("Teacher changed. Press any key to return");
        Console.ReadKey();
    }
}
