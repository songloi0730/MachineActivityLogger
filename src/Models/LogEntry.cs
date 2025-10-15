using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            return $"[{Timestamp:yyyy-MM-dd HH:mm:ss}] \nEditor: {Editor} | UserLevel: {UserLevel} \nTag: {Tag} | EditLevel: {EditLevel} | ActionType: {ActionType} \nContent: {Content}";
        }

        //public static LogEntry FromString(string logLine)
        //{
        //    try
        //    {
        //        var parts = logLine.Split(new[] { " | " }, StringSplitOptions.None);
        //        var timestampPart = parts[0].Trim('[', ']');
        //        var timestamp = DateTime.ParseExact(timestampPart, "yyyy-MM-dd HH:mm:ss", null);
        //        var editor = parts[1].Split(new[] { ": " }, StringSplitOptions.None)[1];
        //        var userLevel = int.Parse(parts[2].Split(new[] { ": " }, StringSplitOptions.None)[1]);
        //        var tag = parts[3].Split(new[] { ": " }, StringSplitOptions.None)[1];
        //        var editLevel = int.Parse(parts[4].Split(new[] { ": " }, StringSplitOptions.None)[1]);
        //        var actionType = parts[5].Split(new[] { ": " }, StringSplitOptions.None)[1];
        //        var content = parts[6].Split(new[] { ": " }, StringSplitOptions.None)[1];
        //        return new LogEntry
        //        {
        //            Timestamp = timestamp,
        //            Editor = editor,
        //            UserLevel = userLevel,
        //            Tag = tag,
        //            EditLevel = editLevel,
        //            ActionType = actionType,
        //            Content = content
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new FormatException("Invalid log line format.", ex);
        //    }
        //}

        public static LogEntry FromString(string logLine)
        {
            var parts = logLine.Split('|');
            return new LogEntry
            {
                Timestamp = DateTime.Parse(parts[0].Trim('[', ']')),
                Editor = parts[1],
                UserLevel = int.Parse(parts[2]),
                Tag = parts[3],
                EditLevel = int.Parse(parts[4]),
                ActionType = parts[5],
                Content = parts[6]
            };
        }
    }
}
