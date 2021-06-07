using System;
using System.Collections.Generic;
using System.Text;

namespace lab8.NotificationsAndLogs
{
    class Notify
    {
        public delegate void Message(string message);
        static public event Message NewMessage;

        static public void NoticeMeSenpai(string key)
        {
            switch (key)
            {
                case "Millitary":
                    NewMessage = (x) => { Console.WriteLine("\n millitary plane added \n"); };
                    NewMessage?.Invoke("\n millitary plane added \n");
                    break;

                case "Passenger":
                    NewMessage = delegate (string message)
                    {
                        Console.WriteLine("\n passenger plane added \n");
                    };
                    NewMessage?.Invoke("\n passenger plane added \n");
                    break;

                case "Cargo":
                    NewMessage = delegate (string message)
                    {
                        Console.WriteLine("\n cargo plane added \n");
                    };
                    NewMessage?.Invoke("\n cargo plane added \n");
                    break;

                default:
                    break;
            }
        }
    }
}
