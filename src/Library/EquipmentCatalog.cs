using System.Linq;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class EquipmentCatalog : ICatalog
    {
        private ArrayList items = new ArrayList();

        public EquipmentCatalog(){}

        public void AddItem(string description, double hourlyCost){
            this.Items.Add(new Equipment(description, hourlyCost));
        }

        public ICatalogItem GetItemByDescription(string description){
            var query = from Equipment item in this.Items where item.Description == description select item;
            return query.FirstOrDefault() as Equipment;
        }

        public ICatalogItem GetItemAtIndex(int index){
            return this.Items[index] as Equipment;
        }

        public ArrayList Items { get => items; set => items = value; }
    }
}