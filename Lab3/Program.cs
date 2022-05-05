using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsApp3Asteroids
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form
            {
                Width = 1024,
                Height = 768,
                Text = " \"Астероиды\"",
                StartPosition = FormStartPosition.CenterScreen,
            };
            Game.DebugMessage += ConsoleMessage;
            Game.DebugMessage += FileMessage;
            Game.Init(form);
            Application.Run(form);
        }

        static void ConsoleMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        static void FileMessage(string msg)
        {
            using (StreamWriter fout = new StreamWriter(new FileStream("log.log", FileMode.Append, FileAccess.Write)))
            {
                fout.WriteLine(msg);
            }
        }
    }
}
