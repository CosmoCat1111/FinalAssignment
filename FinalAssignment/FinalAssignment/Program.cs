﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{

class Program
        {
            static void Main(string[] args)
            {
                using (var context = new SchoolContext())
                {   
                    // Create and save a new Student
                    var student = new Student
                    {
                        FirstName = "Leah",
                        LastName = "Lisberg",
                        DateOfBirth = new DateTime(1982, 2, 2)
                    };

                    context.Students.Add(student);
                    context.SaveChanges();
                }

                Console.WriteLine("Student added successfully.");
                Console.ReadLine();
            }
        }

    }

