using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class ProductInformation
    {
        public List<ProductModel> myList = new List<ProductModel>();

        public List<ProductModel> getInformation()
        {
            List<ProductModel> produc = null;
            addProduct();
            produc = myList;
            return produc;
        }

        public void addProduct()
        {
            myList.Clear();
            ProductModel prod = new ProductModel();
            ProductModel prod2 = new ProductModel();
            ProductModel prod3 = new ProductModel();
            ProductModel prod4 = new ProductModel();

            prod.Name = "~/images/Commerce-Wallpaper.jpg";
            prod.Description = "Picture 1";
            myList.Add(prod);

            prod2.Name = "~/images/prd5.png";
            prod2.Description = "Picture 2";
            myList.Add(prod2);

            prod3.Name = "~/images/untitled.png";
            prod3.Description = "Picture 3";
            myList.Add(prod3);


            prod4.Name = "~/images/img_nature_wide.jpg";
            prod4.Description = "Picture 4";
            myList.Add(prod4);

        }

        public ProductModel getProductInfo(string name)
        {
            ProductModel product = null;

            foreach (ProductModel item in myList)
            {
                if (name == item.Name)
                {
                    product = item;
                }

            }
            return product;
        }
    }
}