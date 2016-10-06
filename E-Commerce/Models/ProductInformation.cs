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

            prod.Name = "AGCO-Solo-Drone";
            prod.Description = "EDITION Unmanned Aerial Vehicle (UAV)";
            prod.Price = 5999.99;
            prod.FullInformation = "3D Robotics Solo Drone: Using the Solo's smart flying features, you don't have to be on the sidelines to capture memories — you can be a part of them, too. Choose from a variety of autopilot modes, from premapped flight paths, to orbit, lock-on-and-follow, and more. Now you can worry less about keeping the drone in the air, and focus on taking amazing footage to share with your friends and family.";
            prod.imageUrl = "~/images/AGCO-Solo-Drone.jpg";
            myList.Add(prod);

            prod2.Name = "camcorder";
            prod2.Description = "An HDD camcorder is a video camera that uses an internal hard drive instead of a tapePicture";
            prod2.Price= 37295.00;
            prod2.FullInformation = "It is the successor of the miniDV camera, which uses tape but already records in digital format. The advantage of the HDD camcorder is that users no longer need to upload their tapes into their computers to convert the tape into a digital file. The HDD camcorder enables users to simply copy a file from one hard drive to the other, the same way files can be copied from one to another hard drive directory.";
            prod2.imageUrl = "~/images/camcorder-against-white.jpg";
            myList.Add(prod2);

            prod3.Name = "Canon XLH1 HD";
            prod3.Description = "This Canon XLH1 HDTV camera records HD using three 1440x1080i sensors, with a native aspect ratio of 16:9 using non-square pixels of aspect ratio 1:1.333. It has several standard uncompressed outputs for connection to HD VTRs, along with a built in mini-DV deck.";
            prod3.Price = 19950.00;
            prod3.FullInformation = " 1080p - 4.2 MP - BlackSony - FullHD 1080p - AVCHD - MPEG-2 - Hard Drive - Night Vision - 4.2 megapixel sensor - USB - S-Video - HDMI - Composite - Component - 30 x optical zoom - Automatic Focus - Manual Focus - Image Stabilizing - 12";
            prod3.imageUrl = "~/images/Canon_XLH1_HD_Camera_side_view.jpg";
            myList.Add(prod3);

            prod4.Name = "Canon EOS 50D";
            prod4.Description = "The 50D's 15.1 megapixels also includes excellent high-ISO performance.";
            prod4.Price = 4.689;
            prod4.FullInformation = "Photography Backdrops are an amazing thing that is used for decoration purpose. Different scenes printed Photography Backdrops are available to make it much more attractive. There is a design of Photography Backdrops that is Rose House Pattern Waterproof Photography Studio Backdrop 16.40×9.84ft which is very attractively designed.";
            prod4.imageUrl = "~/images/ZBEAUTY2.jpg";
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