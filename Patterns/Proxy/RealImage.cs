using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Proxy
{
    internal class RealImage
    {
        private bool _hasLoaded = false;
        public RealImage(string img_path) {
            // Loading the image to memory
            LoadImage(img_path);
        }

        private void LoadImage(string img_path)
        {
            _hasLoaded = true;
        }

        public void displayImage()
        {
            Console.WriteLine("Displaying Image...");
        }
    }
}
