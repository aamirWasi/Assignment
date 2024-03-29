﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //InterfaceViaPolymorphism

            var videoEncoder = new VideoEncoder();
            videoEncoder.RegisterNotificationChannel(new MailNotificationChannel());
            videoEncoder.RegisterNotificationChannel(new SmsNotificationChannel());
            videoEncoder.Encode();


            //OCP
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Study\file.txt"));
            dbMigrator.Migrate();

            //OrderProcessor
            var order = new Order
            {
                TotalPrice = 20f,
                DatePlaced = DateTime.Now
            };
            var orderProcssor = new OrderProcessor(new ShippingCalculator());
            orderProcssor.Process(order);
            var user = new User
            {
                Status = RegistrationStatus.Active,
                Type=UserType.Admin
            };
            if (user.Type==UserType.Admin && user.Status==RegistrationStatus.Active)
                Console.WriteLine("Login Successfull...");
        }
    }
}
