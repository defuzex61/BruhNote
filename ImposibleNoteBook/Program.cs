namespace ImposibleNoteBook
{
    internal class Program
    {
            static void Main(string[] args)
            {
 
            int position = 2;// это опять кринжатина полная...
                Menu();
                
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;

                    }

                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;

                    }

                    Console.Clear();
                    Menu();
                    Console.SetCursorPosition(0, position);
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        Day();
                    }
                }    
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        Next_Day();
                }
                    if (key.Key == ConsoleKey.LeftArrow)
                {
                    Menu();
                }
               
                Console.WriteLine("->");
            }
                    
                

            }
            static void Menu()
            {
            Console.Clear();
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("  Заметки");
               
            }
        static void Day()
        {
            DateTime date = new DateTime(2022,11,07);
           
            int position = 1;
            Note Frst_Note = new Note();
            Frst_Note.date = date;
            Frst_Note.Name = "  Погулять с другалечками";
            Frst_Note.Description = "  Отправиться гулять на улицу к другалечкам чтоб погулять на улице, подышать воздухом там свежим";
            Note Scnd_Note = new Note();
            Scnd_Note.date = date;
            Scnd_Note.Name = "  Поигрулькать в компик";
            Scnd_Note.Description = "  Зачиться за компиком";
            
            Console.WriteLine(Frst_Note.Name);
            Console.WriteLine(Scnd_Note.Name);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }

                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine(Frst_Note.Name);
                Console.WriteLine(Scnd_Note.Name);
                Console.SetCursorPosition(0, position);
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Frst_Note.date);
                        Console.WriteLine(Frst_Note.Name);
                        Console.WriteLine(Frst_Note.Description);
                    }
                    else if (position == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Scnd_Note.date);
                        Console.WriteLine(Scnd_Note.Name);
                        Console.WriteLine(Scnd_Note.Description);
                    }
                    break;
                }
                Console.WriteLine("->");
            }
        }
            static void Next_Day()
        {
            Console.Clear();
            DateTime date = new DateTime(2022, 11, 08);
            Console.WriteLine(DateTime.UtcNow);
            int position = 1;
            Note Frst_Note = new Note();
            Frst_Note.date=date;
            Frst_Note.Name = "  Чилл";
            Frst_Note.Description = "  На данный момент главная задача это чилл";
            Note Scnd_Note = new Note();
            Scnd_Note.date = date;
            Scnd_Note.Name = "  Учимся";
            Scnd_Note.Description = "  Разчилиться и пойти поучиться что-ли";
            Note Thrd_Note = new Note();
            Thrd_Note.date = date;
            Thrd_Note.Name = "  Сидеть флка";
            Thrd_Note.Description = "  Сидеть киберспортивно флка";

            Console.WriteLine(Frst_Note.Name);
            Console.WriteLine(Scnd_Note.Name);
            Console.WriteLine(Thrd_Note.Name);
          
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }

                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine(Frst_Note.Name);
                Console.WriteLine(Scnd_Note.Name);
                Console.WriteLine(Thrd_Note.Name);

                Console.SetCursorPosition(0, position);
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Frst_Note.date);
                        Console.WriteLine(Frst_Note.Name);
                        Console.WriteLine(Frst_Note.Description);
                    }
                    else if (position == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Scnd_Note.date);
                        Console.WriteLine(Scnd_Note.Name);
                        Console.WriteLine(Scnd_Note.Description);
                    }
                    else if(position == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Thrd_Note.date);
                        Console.WriteLine(Thrd_Note.Name);
                        Console.WriteLine(Thrd_Note.Description);
                    }
                    break;
                }
               
                Console.WriteLine("->");
            }
        }
      
           
   
    
       
    }
}