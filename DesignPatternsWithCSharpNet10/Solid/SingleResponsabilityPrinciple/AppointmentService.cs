
using System;

namespace DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple
{
    public class AppointmentService
    {
        public string ScheduleAppointment(Appointment appointment)
        {
            var validation = AppointmentValidator.Validate(appointment);

            return validation.IsValid
                ? $" - Appointment scheduled for {appointment.Date} with {appointment.Patient.Name}."
                : string.Join(Environment.NewLine, validation.Errors);

        }
    }
}
