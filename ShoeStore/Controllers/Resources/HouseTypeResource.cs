using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers.Resources
{
    public class HouseTypeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string IconPath
        {
            get
            {
                var iconPath = "";
                if (Id == 1)
                    iconPath = "/images/blue-dot.png";
                else if (Id == 5)
                    iconPath = "/images/red-dot.png";
                else
                    iconPath = "/images/green-dot.png";

                return iconPath;
            }
        }
    }
}
