﻿using System;
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

        }

        private string productName;

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

        public string SayHello()
        {
            return "Hello " + ProductName +
                " (" + ProductId + "): " +
                ProductDescription;
        }
    }
}
