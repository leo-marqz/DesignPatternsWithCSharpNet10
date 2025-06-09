
using System;

namespace DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple
{
    public static class AppointmentValidator
    {
        public static ValidatorResult Validate(Appointment appointment)
        {
            var validation = new ValidatorResult();

            //patiendt validation
            if (appointment.Patient is null)
            {
                validation.Errors.Add(" - Patient is required.");
            }
            if (string.IsNullOrEmpty(appointment.Patient.Name))
            {
                validation.Errors.Add(" - Patient name is required.");
            }
            if (string.IsNullOrEmpty(appointment.Patient.Email))
            {
                validation.Errors.Add(" - Patient email is required.");
            }
            if (!appointment.Patient.Email.Contains("@"))
            {
                validation.Errors.Add(" - Patient email is not valid.");
            }
            if (string.IsNullOrEmpty(appointment.Patient.PhoneNumber))
            {
                validation.Errors.Add(" - Patient phone number is required.");
            }

            //appointment date validation
            if (appointment.Date == default(DateTime))
            {
                validation.Errors.Add(" - Appointment date is required.");
            }
            else if (appointment.Date <= DateTime.Now)
            {
                validation.Errors.Add(" - Appointment date cannot be in the past.");
            }

            return validation;
        }
    }
}
