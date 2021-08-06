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

using Microsoft.Extensions.Configuration;
using TestPerpustakaan_VS2019.Library.Entities;

namespace TestPerpustakaan_VS2019.Library.Utilities
{
    public class ConfigurationWeb
    {

        public static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        //public static SmtpEntity.Smtp GetSMTPConfiguration()
        //{
        //    var configuration = new SmtpEntity.Smtp();
        //    var iConfig = GetIConfigurationRoot();

        //    iConfig
        //        .GetSection("SmtpSettings")
        //        .Bind(configuration);

        //    return configuration;
        //}

        public static string GetLDAPServive()
        {
            
            var iConfig = GetIConfigurationRoot();

            return iConfig.GetSection("CalculatorService:UrlApi").Value;
        }

        public static string UploadFolderDocument(IWebHostEnvironment hosting)
        {
            string uploadFoler = hosting.WebRootPath + "\\Uploads\\Document\\";

            return uploadFoler;
        }

        public static string UploadFolderZIPFiles(IWebHostEnvironment hosting)
        {
            string uploadFoler = hosting.WebRootPath + "\\Uploads\\ZIPFiles\\";

            return uploadFoler;
        }




    }

}
