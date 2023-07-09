using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    public class Building
    {
        public string Name { get; set; }
        public int BuildingYear { get; set; }
        private BuildingType _buildingType;
        public int _numberOfFloors { get; set; }
        public BuildingType BuildingType {
            get
            {
                return _buildingType;
            }
            set
            {
                foreach (BuildingType item in Enum.GetValues(typeof(BuildingType)))
                {
                    if (value.ToString().ToLower() == item.ToString().ToLower())
                    {
                        _buildingType = value;
                    }
                }
                throw new InvalidOperationException();
            }
        }

        public bool HasElevator()
        {
            if(_numberOfFloors >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetPrice()
        {
            if(this._buildingType == BuildingType.APARTMENT)
            {
                return this._numberOfFloors * 100000;
            }else if (this._buildingType == BuildingType.BUSINESS_CENTER)
            {
                return this._numberOfFloors * 1000000;
            }else if(this._buildingType != BuildingType.MEDICAL_CENTER)
            {
                return this._numberOfFloors * 150000;
            }else if(this._buildingType!= BuildingType.EDUACTIONAL_CENTER)
            {
                return (this._numberOfFloors * 120000);
            }else
            {
                throw new Exception();
            }
                    
        }


 
    }


    public enum BuildingType
    {
        APARTMENT,
        BUSINESS_CENTER,
        EDUACTIONAL_CENTER,
        MEDICAL_CENTER
    }
}
