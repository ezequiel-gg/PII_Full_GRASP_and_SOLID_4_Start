using System.Linq;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class ProductCatalog : ICatalog
    {
        private ArrayList items = new ArrayList();

        public ProductCatalog(){}

        public void AddItem(string description, double unitCost){
            this.Items.Add(new Product(description, unitCost));
        }

        public ICatalogItem GetItemByDescription(string description){
            var query = from Product item in this.Items where item.Description == description select item;
            return query.FirstOrDefault() as Product;
        }

        public ICatalogItem GetItemAtIndex(int index){
            return this.Items[index] as Product;
        }

        public ArrayList Items { get => items; set => items = value; }
    }
}