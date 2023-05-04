using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace MegaDesk

{

    public enum SurfaceMaterial
    {
        LAMINATE,
        OAK,
        PINE,
        ROSEWOOD,
        VENEER
    }




    public class Desk
    {

        private string customerName;
        private double width;
        private double height;
        private int numberOfDrawers;
        private SurfaceMaterial surfaceMaterial;


        public static void Main()
        {
            SurfaceMaterial roseWood = SurfaceMaterial.ROSEWOOD;
            Console.WriteLine(roseWood);
        }





    }


}