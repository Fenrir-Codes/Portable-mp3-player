using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Portable_Mp3_Player
{
    class Mp3Player
    {
        private string playercommand;
        private bool isOpen;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwdCallBack);

        public void open(string FileName)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            playercommand = string.Format(Format, FileName);
            mciSendString(playercommand, null, 0, IntPtr.Zero);
        }

        public void play()
        {
                playercommand = "play MediaFile";
                mciSendString(playercommand, null, 0, IntPtr.Zero);      
        }

        public void stop()
        {
            playercommand = "close MediaFile";
            mciSendString(playercommand, null, 0, IntPtr.Zero);
            isOpen = false;
        }



    }
}
