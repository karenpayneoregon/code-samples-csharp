using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LogLibrary;

namespace GeneralExperimentsWithTrace.Classes
{
    public class Reader
    {
        public List<string> GetLines()
        {
            try
            {
                return File.ReadAllLines("FileHere.txt").ToList();
            }
            catch (Exception e)
            {
                ApplicationTraceListener.Instance.Exception(e);

                return new List<string>();
            }
        }
    }
}
