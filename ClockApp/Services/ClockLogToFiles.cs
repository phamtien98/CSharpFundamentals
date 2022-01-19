using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClockApp
{
    public class ClockLogToFiles
    {
        public void Subcribe(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(WriteToFile);
        }
        public void WriteToFile(object clock, TimeInfoEventArgs args)
        {
            String outputString = "Time:" + args.hour + ":" + args.minute + ":" + args.second;
            
            using (FileStream fileStream = new FileStream("Log.txt", FileMode.Append))
            {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(outputString);
                streamWriter.Flush();
            }

            using (FileStream writer = new FileStream("Log1.txt", FileMode.Append))
            {
                byte[] bytes = new System.Text.UTF8Encoding(true).GetBytes(outputString);
                writer.Write(bytes,0,bytes.Length);

            } 
        }
    }
}