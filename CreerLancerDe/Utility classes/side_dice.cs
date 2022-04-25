using CreerLancerDe.Properties;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core.DAG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Utility_classes
{
    class side_dice
    {


        public void writeOnImage()
        {
            string firstText = "Hello";
            string secondText = "World";

            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);

            Bitmap bitmapImage = Resources.Dice_side;//load the image file
            var image = new Bitmap(Resources.Dice_side.Width, Resources.Dice_side.Height);
            var font = new Font("TimesNewRoman",5, FontStyle.Bold, GraphicsUnit.Pixel);
        //    Resources.Dice_side.Ima
        }


    }
    
}
