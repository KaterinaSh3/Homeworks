using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//1)������� ������ MVC, ������� ���� ��� �� ��� ������ � ������.
//2)������� ����� Book, ������� ����� ��������� 3 ������������ �������� �����, ����� ����� � ���������� �������.
//  �� ������� ����� ������� �����������. 
//3) ������� ���������� � ������� ������� Action Index, ������� ��������� 0 ���������� � ���������� IActionResult.
//  ������ ������ ������� ������ �����, ������ �������� �������� � ����� ������� View ������� �� ��� ������ �����.
//4)������� ����� ��������, ������� ������ ��������� � ��������� �����������(��� ����� ����������).
//  � ������ ����� ������� ��� Index.cshtml. � ����� ��� ����� ������� �������� �����, ������ � ���������� �������.


namespace Homework14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
