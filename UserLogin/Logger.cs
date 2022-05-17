using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
  

        static public void LogActivity(string activity) {


            string activityLine = DateTime.Now + ";" + LoginValidation.currentUserUsername + ";"
                + LoginValidation.currentUserRole + ";" + activity;
            File.AppendAllText("C:\\Users\\wasko\\source\\repos\\VasilMihailov\\UserLogin\\bin\\Debug\\logInfo.txt"
                , activityLine+Environment.NewLine, Encoding.UTF8);
            currentSessionActivities.Add(activityLine);


        }

       static public IEnumerable<string> ReadFromLogFile()
        {
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader("C:\\Users\\wasko\\source\\repos\\VasilMihailov\\UserLogin\\bin\\Debug\\logInfo.txt");
            string line;
            while ((line = reader.ReadLine()) != null) {
                lines.Add(line);
            }
            reader.Close();
            return lines;

        }

        static public IEnumerable<string> GetCurrentSessionActivities(string filter) {

            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();
            
            return filteredActivities;

        }
    }
}
