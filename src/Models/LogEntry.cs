using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineActivityLogger.src.Models
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Editor { get; set; }
        public int UserLevel { get; set; }
        public string Tag { get; set; }
        public int EditLevel { get; set; }
        public string Content { get; set; }
        public string ActionType { get; set; }

        public override string ToString()
        {
            return $"[{Timestamp:yyyy-MM-dd HH:mm:ss}] | Editor: {Editor} | UserLevel: {UserLevel} | Tag: {Tag} | EditLevel: {EditLevel} | ActionType: {ActionType} | Content: {Content}";
        }


    }
}
