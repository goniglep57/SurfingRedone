﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SurfingRedone;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurfData db = new SurfData();//creating the DB

            using (db)
            {
                //create some objects
                Teacher t1 = new Teacher() { TeacherID = 1, TName = "Andy Irons", Image = "\\images\\Surf-Instructors\\andyIrons.jpg " };
                Teacher t2 = new Teacher() { TeacherID = 2, TName = "Kelly Slater", Image = "\\images\\Surf-Instructors\\kellySlater.jpg " };
                Teacher t3 = new Teacher() { TeacherID = 3, TName = "Rickson Gracie", Image = "\\images\\Surf-Instructors\\ricksonGracie.jpg " };


                Beach b1 = new Beach() { BeachID = 1, BName = "Culdaff", Image = "\\images\\Beaches\\culdaff-beach.jpg" };
                Beach b2 = new Beach() { BeachID = 2, BName = "Ballyliffin", Image = "\\images\\Beaches\\ballyliffinBeach.jpg" };
                Beach b3 = new Beach() { BeachID = 3, BName = "Leenan", Image = "\\images\\Beaches\\Leenan-Beach.jpg" };
                Beach b4 = new Beach() { BeachID = 4, BName = "Tullagh", Image = "\\images\\Beaches\\tullaghBeach.jpg" };
                

                User user1 = new User() {UserID =1, FirstName = "Paul", Surname = "Mc Gonigle", UserName = "admin", Password = "123" };

                Lesson lesson1 = new Lesson() { LessonID = 1, Date = DateTime.Now, Length = "1 Hour", Teacher = t1,  };

                Board board1 = new Board() { BoardID = 1, Colour = "Red", Type = "Short", Weight = 70, ImageURL = "\\images\\SurfBoards\\Board1.jpg" };

                //add to DB
                
                db.Teachers.Add(t1);
                db.Teachers.Add(t2);
                db.Teachers.Add(t3);

                Console.WriteLine("Added teams to DB");
                db.Beaches.Add(b1);
                db.Beaches.Add(b2);
                db.Beaches.Add(b3);
                db.Beaches.Add(b4);

                Console.WriteLine("Added Players to DB");

                db.Boards.Add(board1);
                Console.WriteLine("Added Boards");

                db.Users.Add(user1);
                Console.WriteLine("Added Users");

                db.Lessons.Add(lesson1);
                Console.WriteLine("Added Lessons");


                //save changes

                db.SaveChanges();

                Console.WriteLine("Saved changes to DB");

                Console.ReadLine();
            }
        }
    }
}