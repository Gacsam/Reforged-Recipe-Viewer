using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CraftingTool
{
    
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>        
        [STAThread]
        
        static void Main()
        {            
            char[] charSeparators = new char[] { '\n' };
            // load ItemList from Resources and split at new line
            List<ItemWithImage> itemsWithImages = new List<ItemWithImage>();
            string[] allItemsCSV = Properties.Resources.ItemList.Replace("\r", "").Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in allItemsCSV)
            {
                if (item.Contains("itemName"))
                    continue;
                // Get rid of the bloody \r and split into two columns
                string[] columns = item.TrimEnd('\r').Split(',');
                itemsWithImages.Add(new ItemWithImage(columns[0], columns[1]));
            }

            List<BaseItemConvert> baseItems = new List<BaseItemConvert>();
            string[] baseItemsCSV = Properties.Resources.BaseItemConversion.Replace("\r", "").Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in baseItemsCSV) 
            {
                if (item.Contains("BaseItem"))
                    continue;

                string[] columns = item.TrimEnd('\r').Split(',');
                ItemWithImage baseItem = itemsWithImages.Find(x => x.itemName.Contains(columns[0]));
                ItemWithImage craftedItem = itemsWithImages.Find(x => x.itemName.Contains(columns[2]));
                baseItems.Add(new BaseItemConvert(baseItem, columns[1], craftedItem, columns[3], columns[4]));
            }

            string[] craftingCSV = Properties.Resources.ItemRecipes.Replace("\r", "").Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            List<CraftingRecipe> craftingRecipes = new List<CraftingRecipe>();
            foreach (string item in craftingCSV)
            {
                if (item.Contains("Recipe"))
                    continue;

                string[] columns = item.Split(',');
                ItemWithImage craftedItem = itemsWithImages.Find(x => x.itemName.Equals(columns[0]));
                ItemWithImage ingredientOne = itemsWithImages.Find(x => x.itemName.Equals(columns[2]));
                ItemWithImage ingredientTwo = itemsWithImages.Find(x => x.itemName.Equals(columns[4]));
                ItemWithImage ingredientThree = itemsWithImages.Find(x => x.itemName.Equals(columns[6]));
                ItemWithImage ingredientFour = itemsWithImages.Find(x => x.itemName.Equals(columns[8]));
                craftingRecipes.Add(new CraftingRecipe(craftedItem, columns[1], ingredientOne, columns[3], ingredientTwo, columns[5], ingredientThree, columns[7], ingredientFour, columns[9], columns[10]));
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CraftForm(craftingRecipes, baseItems));

        }
    }

    public class ItemWithImage
    {
        public string itemName;
        public string imageDir;

        public ItemWithImage(string item, string image)
        {
            itemName = item;
            imageDir = image;
        }
    }

    public class BaseItemConvert
    {

        public ItemWithImage ingredientItem;
        public string ingredientCount;
        public ItemWithImage resultItem;
        public string resultCount;
        public string description;
        public BaseItemConvert(ItemWithImage ingredientItem, string ingredientCount, ItemWithImage resultItem, string resultCount, string description)
        {
            this.ingredientItem = ingredientItem;
            this.ingredientCount = ingredientCount;
            this.resultItem = resultItem;
            this.resultCount = resultCount;
            this.description = description;
        }
    }

    public class CraftingRecipe
    {
        public ItemWithImage craftedItem;
        public string craftCount;
        public ItemWithImage ingredientOneItem;
        public string ingredientOneCount;
        public ItemWithImage ingredientTwoItem;
        public string ingredientTwoCount;
        public ItemWithImage ingredientThreeItem;
        public string ingredientThreeCount;
        public ItemWithImage ingredientFourItem;
        public string ingredientFourCount;
        public string category;
        public CraftingRecipe(ItemWithImage craftedItem, string craftCount, ItemWithImage ingredientOneItem, string ingredientOneCount, ItemWithImage ingredientTwoItem, string ingredientTwoCount, ItemWithImage ingredientThreeItem, string ingredientThreeCount, ItemWithImage ingredientFourItem, string ingredientFourCount, string category)
        {
            this.craftedItem = craftedItem;
            this.craftCount = craftCount;
            this.ingredientOneItem = ingredientOneItem;
            this.ingredientOneCount = ingredientOneCount;
            this.ingredientTwoItem = ingredientTwoItem;
            this.ingredientTwoCount = ingredientTwoCount;
            this.ingredientThreeItem = ingredientThreeItem;
            this.ingredientThreeCount = ingredientThreeCount;
            this.ingredientFourItem = ingredientFourItem;
            this.ingredientFourCount = ingredientFourCount;
            this.category = category;
        }
    }
}
