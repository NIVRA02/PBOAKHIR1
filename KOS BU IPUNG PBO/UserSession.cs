using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOS_BU_IPUNG_PBO
{
    /// <summary>
    /// Kelas statis untuk menyimpan informasi sesi pengguna yang sedang login.
    /// </summary>
    public static class UserSession
    {
        public static string Username { get; private set; }

        public static void StartSession(string username)
        {
            Username = username;
        }

        public static void EndSession()
        {
            Username = null;
        }
    }
}