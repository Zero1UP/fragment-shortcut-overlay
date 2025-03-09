using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpDX.XInput;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using MemoryIO.Pcsx2;
using System.Text;

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
        private const string PCSX2PROCESSNAME = "pcsx2";
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        Controller controller;
        bool controllerConnected = false;
        int gGameOffset;
        Pcsx2MemoryIO m = null;
        bool pressedInit = false;
        int baseAddress;
        public frm_Main()
        {
            InitializeComponent();
          
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            this.BackColor = Color.Linen;
            this.TransparencyKey = Color.Linen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            controller = new Controller(UserIndex.One);
            controllerConnected = controller.IsConnected;
            
            m = new Pcsx2MemoryIO(Encoding.GetEncoding("Shift-JIS"));
        }

        private void tmr_ReadPad_Tick(object sender, EventArgs e)
        {
            if(controllerConnected)
            {
                if (m.Pcsx2Running)
                {
                    IntPtr pcsx2BaseAddress = m.BaseAddress;
                    //IntPtr pcsx2Intptr = new IntPtr(pcsx2Offset);

                    int luiHeap = 0;
                    try
                    {
                        luiHeap = m.Read<byte>(IntPtr.Add(pcsx2BaseAddress, GameHelper.LUI_HEAP_OFFSET));
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Make sure the game is running before starting the application \n Closing");
                        this.Close();
                    }
                    
                    
                    if(GameHelper.GetCurrentElfFile(luiHeap) == GameHelper.CurrentElf.ONLINE)
                    {
                        gGameOffset = m.Read<int>(IntPtr.Add(pcsx2BaseAddress, GameHelper.ONLINE_PLAYER_POINTER_OFFSET));
                        if (m.Read<int>(IntPtr.Add(pcsx2BaseAddress, GameHelper.CONNECTED_TO_AS_ADDRESS_OFFSET)) == 1)
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
                    if (GameHelper.GetCurrentElfFile(luiHeap) == GameHelper.CurrentElf.OFFLINE)
                    {
                        gGameOffset = m.Read<int>(IntPtr.Add(pcsx2BaseAddress, GameHelper.OFFLINE_PLAYER_POINTER_OFFSET));
                        if (m.Read<int>(IntPtr.Add(pcsx2BaseAddress, GameHelper.LOGGED_IN_OFFLINE_MODE_OFFSET)) != 0)
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
 
        }

        /// <summary>
        /// Takes the base address that was originally used for the program and subtracts the given offset from it and returns the new address as 
        /// a string.
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        private IntPtr CalculateNewAddress(string baseAddress, long offset)
        {
            var test  = new IntPtr(int.Parse(baseAddress, System.Globalization.NumberStyles.HexNumber) + offset);

            return test;
            /*long valueOfPointer = baseAddress.ToInt64() + offset;
            return new IntPtr(valueOfPointer);*/
        }

        private void processGameData(int cirTypeIDAddress, int triTypeIDAddress, int sqTypeIDAddress, int xTypeIDAddress,
            int cirCatIDAddress, int triCatIDAddress, int sqCatIDAddress, int xCatIDAddress, int cirIDAddress, int triIDAddress,
            int sqIDAddress, int xIDAddress, int cirMessageAddress, int triMessageAddress, int sqMessageAddress, int xMessageAddress)
        {
            int circleTypeID = m.Read<byte>(cirTypeIDAddress + gGameOffset);
            int triangleTypeID = m.Read<byte>(triTypeIDAddress + gGameOffset);
            int squareTypeID = m.Read<byte>(sqTypeIDAddress + gGameOffset);
            int crossTypeID = m.Read<byte>(xTypeIDAddress + gGameOffset);
            string circleCategoryID = m.Read<byte>(cirCatIDAddress + gGameOffset).ToString("X1");
            string triangleCategoryID = m.Read<byte>(triCatIDAddress + gGameOffset).ToString("X1");
            string squareCategoryID = m.Read<byte>(sqCatIDAddress + gGameOffset).ToString("X1");
            string crossCategoryID = m.Read<byte>(xCatIDAddress + gGameOffset).ToString("X1");
            string circleID = m.Read<short>(cirIDAddress + gGameOffset).ToString("X4");
            string triangleID = m.Read<short>(triIDAddress + gGameOffset).ToString("X4");
            string squareID = m.Read<short>(sqIDAddress + gGameOffset).ToString("X4");
            string crossID = m.Read<short>(xIDAddress + gGameOffset).ToString("X4");
            string circleMessage = m.ReadString(cirMessageAddress + gGameOffset);
            string triangleMessag = m.ReadString(triMessageAddress + gGameOffset);
            string squareMessage = m.ReadString(sqMessageAddress + gGameOffset);
            string crossMessage = m.ReadString(xMessageAddress + gGameOffset);
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
            List<Process> proc = Process.GetProcesses().Where(p => p.ProcessName.StartsWith(PCSX2PROCESSNAME)).ToList();
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

    }
}
