using System;
using System.Windows.Forms;
using SharpDX.XInput;
using Memory;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using fragment_shortcut_overlay.Helpers;

namespace fragment_shortcut_overlay
{
    public partial class frm_Main : Form
    {
     
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        Controller controller;
        bool controllerConnected = false;
        int gGameOffset;
        Mem m = new Mem();
        private const string PCSX2PROCESSNAME = "pcsx2";
        bool pcsx2Running = false;
        bool pressedInit = false;

        public frm_Main()
        {
            InitializeComponent();
          
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
            this.TransparencyKey = Color.Linen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            controller = new Controller(UserIndex.One);
            controllerConnected = controller.IsConnected;
        }

        private void tmr_PCSX2Check_Tick(object sender, EventArgs e)
        {
            Process[] pcsx2 = Process.GetProcessesByName(PCSX2PROCESSNAME);

            if (pcsx2.Length > 0)
            {
                pcsx2Running = true;
            }
            else
            {
                tmr_PCSX2Check.Enabled = false;
                MessageBox.Show("PCSX2 not detected. Closing.");          
                this.Close();
            }
        }

        
       
        private void tmr_ReadPad_Tick(object sender, EventArgs e)
        {
            if(controllerConnected)
            {
                if (pcsx2Running)
                {
                    m.OpenProcess(PCSX2PROCESSNAME + ".exe");

                    if (m.ReadByte(GameHelper.CONNECTED_TO_AS_ADDRESS) == 1)
                    {
                        var state = controller.GetState();

                        var buttonsPressed = state.Gamepad.Buttons;
                       
                        if (buttonsPressed.HasFlag(GamepadButtonFlags.LeftShoulder))
                        {
                            if (pressedInit == false)
                            {
                                pct_TriggerButton.Image = Properties.Resources.L1;
                                pnl_Buttons.Visible = true;
                                processGameData(GameHelper.SHORTCUT_L1_CIRCLE_TYPE_ID, GameHelper.SHORTCUT_L1_TRIANGLE_TYPE_ID, GameHelper.SHORTCUT_L1_SQUARE_TYPE_ID,
                                    GameHelper.SHORTCUT_L1_X_TYPE_ID, GameHelper.SHORTCUT_L1_CIRCLE_CATEGORY_ID, GameHelper.SHORTCUT_L1_TRIANGLE_CATEGORY_ID,
                                    GameHelper.SHORTCUT_L1_SQUARE_CATEGORY_ID, GameHelper.SHORTCUT_L1_X_CATEGORY_ID, GameHelper.SHORTCUT_L1_CIRCLE_ID,
                                    GameHelper.SHORTCUT_L1_TRIANGLE_ID, GameHelper.SHORTCUT_L1_SQUARE_ID, GameHelper.SHORTCUT_L1_X_ID, GameHelper.SHORTCUT_L1_CIRCLE_MESSAGE,
                                    GameHelper.SHORTCUT_L1_TRIANGLE_MESSAGE, GameHelper.SHORTCUT_L1_SQUARE_MESSAGE, GameHelper.SHORTCUT_L1_X_MESSAGE);


                                pressedInit = true;
                            }

                        }
                        else if (state.Gamepad.LeftTrigger > 10)
                        {
                            if (pressedInit == false)
                            {
                                pct_TriggerButton.Image = Properties.Resources.L2;
                                pnl_Buttons.Visible = true;
                                processGameData(GameHelper.SHORTCUT_L2_CIRCLE_TYPE_ID, GameHelper.SHORTCUT_L2_TRIANGLE_TYPE_ID, GameHelper.SHORTCUT_L2_SQUARE_TYPE_ID,
                                    GameHelper.SHORTCUT_L2_X_TYPE_ID, GameHelper.SHORTCUT_L2_CIRCLE_CATEGORY_ID, GameHelper.SHORTCUT_L2_TRIANGLE_CATEGORY_ID,
                                    GameHelper.SHORTCUT_L2_SQUARE_CATEGORY_ID, GameHelper.SHORTCUT_L2_X_CATEGORY_ID, GameHelper.SHORTCUT_L2_CIRCLE_ID,
                                    GameHelper.SHORTCUT_L2_TRIANGLE_ID, GameHelper.SHORTCUT_L2_SQUARE_ID, GameHelper.SHORTCUT_L2_X_ID, GameHelper.SHORTCUT_L2_CIRCLE_MESSAGE,
                                    GameHelper.SHORTCUT_L2_TRIANGLE_MESSAGE, GameHelper.SHORTCUT_L2_SQUARE_MESSAGE, GameHelper.SHORTCUT_L2_X_MESSAGE);


                                pressedInit = true;
                            }
                        }
                        else if (buttonsPressed.HasFlag(GamepadButtonFlags.RightShoulder))
                        {
                            if (pressedInit == false)
                            {
                                pct_TriggerButton.Image = Properties.Resources.R1;
                                pnl_Buttons.Visible = true;
                                processGameData(GameHelper.SHORTCUT_R1_CIRCLE_TYPE_ID, GameHelper.SHORTCUT_R1_TRIANGLE_TYPE_ID, GameHelper.SHORTCUT_R1_SQUARE_TYPE_ID,
                                    GameHelper.SHORTCUT_R1_X_TYPE_ID, GameHelper.SHORTCUT_R1_CIRCLE_CATEGORY_ID, GameHelper.SHORTCUT_R1_TRIANGLE_CATEGORY_ID,
                                    GameHelper.SHORTCUT_R1_SQUARE_CATEGORY_ID, GameHelper.SHORTCUT_R1_X_CATEGORY_ID, GameHelper.SHORTCUT_R1_CIRCLE_ID,
                                    GameHelper.SHORTCUT_R1_TRIANGLE_ID, GameHelper.SHORTCUT_R1_SQUARE_ID, GameHelper.SHORTCUT_R1_X_ID, GameHelper.SHORTCUT_R1_CIRCLE_MESSAGE,
                                    GameHelper.SHORTCUT_R1_TRIANGLE_MESSAGE, GameHelper.SHORTCUT_R1_SQUARE_MESSAGE, GameHelper.SHORTCUT_R1_X_MESSAGE);


                                pressedInit = true;
                            }

                        }
                        else if (state.Gamepad.RightTrigger > 10)
                        {
                            if (pressedInit == false)
                            {
                                pct_TriggerButton.Image = Properties.Resources.R2;
                                pnl_Buttons.Visible = true;
                                processGameData(GameHelper.SHORTCUT_R2_CIRCLE_TYPE_ID, GameHelper.SHORTCUT_R2_TRIANGLE_TYPE_ID, GameHelper.SHORTCUT_R2_SQUARE_TYPE_ID,
                                    GameHelper.SHORTCUT_R2_X_TYPE_ID, GameHelper.SHORTCUT_R2_CIRCLE_CATEGORY_ID, GameHelper.SHORTCUT_R2_TRIANGLE_CATEGORY_ID,
                                    GameHelper.SHORTCUT_R2_SQUARE_CATEGORY_ID, GameHelper.SHORTCUT_R2_X_CATEGORY_ID, GameHelper.SHORTCUT_R2_CIRCLE_ID,
                                    GameHelper.SHORTCUT_R2_TRIANGLE_ID, GameHelper.SHORTCUT_R2_SQUARE_ID, GameHelper.SHORTCUT_R2_X_ID, GameHelper.SHORTCUT_R2_CIRCLE_MESSAGE,
                                    GameHelper.SHORTCUT_R2_TRIANGLE_MESSAGE, GameHelper.SHORTCUT_R2_SQUARE_MESSAGE, GameHelper.SHORTCUT_R2_X_MESSAGE);

                                pressedInit = true;
                            }
                        }
                        else
                        {
                            pnl_Buttons.Visible = false;
                            pressedInit = false;
                        }
                    }

                }
            }
 
        }

