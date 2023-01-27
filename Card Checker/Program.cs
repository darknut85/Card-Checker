using Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Business.Services;
using System.Windows.Forms;
using Domain.Interfaces;

namespace Card_Checker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IServiceProvider serviceCollection = new ServiceCollection()
                .AddDbContext<DataContext>(x => { x.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); }, ServiceLifetime.Transient)
                .AddScoped<ISetService, SetService>()
                .AddScoped<ICardService, CardService>()
                .AddScoped<Form1>()
                .BuildServiceProvider();
            var form = serviceCollection.GetRequiredService<Form1>();

            Application.Run(form);
        }
    }
}
