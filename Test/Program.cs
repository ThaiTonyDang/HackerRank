using System.Diagnostics;
using System.Management;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // Đường dẫn đến script diskpart
                string diskPartScriptPath = "create_partition.txt";

                // Tạo script để phân chia ổ đĩa
                System.IO.File.WriteAllText(diskPartScriptPath, @"
select disk 1
clean
create partition primary size=10240
assign letter=H
format fs=ntfs quick
");

                // Chạy diskpart với script
                ExecuteDiskPart(diskPartScriptPath);
            }

            static void ExecuteDiskPart(string scriptPath)
            {
                Process process = new Process();
                process.StartInfo.FileName = "diskpart.exe";
                process.StartInfo.Arguments = $"/s {scriptPath}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine(output);
            }
        }
    }
}
