// See https://aka.ms/new-console-template for more information
using Acme.DataAccess.Repositories;
using Acme.Domain.DTOs;

Console.WriteLine("Hello, World!");

var product = new Product { 
    ID = 1,
    Name = "Test",
    Description = "Test Product init",
    SKU = "TEST666"
};