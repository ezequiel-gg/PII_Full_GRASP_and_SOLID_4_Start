using System.Linq;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public interface ICatalog
    {
        ArrayList Items { get; set; }

        void AddItem(string description, double value);

        ICatalogItem GetItemByDescription(string description);

        ICatalogItem GetItemAtIndex(int index);
    }
}