﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory. 
    /// </summary>
    public class Product
    {
        #region Constructors
        public Product()
        {
            Console.WriteLine("Product instance created");
        }

        //using " : this" after the parameterized constructor invokes the default constructor so 
        //you don't have to repeat any code that is already in the default constructor. 
        public Product( int productId,
            string productName,
            string productDescription) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductDescription = productDescription;

            Console.WriteLine("Product instance has a name: " + ProductName);
        }
#endregion 
        private string productName;
        #region Properties
        public  string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string productDescription;
        
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        #endregion
        public string SayHello()
        {
            var vendor = new Vendor();
            vendor.SendWelcomeEmail("Message from Product");
            

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Product", 
                this.ProductName, "sales@abc.com");

            var result = LoggingService.LogAction("saying hello");

            return "Hello " + ProductName +
                " (" + ProductId + "): " +
                ProductDescription;
        }
    }
}
