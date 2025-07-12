
using System;
using System.Collections.Generic;

namespace DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple.Exercise
{
    public class CourseReport
    {
        public List<CourseReportEntry> Entries { get; private set; } = new List<CourseReportEntry>();

        public void AddEntry(CourseReportEntry entry)
        {
            if(entry is null)
            {
                throw new ArgumentNullException(nameof(entry), "Entry cannot be null");
            }
            Entries.Add(entry);
        }

        public override string ToString()
        {
            var report = "Course Report:\n";
            foreach (var entry in Entries)
            {
                report += $" - Course: {entry.Name}, Students: {entry.Students}, Rating: {entry.Rating}\n";
            }
            return report;
        }
    }
}
