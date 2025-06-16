
using System.IO;

namespace DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple.Exercise
{
    public class FileSaver
    {
        public bool Save(string directoryPath, string filename, CourseReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, filename), report.ToString());

            return true;
        }
    }
}
