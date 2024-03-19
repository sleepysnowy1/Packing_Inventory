using Packing_Inventory.Data_Types;
using Packing_Inventory.Classes.InventoryItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace Packing_Inventory.Classes
{
    internal class Pack
    {
        #region Variables and Properties 

        protected const double weightLimit = 15;
        protected const double volumeLimit = 10;
        protected const int itemCountLimit = 6; 
        PackCounters packCounter = new PackCounters();

        //InventoryItem.InventoryItem itemManifest[] = new InventoryItem.InventoryItem[itemCountLimit];
        List<InventoryItem.InventoryItem> itemManifest = new List<InventoryItem.InventoryItem>();

        itemManifest.Capacity = 6;

        public double WeightCount
        {
            get { return packCounter.weightLB; } 

            protected set
            {
                if(packCounter.weightLB > weightLimit)
                {
                    Console.WriteLine("Carry Weight Exceeded."); 
                }
                else
                    this.packCounter.weightLB = value;
            }
        }

        public double VolumeCount
        {
            get { return packCounter.volume; }

            protected set
            {
                if (packCounter.volume > volumeLimit)
                {
                    Console.WriteLine("Pack Volume Exceeded"); 
                }
                else
                    this.packCounter.volume = value;
            }
        }

        public int ItemCount
        {
            get { return packCounter.itemCount; }

            protected set
            {
                if (packCounter.itemCount > itemCountLimit)
                {
                    Console.WriteLine("Item Count Limit Exceeded");
                }
                else
                    this.packCounter.itemCount = value;
            }
        }
        #endregion

        #region Constructor 

        public Pack()
        {
            packCounter.weightLB = 0;
            packCounter.volume = 0; 
            packCounter.itemCount = 0;
        }

        #endregion

        #region Methods 
        
        public bool AddItem(InventoryItem.InventoryItem item)
        {
            if (packCounter.itemCount + 1 <= itemCountLimit && packCounter.weightLB + item.Weight <= weightLimit && packCounter.volume + item.Volume <= volumeLimit)
            {
                itemManifest.Add(item);

                packCounter.volume += item.Volume;
                packCounter.weightLB += item.Weight; 
            }
            else
                Console.WriteLine($"Trying to add {item.Volume} Volume & {item.Weight} LB when current pack counts are {VolumeCount} Volume & {WeightCount} LB"); 
                
        }

        public void ListPackItems()
        {
            itemManifest.ForEach(item => { Console.WriteLine(typeof(item)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ; });
        }
        #endregion
    }
}
