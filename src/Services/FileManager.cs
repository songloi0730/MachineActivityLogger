using MachineActivityLogger.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MachineActivityLogger.src.Services
{
    public class FileManager
    {
        private string _desktopPath;
        private string _mainLogPath;
        private string _backupPath1;
        private string _backupPath2;


        public FileManager()
        {
            _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _mainLogPath = Path.Combine(_desktopPath, "log.logmachine");
            _backupPath1 = Path.Combine(_desktopPath, "log_b.logmachine");
            _backupPath2 = Path.Combine(_desktopPath, "log_c.logmachine");
        }

        public bool InitializeLogFile()
        {
            try
            {
                if (!File.Exists(_mainLogPath))
                {
                    //Create 3 log files with header
                    File.WriteAllText(_mainLogPath, "Machine Activity Log File\n");
                    File.WriteAllText(_backupPath1, "Machine Activity Log File - B\n");
                    File.WriteAllText(_backupPath2, "Machine Activity Log File - C\n");

                    File.SetAttributes(_mainLogPath,FileAttributes.ReadOnly);
                    File.SetAttributes(_backupPath1, FileAttributes.ReadOnly);
                    File.SetAttributes(_backupPath2, FileAttributes.ReadOnly);

                    //Can kiem tra lai xem file neu ton tai co gay loi hay yeu cau xoa khong
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing log file: {ex.Message}");
                return false;
            }
        }

        public void WriteLogToAllFile(LogEntry entry)
        {
            try
            {
                string logLine = entry.ToString() + Environment.NewLine;

                //Tạm bỏ readonly để ghi
                RemoveReadOnlyAttribute(_mainLogPath);
                RemoveReadOnlyAttribute(_backupPath1);
                RemoveReadOnlyAttribute(_backupPath2);

                File.AppendAllText(_mainLogPath, logLine);
                File.AppendAllText(_backupPath1, logLine);
                File.AppendAllText(_backupPath2, logLine);

                SetReadOnlyAttribute(_mainLogPath);
                SetReadOnlyAttribute(_backupPath1);
                SetReadOnlyAttribute(_backupPath2);


            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Loi ghi log: {ex.Message}");
            }
        }

        private void RemoveReadOnlyAttribute(string filePath)
        {
            if (File.Exists(filePath))
            {
            
                    FileAttributes attributes = File.GetAttributes(filePath);
                    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                    }
                
            }

        }

        private void SetReadOnlyAttribute(string filePath)
        {
            if(File.Exists(filePath))
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly);
            }
        }

        public List<LogEntry> ReadLogFile(string filePath)
        {
            var logs = new List<LogEntry>();
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line) & !line.StartsWith('#'))
                        {
                            logs.Add(LogEntry.FromString(line));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi doc file: {ex.Message}");
            }
            return logs;
        }

    }
}
