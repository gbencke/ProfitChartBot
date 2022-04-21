using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ProfitChartBotScanner
{
    public class ProfitChartClickHelper
    {
        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

#pragma warning restore 649


        public static void ClickOnPoint(Point clientPoint)
        {
            var oldPos = Cursor.Position;

            /// get screen coordinates
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0; /// input type mouse
            inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0; /// input type mouse
            inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            Thread.Sleep(100);

            Cursor.Position = new Point(1, 1);

            /// return mouse 
        }

        public static void ClickOnPoint(int x, int y)
        {
            ClickOnPoint(new Point(x, y));
        }

        private ProfitChartBotMLBasedConfiguration _configuration;

        public ProfitChartClickHelper(ProfitChartBotMLBasedConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendOpenLongPositionClick()
        {
            ClickOnPoint(new Point(_configuration.StartLongPosition.X, _configuration.StartLongPosition.Y));
        }
        public void SendOpenShortPositionClick()
        {
            ClickOnPoint(new Point(_configuration.StartShortPosition.X, _configuration.StartShortPosition.Y));
        }
        public void SendOpenCloseAllPositionsClick()
        {
            ClickOnPoint(new Point(_configuration.ClosePositions.X, _configuration.ClosePositions.Y));
        }
    }
}
