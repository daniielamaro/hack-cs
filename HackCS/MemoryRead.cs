using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    public class MemoryRead
    {
        public static int PROCESS_WM_READ = 0x0010;
        public static int PROCESS_VM_WRITE = 0x0020;
        public static int PROCESS_VM_OPERATION = 0x0008;
        public static int PROCESS_ALL_ACCESS = 0x1F0FFF;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(int hProcess, long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

    }
}