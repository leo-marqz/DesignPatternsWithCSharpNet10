using DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple;
using System;

namespace DesignPatternsWithCSharpNet10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient { 
                Name = "John Doe", 
                Email = "jdoe@gmail.com", 
                PhoneNumber = "123-456-7890" 
            };

            var appointment = new Appointment
            {
                Patient = patient,
                // Schedule for tomorrow
                Date = DateTime.Now.AddDays(3).AddHours(3)
            };

            var info = new AppointmentService()
                                .ScheduleAppointment(appointment);

            Console.WriteLine(info);
        }
    }
}
