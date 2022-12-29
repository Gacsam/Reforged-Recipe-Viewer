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
            string[] allItemsCSV = Properties.Resources.ItemImages.Replace("\r", "").Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in allItemsCSV)
            {
                if (item.Contains("itemName"))
                    continue;
                // Get rid of the bloody \r and split into two columns
                string[] columns = item.TrimEnd('\r').Split(',');
                itemsWithImages.Add(new ItemWithImage(columns[0], columns[1]));
            }

            List<MaterialBreakdown> baseItems = new List<MaterialBreakdown>();
            string[] baseItemsCSV = Properties.Resources.MaterialBreakdown.Replace("\r", "").Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in baseItemsCSV) 
            {
                if (item.Contains("BaseItem"))
                    continue;

                string[] columns = item.TrimEnd('\r').Split(',');
                ItemWithImage baseItem = itemsWithImages.Find(x => x.itemName.Equals(columns[0]));
                ItemWithImage craftedItem = itemsWithImages.Find(x => x.itemName.Equals(columns[2]));
                baseItems.Add(new MaterialBreakdown(baseItem, byte.Parse(columns[1]), craftedItem, columns[3], columns[4]));
            }

            string[] craftingCSV = Properties.Resources.CraftingRecipes.Replace("\r", "").Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            List<CraftingRecipe> craftingRecipes = new List<CraftingRecipe>();
            foreach (string item in craftingCSV)
            {
                if (item.Contains("Recipe"))
                    continue;

                string[] columns = item.Split(',');
                ItemWithImage craftedItem = itemsWithImages.Find(x => x.itemName.Equals(columns[0]));
                byte.TryParse(columns[1], out byte craftedItemCount);
                byte.TryParse(columns[3], out byte ingredientOneCount);
                byte.TryParse(columns[5], out byte ingredientTwoCount);
                byte.TryParse(columns[7], out byte ingredientThreeCount);
                byte.TryParse(columns[9], out byte ingredientFourCount);
                ItemWithImage ingredientOne = itemsWithImages.Find(x => x.itemName.Equals(columns[2]));
                ItemWithImage ingredientTwo = itemsWithImages.Find(x => x.itemName.Equals(columns[4]));
                ItemWithImage ingredientThree = itemsWithImages.Find(x => x.itemName.Equals(columns[6]));
                ItemWithImage ingredientFour = itemsWithImages.Find(x => x.itemName.Equals(columns[8]));
                craftingRecipes.Add(new CraftingRecipe(craftedItem, craftedItemCount, ingredientOne, ingredientOneCount, ingredientTwo, ingredientTwoCount, ingredientThree, ingredientThreeCount, ingredientFour, ingredientFourCount, columns[10]));
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CraftingForm(craftingRecipes, baseItems));

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

    public class MaterialBreakdown
    {
        /// <summary>
        /// materials broken down into ingredients
        /// </summary>
        public ItemWithImage material;
        public byte materialCount;
        /// <summary>
        /// materials broken down into ingredients
        /// </summary>
        public ItemWithImage convertedIngredient;
        public string ingredientCount;
        public string description;
        public MaterialBreakdown(ItemWithImage ingredientItem, byte ingredientCount, ItemWithImage resultItem, string resultCount, string description)
        {
            this.material = ingredientItem;
            this.materialCount = ingredientCount;
            this.convertedIngredient = resultItem;
            this.ingredientCount = resultCount;
            this.description = description;
        }
    }

    public class CraftingRecipe
    {
        public ItemWithImage ingredientOneItem;
        public byte ingredientOneCount;
        public ItemWithImage ingredientTwoItem;
        public byte ingredientTwoCount;
        public ItemWithImage ingredientThreeItem;
        public byte ingredientThreeCount;
        public ItemWithImage ingredientFourItem;
        public byte ingredientFourCount;
        public ItemWithImage craftedItem;
        public byte craftCount;
        public string category;
        public CraftingRecipe(ItemWithImage craftedItem, byte craftCount, ItemWithImage ingredientOneItem, byte ingredientOneCount, ItemWithImage ingredientTwoItem, byte ingredientTwoCount, ItemWithImage ingredientThreeItem, byte ingredientThreeCount, ItemWithImage ingredientFourItem, byte ingredientFourCount, string category)
        {
            this.ingredientOneItem = ingredientOneItem;
            this.ingredientOneCount = ingredientOneCount;
            this.ingredientTwoItem = ingredientTwoItem;
            this.ingredientTwoCount = ingredientTwoCount;
            this.ingredientThreeItem = ingredientThreeItem;
            this.ingredientThreeCount = ingredientThreeCount;
            this.ingredientFourItem = ingredientFourItem;
            this.ingredientFourCount = ingredientFourCount;
            this.craftedItem = craftedItem;
            this.craftCount = craftCount;
            this.category = category;
        }
    }
}
