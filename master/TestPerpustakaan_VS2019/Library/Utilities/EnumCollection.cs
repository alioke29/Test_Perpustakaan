using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;
using System.Text;
using System.Xml;

using Microsoft.AspNetCore.Cryptography;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Reflection;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace TestPerpustakaan_VS2019.Library.Utilities
{
    public class EnumCollection
    {

        public enum TypeRole
        {
            Administrator = 4,
            Penyewa = 5
        };

        public static class RoleName
        {
            public const string Administrator = "Administrator";
            public const string Penyewa = "Penyewa";

        }

        public static class ParentMenuName
        {
            public const string SecurityManagement = "Security Management";
            public const string Master = "Master";
            public const string Transaction = "Transaction";
            public const string Report = "Report";
        }


    }
}
