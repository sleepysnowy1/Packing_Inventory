using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.Classes.InventoryItem
{
    public class InventoryItem
    {
        #region Variables and Properties 

        private readonly string _name; 
        private double weight;
        private double volume;

        public double Weight { get { return weight; } protected set { weight = value; } }
        public double Volume { get { return volume; } protected set { volume = value; } }

        
        #endregion

        #region Constructors 

        public InventoryItem(double weight, double volume)
        {
            this.weight = weight;
            this.volume = volume;   
        }

        #endregion

        
        //{
        //    Console.WriteLine("Name: " + Name + " Weight: " + Weight + " Volume: " + Volume);
        //}
    }

    internal class Arrow : InventoryItem
    {
        public Arrow() : base(0.1, 0.05)
        {

        }

        public override string ToString()
        {
            return "Arrow"; 
        }
    }

    internal class Bow : InventoryItem
    {
        #region Constructors 

        public Bow() : base(1, 4)
        {
        }

        #endregion 

        public override string ToString()
        {
            return "Bow"; 
        }
    }

    internal class Rope : InventoryItem
    {
        #region Constructor 

        internal Rope() : base(1, 1.5)
        {
        }

        #endregion

        public override string ToString()
        {
            return "Rope"; 
        }
    }

    internal class Water : InventoryItem
    {
        #region Constructors 

        public Water() : base(2, 3)
        {

        }

        #endregion

        public override string ToString()
        {
            return "Water";
        }
    }

    internal class Food : InventoryItem
    {
        #region Constructors 

        public Food() : base(1, 0.5)
        {

        }

        #endregion

        public override string ToString()
        {
            return "Food";
        }
    }

    internal class Sword : InventoryItem
    {
        #region Constructor 

        public Sword() : base(5, 3)
        {

        }

        #endregion

        public override string ToString()
        {
            return "Sword";
        }
    }

}