        /// <summary>
        /// Takes the base address that was originally used for the program and subtracts the given offset from it and returns the new address as 
        /// a string.
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        private string CalculateNewAddress(string baseAddress, int offset)
        {
            return (int.Parse(baseAddress, System.Globalization.NumberStyles.HexNumber) - offset).ToString("X8");
        }

        private void processGameData(string cirTypeIDAddress, string triTypeIDAddress, string sqTypeIDAddress,string xTypeIDAddress,
            string cirCatIDAddress,string triCatIDAddress,string sqCatIDAddress,string xCatIDAddress,string cirIDAddress,string triIDAddress,
            string sqIDAddress,string xIDAddress,string cirMessageAddress,string triMessageAddress,string sqMessageAddress,string xMessageAddress)
        {
            int circleTypeID = m.ReadByte(CalculateNewAddress(cirTypeIDAddress,gGameOffset));
            int triangleTypeID = m.ReadByte(CalculateNewAddress(triTypeIDAddress,gGameOffset));
            int squareTypeID = m.ReadByte(CalculateNewAddress(sqTypeIDAddress,gGameOffset));
            int crossTypeID = m.ReadByte(CalculateNewAddress(xTypeIDAddress,gGameOffset));
            string circleCategoryID = m.ReadByte(CalculateNewAddress(cirCatIDAddress,gGameOffset)).ToString("X1");
            string triangleCategoryID = m.ReadByte(CalculateNewAddress(triCatIDAddress,gGameOffset)).ToString("X1");
            string squareCategoryID = m.ReadByte(CalculateNewAddress(sqCatIDAddress,gGameOffset)).ToString("X1");
            string crossCategoryID = m.ReadByte(CalculateNewAddress(xCatIDAddress,gGameOffset)).ToString("X1");
            string circleID = m.Read2Byte(CalculateNewAddress(cirIDAddress,gGameOffset)).ToString("X4");
            string triangleID = m.Read2Byte(CalculateNewAddress(triIDAddress,gGameOffset)).ToString("X4");
            string squareID = m.Read2Byte(CalculateNewAddress(sqIDAddress,gGameOffset)).ToString("X4");
            string crossID = m.Read2Byte(CalculateNewAddress(xIDAddress,gGameOffset)).ToString("X4");
            string circleMessage = ByteConverstionHelper.converyBytesToSJIS(m.ReadBytes(CalculateNewAddress(cirMessageAddress,gGameOffset), 20));
            string triangleMessag = ByteConverstionHelper.converyBytesToSJIS(m.ReadBytes(CalculateNewAddress(triMessageAddress,gGameOffset), 20));
            string squareMessage = ByteConverstionHelper.converyBytesToSJIS(m.ReadBytes(CalculateNewAddress(sqMessageAddress,gGameOffset), 20));
            string crossMessage = ByteConverstionHelper.converyBytesToSJIS(m.ReadBytes(CalculateNewAddress(xMessageAddress,gGameOffset), 20));
            ShortCutIDModel SCIDM;

            // 1 = Spell, 2 = Item, 0 = Message
            
            if (circleTypeID == 1)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == circleID);
                lbl_Circle.Text = SCIDM._name;
            }else if(circleTypeID == 2)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == circleID && x._categoryID == circleCategoryID);
                lbl_Circle.Text = SCIDM._name;
            }else if(circleTypeID == 0)
            {
                lbl_Circle.Text = circleMessage;
            }
            else if (circleTypeID == 255)
            {
                lbl_Circle.Text = "Unused";
            }

            if (triangleTypeID == 1)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == triangleID);
                lbl_Triangle.Text = SCIDM._name;

            }
            else if (triangleTypeID == 2)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == triangleID && x._categoryID == triangleCategoryID);
                lbl_Triangle.Text = SCIDM._name;
            }
            else if (triangleTypeID == 0)
            {
                lbl_Triangle.Text = triangleMessag;
            }
            else if (triangleTypeID == 255)
            {
                lbl_Triangle.Text = "Unused";
            }

            if (squareTypeID == 1)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == squareID);
                lbl_Square.Text = SCIDM._name;

            }
            else if (squareTypeID == 2)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == squareID && x._categoryID == squareCategoryID);
                lbl_Square.Text = SCIDM._name;
            }
            else if (squareTypeID == 0)
            {
                lbl_Square.Text = squareMessage;
            }else if(squareTypeID == 255)
            {
                lbl_Square.Text = "Unused";
            }

            if (crossTypeID == 1)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == crossID);
                lbl_Cross.Text = SCIDM._name;

            }
            else if (crossTypeID == 2)
            {
                SCIDM = GameHelper.ShortCutIdData.Find(x => x._id == crossID && x._categoryID == crossCategoryID);
                lbl_Cross.Text = SCIDM._name;
            }
            else if (crossTypeID == 0)
            {
                lbl_Cross.Text = crossMessage;
            }
            else if (crossTypeID == 255)
            {
                lbl_Cross.Text = "Unused";
            }
        }
        private void tmr_AdjustWindow_Tick(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName(PCSX2PROCESSNAME);
            foreach (Process p in proc)
            {
                IntPtr handle = p.MainWindowHandle;
                RECT Rect = new RECT();
                if (GetWindowRect(handle, ref Rect))
                {
                    this.Location = new Point(Rect.left + 10, Rect.top + 28);
                }
            }
        }

        private void tmr_GetGameVersion_Tick(object sender, EventArgs e)
        {
            if (pcsx2Running)
            {
                m.OpenProcess(PCSX2PROCESSNAME + ".exe");

                if (m.ReadByte(GameHelper.CONNECTED_TO_AS_ADDRESS) == 1)
                {
                    foreach(var item in GameHelper.gameVersionData)
                    {
                        string text = ByteConverstionHelper.convertBytesToString(m.ReadBytes(item.Value, 4));
                        if (text == " roo")
                        {
                            gGameOffset = item.Key;
                            tmr_GetGameVersion.Enabled = false;
                        }

                    }
                }
            }
        }
    }
}
