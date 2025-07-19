
using System;
using System.Threading.Tasks;

namespace DesignPatternsWithCSharpNet10.Solid.DependencyInversionPrinciple.Exercise
{
    public class Email : INotification
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public Task SendAsync()
        {
            Console.WriteLine("(INotification) Enviando Email...");
            Console.WriteLine($" - Subject: {Subject}\n - Content: {Content}");
            Console.WriteLine("Email enviado exitosamente!");
            return Task.CompletedTask;
        }
    }
}
