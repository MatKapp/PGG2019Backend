using System;
using WindowsInput;

namespace ControllerBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(10000);
            var simulator = new InputSimulator();
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_E);
        }
    }
}
