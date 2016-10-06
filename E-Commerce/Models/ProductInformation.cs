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
            ProductModel prod5 = new ProductModel();
            ProductModel prod6 = new ProductModel();
            ProductModel prod7 = new ProductModel();
            ProductModel prod8 = new ProductModel();
            ProductModel prod9 = new ProductModel();
            ProductModel prod10 = new ProductModel();
            ProductModel prod11 = new ProductModel();
            ProductModel prod12 = new ProductModel();
            ProductModel prod13 = new ProductModel();
            ProductModel prod14 = new ProductModel();
            ProductModel prod15 = new ProductModel();
            ProductModel prod16 = new ProductModel();
            ProductModel prod17 = new ProductModel();
            ProductModel prod18 = new ProductModel();
            ProductModel prod19 = new ProductModel();
            ProductModel prod20 = new ProductModel();

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
            prod2.imageUrl = "~/images/th1N1SJ207.jpg";
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

            prod5.Name = "Canon EOS 50D";
            prod5.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod5.Price = 8.689;
            prod5.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod5.imageUrl = "~/images/header.jpg";
            myList.Add(prod5);

            prod6.Name = "Canon EOS 50D";
            prod6.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod6.Price = 4.689;
            prod6.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod6.imageUrl = "~/images/header.jpg";
            myList.Add(prod6);

            prod7.Name = "Canon EOS 50D";
            prod7.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod7.Price = 4.689;
            prod7.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod7.imageUrl = "~/images/header.jpg";
            myList.Add(prod7);

            prod8.Name = "Canon EOS 50D";
            prod8.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod8.Price = 4.689;
            prod8.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod8.imageUrl = "~/images/header.jpg";
            myList.Add(prod8);

            prod9.Name = "Canon EOS 50D";
            prod9.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod9.Price = 4.689;
            prod9.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod9.imageUrl = "~/images/header.jpg";
            myList.Add(prod9);

            prod10.Name = "Canon EOS 50D";
            prod10.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod10.Price = 4.689;
            prod10.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod10.imageUrl = "~/images/header.jpg";
            myList.Add(prod10);

            prod10.Name = "Canon EOS 50D";
            prod10.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod10.Price = 4.689;
            prod10.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod10.imageUrl = "~/images/header.jpg";
            myList.Add(prod10);

            prod11.Name = "Canon EOS 50D";
            prod11.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod11.Price = 4.689;
            prod11.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod11.imageUrl = "~/images/header.jpg";
            myList.Add(prod11);

            prod12.Name = "Canon EOS 50D";
            prod12.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod12.Price = 4.689;
            prod12.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod12.imageUrl = "~/images/header.jpg";
            myList.Add(prod12);

            prod13.Name = "Canon EOS 50D";
            prod13.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod13.Price = 4.689;
            prod13.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod13.imageUrl = "~/images/header.jpg";
            myList.Add(prod13);

            prod14.Name = "Canon EOS 50D";
            prod14.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod14.Price = 4.689;
            prod14.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod14.imageUrl = "~/images/header.jpg";
            myList.Add(prod14);

            prod15.Name = "Canon EOS 50D";
            prod15.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod15.Price = 4.689;
            prod15.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod15.imageUrl = "~/images/header.jpg";
            myList.Add(prod15);

            prod16.Name = "Canon EOS 50D";
            prod16.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod16.Price = 4.689;
            prod16.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod16.imageUrl = "~/images/header.jpg";
            myList.Add(prod16);

            prod17.Name = "Canon EOS 50D";
            prod17.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod17.Price = 4.689;
            prod17.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod17.imageUrl = "~/images/header.jpg";
            myList.Add(prod17);

            prod18.Name = "Canon EOS 50D";
            prod18.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod18.Price = 4.689;
            prod18.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod18.imageUrl = "~/images/header.jpg";
            myList.Add(prod18);

            prod19.Name = "Canon EOS 50D";
            prod19.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod19.Price = 4.689;
            prod19.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod19.imageUrl = "~/images/header.jpg";
            myList.Add(prod19);

            prod20.Name = "Canon EOS 50D";
            prod20.Description = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera";
            prod20.Price = 4.689;
            prod20.FullInformation = "Capture 4K Video and 12MP Stills 3 - Axis Gimbal Stabilizes Camera Up to 1.2 Mile Radio Range GPS - Based Flight Control System Vision Positioning for Indoor Flying Live 720p HD Monitoring with Lightbridge Thrust - Boosted Motors / New Propellers Retractable Carbon Fiber Arms  Unobstructed 360o Shooting";
            prod20.imageUrl = "~/images/header.jpg";
            myList.Add(prod20);


        }

        public ProductModel getProductInfo(string name)
        {
            ProductModel product = null;

            foreach (ProductModel item in myList)
            {
                if (name == item.imageUrl)
                {
                    product = item;
                }

            }
            return product;
        }
    }
}