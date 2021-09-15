using System;
using System.Collections.Generic;
using System.Linq;

namespace DatePeriodsConsoleNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2021, 02, 15);
            DateTime endDate = new DateTime(2021, 08, 18);
            List<Period> periodsList = new List<Period>();

            for (DateTime index = startDate; index < endDate; index = index.AddMonths(1))
            {
                periodsList.Add(new Period()
                {
                    FromDate = new[]
                    {
                        new DateTime(index.Year, index.Month, 1), startDate
                    }.Max(), 
                    ToDate = new[]
                    {
                        new DateTime(index.Year, index.Month, 1).AddMonths(1).AddDays(-1), endDate
                    }.Min()
                });
            }

            foreach (Period period in periodsList)
            {
                Console.WriteLine($"From: {period.FromDate:MM/dd/yyyy}  | To: {period.ToDate:MM/dd/yyyy}");
            }

            Console.ReadLine();
        }


    }



    }
    public class Period
    {
        public DateTime FromDate;
        public DateTime ToDate;
    }
}
