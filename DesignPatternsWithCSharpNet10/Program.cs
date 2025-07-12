using DesignPatternsWithCSharpNet10.Helpers;
using DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple;
using DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple;
using DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple.Exercise;
using Spectre.Console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsWithCSharpNet10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=====================================================================
            // Ejemplo #1 de Open Closed Principle
            //=====================================================================

            List<IApplicant> applicants = new List<IApplicant>() {
                new Person{ FirstName="Rodrigo", LastName="Morales" },
                new Doctor { FirstName="Miguel", LastName="Sandoval" },
                new Nurse{ FirstName="Robert", LastName="Martin" },
                new SoftwareEngineer { FirstName = "Elmer", LastName = "Marquez" }
            };

            List<Staff> staffs = new List<Staff>();

            foreach(IApplicant applicant in applicants)
            {
                staffs.Add(applicant.Processor.Create(applicant));
            }

            var table = new Table();
            table.AddColumn("Nombre");
            table.AddColumn("Apellido");
            table.AddColumn("Email");
            table.AddColumn("Rol");

            foreach(Staff staff in staffs)
            {
                table.AddRow(staff.FirstName, staff.LastName, staff.Email, staff.Role.GetDisplayName());
            }

            AnsiConsole.Write(table);

            Console.ReadKey();

            //======================================================================
            //Ejemplo #2 de Single Responsibility Principle (SRP)
            //======================================================================

            //var mathCourse = new CourseReportEntry { Name = "Math", Students = 30, Rating = 4.5 };
            //var scienceCourse = new CourseReportEntry { Name = "Science", Students = 25, Rating = 4.0 };
            //var historyCourse = new CourseReportEntry { Name = "History", Students = 20, Rating = 3.5 };

            //var report = new CourseReport();
            //report.AddEntry(mathCourse);
            //report.AddEntry(scienceCourse);
            //report.AddEntry(historyCourse);

            //var fileSaver = new FileSaver();
            //var result = fileSaver.Save("Reports", "CourseReport_15062025.txt", report);

            //if (!result)
            //{
            //    Console.WriteLine("Failed to save course report.");
            //    return;
            //}

            //Console.WriteLine("Course report saved successfully.");

            //======================================================================
            //Ejemplo #1 de Single Responsibility Principle (SRP)
            //======================================================================

            //var patient = new Patient { 
            //    Name = "John Doe", 
            //    Email = "jdoe@gmail.com", 
            //    PhoneNumber = "123-456-7890" 
            //};

            //var appointment = new Appointment
            //{
            //    Patient = patient,
            //    // Schedule for tomorrow
            //    Date = DateTime.Now.AddDays(3).AddHours(3)
            //};

            //var info = new AppointmentService()
            //                    .ScheduleAppointment(appointment);

            //Console.WriteLine(info);
        }
    }
}
