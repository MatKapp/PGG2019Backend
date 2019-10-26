using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public static class Globalnfo
    {
        public static List<string> PlayerNameMap = new List<string>
        {
            "Krab", "Krab", "Delfin", "Delfin", "Dżdżownica", "Dżdżownica",
            "Słoń", "Słoń", "Mysz", "Mysz", "Papuga", "Papuga", "Świnia", "Świnia", "Wilk", "Wilk"
        };
        public static Dictionary<int, Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>> PlayerKeyCodeMap =
            new Dictionary<int, Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>>
            {
                {0, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_F },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_G },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_H },
                    }
                },
                {1, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_V },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_B },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_N },
                    }
                },
                {2, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_Q },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_W },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_E },
                    }
                },
                {3, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_A },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_S },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_D },
                    }
                },
                {4, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_Z },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_X },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_C },
                    }
                },
                {5, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_R },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_T },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_Y },
                    }
                },
                {6, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_3 },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.LEFT },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_4 },
                    }
                },
                {7, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_5 },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_6 },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_7 },
                    }
                },
                {8, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_U },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_I },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_O },
                    }
                },
                {9, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_J },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_K },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_L },
                    }
                },
                {10, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.BACK },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.RIGHT },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_M },
                    }
                },
                {11, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_0 },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_1 },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_2 },
                    }
                },
                {12, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_8 },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_9 },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_P },
                    }
                },
                {13, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.DOWN },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.OEM_MINUS },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.UP },
                    }
                },
                {14, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.OEM_PLUS },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.OEM_COMMA },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.OEM_PERIOD },
                    }
                },
                {15, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.OEM_102},
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.OEM_2 },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.OEM_7 },
                    }
                },
            };
    }
}
