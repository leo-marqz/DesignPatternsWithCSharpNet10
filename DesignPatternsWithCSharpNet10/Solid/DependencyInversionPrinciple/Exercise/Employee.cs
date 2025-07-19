
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsWithCSharpNet10.Solid.DependencyInversionPrinciple.Exercise
{
    public class Employee
    {
        private List<INotification> _notifications;

        public Employee(List<INotification> notifications)
        {
            _notifications = notifications;

        }

        public async Task SendNotificationAsync()
        {
            foreach(var notification in _notifications)
            {
                await notification.SendAsync();
                Console.WriteLine();
            }
        }
    }
}
