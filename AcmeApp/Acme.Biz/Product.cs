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
