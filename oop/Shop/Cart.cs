using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Shop
{
    public class Cart
    {
        //private List<MobilePhone> phones = new List<MobilePhone>();
        //private List<Laptop> laptops = new List<Laptop>();
        //private List<Headphones> headphones = new List<Headphones>();
        //private List<Fridge> fridges = new List<Fridge>();

        //public void AddMobilePhone(MobilePhone phone)
        //{
        //    phones.Add(phone);
        //}

        //public void AddLaptop(Laptop laptop)
        //{
        //    laptops.Add(laptop);
        //}

        //public void AddHeadphones(Headphones headphone)
        //{
        //    headphones.Add(headphone);
        //}

        //public void AddFridge(Fridge fridge)
        //{
        //    fridges.Add(fridge);
        //}

        //public int CalculateTotalPrice()
        //{
        //    int totalPrice = 0;

        //    foreach (MobilePhone phone in phones)
        //    {
        //        totalPrice += phone.Price;
        //    }
        //    foreach (Laptop laptop in laptops)
        //    {
        //        totalPrice += laptop.Price;
        //    }
        //    foreach (Headphones headphone in headphones)
        //    {
        //        totalPrice += headphone.Price;
        //    }
        //    foreach (Fridge fridge in fridges)
        //    {
        //        totalPrice += fridge.Price;
        //    }
        //    return totalPrice;
        //}

        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        { 
            products.Add(product);
        }

        public int CalculatePrice()
        {
            int price = 0;

            foreach (Product product in products)
            {
                price += product.Price;
            }

            return price;
        }
    }
}
