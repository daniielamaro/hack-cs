using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HackCS
{
    public class Hack
    {
        private readonly Process processoCS;
        const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        public Hack()
        {
            processoCS = Process.GetProcessesByName("hl")[0];
        }

        public async Task VidaInfinita()
        {
            byte[] buffer = new byte[sizeof(float)];
            int bytesRead = 0;
            int bytesWritten = 0;
            IntPtr processHandle = MemoryRead.OpenProcess(PROCESS_ALL_ACCESS, false, processoCS.Id);

            List<Module> modules = CollectModules(processoCS);
            Module module = modules.Where(x => x.ModuleName.Contains("hw.dll")).FirstOrDefault();

            IntPtr readAddress = IntPtr.Add(module.BaseAddress, 0x7BBD9C);
            MemoryRead.ReadProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesRead);

            long baseAddressVida = BitConverter.ToInt32(buffer, 0);

            readAddress = IntPtr.Add((IntPtr)baseAddressVida, 0x1E0);

            buffer = BitConverter.GetBytes(999f);
            MemoryRead.WriteProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesWritten);
        }

        public async Task MunicaoInfinita()
        {
            Debug.WriteLine("");
            Debug.WriteLine("");
            byte[] buffer = new byte[sizeof(int)];
            int bytesRead = 0;
            int bytesWritten = 0;
            IntPtr processHandle = MemoryRead.OpenProcess(PROCESS_ALL_ACCESS, false, processoCS.Id);

            List<Module> modules = CollectModules(processoCS);
            Module module = modules.Where(x => x.ModuleName.Contains("hw.dll")).FirstOrDefault();

            IntPtr readAddress = IntPtr.Add(module.BaseAddress, 0x7BBD9C);
            MemoryRead.ReadProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesRead);
            long baseAddressMunicao = BitConverter.ToInt32(buffer, 0);

            readAddress = IntPtr.Add((IntPtr)baseAddressMunicao, 0x7C);
            MemoryRead.ReadProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesRead);
            baseAddressMunicao = BitConverter.ToInt32(buffer, 0);

            readAddress = IntPtr.Add((IntPtr)baseAddressMunicao, 0x5D4);
            MemoryRead.ReadProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesRead);
            baseAddressMunicao = BitConverter.ToInt32(buffer, 0);

            readAddress = IntPtr.Add((IntPtr)baseAddressMunicao, 0xA4);
            MemoryRead.ReadProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesRead);
            baseAddressMunicao = BitConverter.ToInt32(buffer, 0);

            readAddress = IntPtr.Add((IntPtr)baseAddressMunicao, 0x5D4);
            MemoryRead.ReadProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesRead);
            baseAddressMunicao = BitConverter.ToInt32(buffer, 0);

            readAddress = IntPtr.Add((IntPtr)baseAddressMunicao, 0xCC);

            buffer = BitConverter.GetBytes(30);
            MemoryRead.WriteProcessMemory((int)processHandle, (long)readAddress, buffer, buffer.Length, ref bytesWritten);
        }

        public static List<Module> CollectModules(Process process)
        {
            List<Module> collectedModules = new();

            IntPtr[] modulePointers = Array.Empty<IntPtr>();

            // Determine number of modules
            if (!Native.EnumProcessModulesEx(process.Handle, modulePointers, 0, out int bytesNeeded, (uint)Native.ModuleFilter.ListModulesAll))
            {
                return collectedModules;
            }

            int totalNumberofModules = bytesNeeded / IntPtr.Size;
            modulePointers = new IntPtr[totalNumberofModules];

            // Collect modules from the process
            if (Native.EnumProcessModulesEx(process.Handle, modulePointers, bytesNeeded, out _, (uint)Native.ModuleFilter.ListModulesAll))
            {
                for (int index = 0; index < totalNumberofModules; index++)
                {
                    StringBuilder moduleFilePath = new(1024);
                    Native.GetModuleFileNameEx(process.Handle, modulePointers[index], moduleFilePath, (uint)(moduleFilePath.Capacity));

                    string moduleName = Path.GetFileName(moduleFilePath.ToString());
                    Native.ModuleInformation moduleInformation = new();
                    Native.GetModuleInformation(process.Handle, modulePointers[index], out moduleInformation, (uint)(IntPtr.Size * (modulePointers.Length)));

                    // Convert to a normalized module and add it to our list
                    Module module = new(moduleName, moduleInformation.lpBaseOfDll, moduleInformation.SizeOfImage);
                    collectedModules.Add(module);
                }
            }

            return collectedModules;
        }
    }

    public class Native
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ModuleInformation
        {
            public IntPtr lpBaseOfDll;
            public uint SizeOfImage;
            public IntPtr EntryPoint;
        }

        internal enum ModuleFilter
        {
            ListModulesDefault = 0x0,
            ListModules32Bit = 0x01,
            ListModules64Bit = 0x02,
            ListModulesAll = 0x03,
        }

        [DllImport("psapi.dll")]
        public static extern bool EnumProcessModulesEx(IntPtr hProcess, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)][In][Out] IntPtr[] lphModule, int cb, [MarshalAs(UnmanagedType.U4)] out int lpcbNeeded, uint dwFilterFlag);

        [DllImport("psapi.dll")]
        public static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In][MarshalAs(UnmanagedType.U4)] uint nSize);

        [DllImport("psapi.dll", SetLastError = true)]
        public static extern bool GetModuleInformation(IntPtr hProcess, IntPtr hModule, out ModuleInformation lpmodinfo, uint cb);
    }

    public class Module
    {
        public Module(string moduleName, IntPtr baseAddress, uint size)
        {
            this.ModuleName = moduleName;
            this.BaseAddress = baseAddress;
            this.Size = size;
        }

        public string ModuleName { get; set; }
        public IntPtr BaseAddress { get; set; }
        public uint Size { get; set; }
    }
}
