using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//2)������� ����� DogViewModel, ������� ����� ��������� 4 ������������ ������, ��� �������, ������� ������ � �����. ����������� �� ����������.
//3) ������� ���������� � ������� ������� Action VetApplication(�������� ��� ��������� HttpGet) ,
//  ������� ��������� 0 ���������� � ���������� IActionResult. ������ ������ ������ ������� View().
//4)������� ����� ��������, ������� ������ ��������� � ��������� �����������(��� ����� ����������) � Views.
//  � ������ ����� ������� ��� VetApplication.cshtml.� ����� ��� ����� ������� �����. � ���� ����� 4 ������ ��� ������� �� ����� � ������.
//  �� ��������� ��� @model � ����� ������ ����� � ��������� ���� � ������� c ������� asp-for � � ������ type submit.
//5)������� � ����� ��������� ����������� ��� ���� action VetApplication(�������� ��� ��������� HttpPost),
//  ������� � �������� ��������� ��������� ������ DogViewModel � ���������� IActionResult.
//  ������ ������ �������� ��� ���� ����� ������� �� ������� � � ������� �������� ����� VetApplication ��� ���������� ��������� �����.
//6)�������� � ����� VetApplication ��� ���������� ����� �������� ModelState.Clear();
//7)�� ��� _Layout(��� ��������� � ������� Shared) �������� ��� ���� ����� ���� ������� ����� ��������� �� ��� ���������� � �� ����� VetApplication.
//  ��� ����� ���������� ��� ��� li � ��� ���������� ��� ������ Privacy � �������� ����� ����.
//  � � ���� li ��������� �������� �����������, ������ �� ����.


namespace Homework15_16_
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
