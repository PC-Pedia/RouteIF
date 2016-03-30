using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace RouteIF
{
    public class Command
    {
        static public string ExecuteCmd(string arguments)
        {
            string output;
            // Start the child process.
            using (Process p = new Process())
            {
                // Redirect the output stream of the child process.
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                //p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c " + arguments;
                p.Start();
                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }
            return output;
        }

        static public string GetValue(string line)
        {
            return line.Split(':')[1].Trim();
        }

        static public IEnumerable<NetInterface> GetNetInterfaces()
        {
            string output = ExecuteCmd("ipconfig /all");
            using (StringReader reader = new StringReader(output))
            {
                string line;
                bool bDescriptionFound = false;
                NetInterface netInterface = null;
                while ((line = reader.ReadLine()) != null)
                {
                    if (bDescriptionFound)
                    {
                        if (line.Contains("Default Gateway"))
                        {
                            netInterface.DefaultGateway = GetValue(line);
                            bDescriptionFound = false;
                            yield return netInterface;
                        }
                    }
                    else if (line.Contains("Description"))
                    {
                        netInterface = new NetInterface();
                        netInterface.Description = GetValue(line);
                        bDescriptionFound = true;
                    }
                }
            }
        }

        static public string GetDefaultGetway()
        {
            string output = ExecuteCmd("route print");
            using (StringReader reader = new StringReader(output))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("0.0.0.0"))
                    {
                        return line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)[2].Trim();
                    }
                }
            }
            return string.Empty;
        }

        static public bool SetDefaultGetway(string sDefaultGetway)
        {
            string output = ExecuteCmd("route change 0.0.0.0 mask 0.0.0.0 " + sDefaultGetway);
            return output.Contains("OK!");
        }
    }
}
