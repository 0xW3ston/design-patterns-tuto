using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Proxy
{
    internal class ProxyImage: IImage
    {
        private RealImage? realImage;
        private readonly string img_path;

        public ProxyImage(string img_path)
        {
            this.img_path = img_path;
        }

        public void Display()
        {
            LoadAndOrAccessImage()
                .displayImage();
        }

        private RealImage LoadAndOrAccessImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(img_path);
            }
            return realImage;
        }
    }
}
