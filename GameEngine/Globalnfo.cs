using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public static class Globalnfo
    {
        public static Dictionary<int, Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>> PlayerKeyCodeMap =
            new Dictionary<int, Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>>
            {
                {0, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_Q },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_W },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_E },
                    }
                },
                {1, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_A },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_S },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_D },
                    }
                },
                {2, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_Z },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_X },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_C },
                    }
                },
                {3, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_R },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_T },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_Y },
                    }
                },
                {4, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_G },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_H },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_J },
                    }
                },
                {5, new Dictionary<MoveDirection, WindowsInput.Native.VirtualKeyCode>
                    {
                        { MoveDirection.Left, WindowsInput.Native.VirtualKeyCode.VK_B },
                        { MoveDirection.Attack, WindowsInput.Native.VirtualKeyCode.VK_N },
                        { MoveDirection.Right, WindowsInput.Native.VirtualKeyCode.VK_M },
                    }
                },
            };
    }
}
