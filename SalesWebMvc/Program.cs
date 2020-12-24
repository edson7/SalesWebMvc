/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 23/12/2020
* Description: Sales Web Mvc Project - course Udemy 
* Observation :  Programming concepts in C #
* Start Project: 23/12/2020
* End Project :  25/12/2020
* Review:1.0
*********************************************************************
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SalesWebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
