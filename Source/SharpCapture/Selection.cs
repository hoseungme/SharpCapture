using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace SharpCapture
{
    public partial class Selection : Form
    {
        private struct POINT
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        [DllImport("user32.dll")]
        private static extern int GetCursorPos(out POINT Point);
        [DllImport("user32.dll")]
        private static extern uint GetAsyncKeyState(int Key);

        private SharpCaptureMain OwnerForm;

        private Point StartLocation;
        private Point NewLocation;
        private POINT CursorPos;

        private Thread GetMouseCursorThread;

        private void FormClose()
        {
            GetMouseCursorThread.Abort();
            if(Size.Width > 0 && Size.Height > 0)
            {
                OwnerForm.SelectionCapturePos = Location;
                OwnerForm.CaptureSize = Size;
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void GetMouseCursor()
        {
            while(true)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    GetCursorPos(out CursorPos);

                    if (CursorPos.x < StartLocation.X)
                    {
                        if (CursorPos.y > StartLocation.Y)
                        {
                            NewLocation = new Point(CursorPos.x, StartLocation.Y);
                            Location = NewLocation;
                        }
                        else
                        {
                            NewLocation = new Point(CursorPos.x, CursorPos.y);
                            Location = NewLocation;
                        }
                    }
                    else
                    {
                        if (CursorPos.y < StartLocation.Y)
                        {
                            NewLocation = new Point(StartLocation.X, CursorPos.y);
                            Location = NewLocation;
                        }
                        else
                        {
                            Location = StartLocation;
                        }
                    }
                    Width = Math.Abs(CursorPos.x - StartLocation.X);
                    Height = Math.Abs(CursorPos.y - StartLocation.Y);

                    if ((GetAsyncKeyState(0x01) & 0x8000) != 0x8000)
                    {
                        FormClose();
                    }
                }));
            }
        }

        public Selection(Point StartLocation)
        {
            SetProcessDPIAware();
            InitializeComponent();
            this.StartLocation = StartLocation;
        }

        private void Selection_Load(object sender, EventArgs e)
        {
            OwnerForm = (SharpCaptureMain)Owner;
            Width = 100;
            Height = 100;
            Location = StartLocation;

            GetMouseCursorThread = new Thread(GetMouseCursor)
            {
                IsBackground = true
            };
            GetMouseCursorThread.Start();
        }
    }
}