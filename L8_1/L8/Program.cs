using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    class Program
    {
        [ComRegisterFunction]
        public static void RegisterFunction(Type t)
        {
            var keyname = string.Format(@"SOFTWARE\Unity Technologies\{0:b}", t.GUID);
            using (var rk = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(keyname))
            {
                rk.SetValue(null, 1);
                rk.SetValue("Title", "11");
                rk.SetValue("Description", "DD");
            }
        }

        [ComUnregisterFunction]
        public static void UnregisterFunction(Type t)
        {
            var keyname = string.Format(@"SOFTWARE\Unity Technologies\{0:b}", t.GUID);
            Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree(keyname);
        }
        jnkjnlklkjnlkj
    }
}
