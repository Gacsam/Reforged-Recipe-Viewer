using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CraftingTool
{
    public partial class CraftingForm : Form
    {
        private readonly List<CraftingRecipe> craftingRecipes;
        private readonly List<MaterialBreakdown> baseItems;
        public CraftingForm(List<CraftingRecipe> craftingRecipes, List<MaterialBreakdown> baseItems)
        {
            this.baseItems = baseItems;
            this.craftingRecipes = craftingRecipes;
            InitializeComponent();
            Text = "Reforged Recipe Viewer";
            TopMost = true;
        }

        private void CraftForm_Load(object sender, EventArgs e)
        {
            foreach (CraftingRecipe newCrafting in craftingRecipes)
            {
                if (newCrafting.craftedItem == null)
                    continue;

                if (!categoryBox.Items.Contains(newCrafting.category))
                {
                    categoryBox.Items.Add(newCrafting.category);
                }
            }
            // start at end to show throwing pots
            categoryBox.SelectedIndex = categoryBox.Items.Count-1;
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipeBox.Items.Clear();
            foreach (CraftingRecipe newCrafting in craftingRecipes)
            {
                if(newCrafting.category.Equals(categoryBox.SelectedItem))
                    recipeBox.Items.Add(newCrafting.craftedItem.itemName);
            }
            recipeBox.SelectedIndex = 0;
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CraftingRecipe> craftingByCategory = craftingRecipes.FindAll(x => x.category.Equals(categoryBox.SelectedItem));
            if (craftingByCategory[recipeBox.SelectedIndex] == null)
            {
                Console.WriteLine(craftingByCategory[recipeBox.SelectedIndex]);
            }
            CraftingRecipe currentRecipe = craftingByCategory[recipeBox.SelectedIndex];

            Image currImage = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.craftedItem.imageDir);
            recipeImage.Image = currImage;
            string craftingAmount = currentRecipe.craftCount > 1 ? "X " + currentRecipe.craftCount : "";
            label2.Text = craftingAmount;
            if (currentRecipe.ingredientOneItem == null)
            {
                ingredientOne.Image = null;
                textBox2.Text = null;
            }
            else
            {
                ingredientOne.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientOneItem.imageDir);
                textBox2.Text = currentRecipe.ingredientOneItem.itemName + " X " + currentRecipe.ingredientOneCount;
            }

            if (currentRecipe.ingredientTwoItem == null)
            {
                ingredientTwo.Image = null;
                textBox3.Text = null;
            }
            else
            {
            ingredientTwo.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientTwoItem.imageDir);
            textBox3.Text = currentRecipe.ingredientTwoItem.itemName + " X " + currentRecipe.ingredientTwoCount;
            }
            if (currentRecipe.ingredientThreeItem == null)
            {
                ingredientThree.Image = null;
                textBox4.Text = null;
            }
            else
            {
            ingredientThree.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientThreeItem.imageDir);
            textBox4.Text = currentRecipe.ingredientThreeItem.itemName + " X " + currentRecipe.ingredientThreeCount;
            }
            if (currentRecipe.ingredientFourItem == null)
            {
                ingredientFour.Image = null;
                textBox5.Text = null;
            }
            else
            {
            ingredientFour.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientFourItem.imageDir);
            textBox5.Text = currentRecipe.ingredientFourItem.itemName + " X " + currentRecipe.ingredientFourCount;
            }
        }

        private void PictureBox_ingredientOne(object sender, EventArgs e)
        {
            if(ingredientOne.Image != null)
            {
                DisplayPictureForm(1);
            }
        }

        private void PictureBox_ingredientTwo(object sender, EventArgs e)
        {
            if (ingredientTwo.Image != null)
            {
                DisplayPictureForm(2);
            }
        }

        private void PictureBox_ingredientThree(object sender, EventArgs e)
        {
            if (ingredientThree.Image != null)
            {
                DisplayPictureForm(3);
            }
        }

        private void PictureBox_ingredientFour(object sender, EventArgs e)
        {
            if (ingredientFour.Image != null)
            {
                DisplayPictureForm(4);
            }
        }

        protected void DisplayPictureForm(byte pictureBoxNumber)
        {
            CraftingRecipe getCurrentRecipe = craftingRecipes.Find(x => x.craftedItem.itemName.Equals(recipeBox.SelectedItem));
            ItemWithImage getCurrentSelection;
            switch (pictureBoxNumber)
            {
                case 1:
                    getCurrentSelection = getCurrentRecipe.ingredientOneItem;
                    break;
                case 2:
                    getCurrentSelection = getCurrentRecipe.ingredientTwoItem;
                    break;
                case 3:
                    getCurrentSelection = getCurrentRecipe.ingredientThreeItem;
                    break;
                case 4:
                    getCurrentSelection = getCurrentRecipe.ingredientFourItem;
                    break;
                default:
                    getCurrentSelection = getCurrentRecipe.ingredientOneItem;
                    break;
            }
            List<MaterialBreakdown> getConvertsForCurrentIngredient = baseItems.FindAll(x => x.convertedIngredient.itemName.Equals(getCurrentSelection.itemName));
            if (getConvertsForCurrentIngredient.Count == 0)
                return;
            Form ingredientForm = new MaterialBreakdownForm(getConvertsForCurrentIngredient, baseItems);
            ingredientForm.Show();
        }
    }
}
