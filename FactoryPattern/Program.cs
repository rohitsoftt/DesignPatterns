// See https://aka.ms/new-console-template for more information
using FactoryPattern.Classes;

Console.WriteLine("Hello, World!");

var notificationServiceProvider = new NotificationServiceProvider();
var shippingService = new ShippingService(notificationServiceProvider);
shippingService.ShipItem();