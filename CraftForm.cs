using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftingTool
{
    public partial class CraftForm : Form
    {
        private List<CraftingRecipe> craftingRecipes;
        private List<BaseItemConvert> baseItems;
        public CraftForm(List<CraftingRecipe> craftingRecipes, List<BaseItemConvert> baseItems)
        {
            this.baseItems = baseItems;
            this.craftingRecipes = craftingRecipes;
            InitializeComponent();
            Text = "Recipe Viewer";
        }

        private void Form1_Load(object sender, EventArgs e)
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
            categoryBox.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipeBox.Items.Clear();
            foreach (CraftingRecipe newCrafting in craftingRecipes)
            {
                if(newCrafting.category.Equals(categoryBox.SelectedItem))
                    recipeBox.Items.Add(newCrafting.craftedItem.itemName);
            }
            recipeBox.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<CraftingRecipe> craftingByCategory = craftingRecipes.FindAll(x => x.category.Equals(categoryBox.SelectedItem));
            if (craftingByCategory[recipeBox.SelectedIndex] == null)
            {
                Console.WriteLine(craftingByCategory[recipeBox.SelectedIndex]);
            }
            CraftingRecipe currentRecipe = craftingByCategory[recipeBox.SelectedIndex];

            Image currImage = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.craftedItem.imageDir);
            pictureBox1.Image = currImage;
            textBox1.Text = "X " + currentRecipe.craftCount;
            if (currentRecipe.ingredientOneItem == null)
            {
                pictureBox2.Image = null;
                textBox2.Text = null;
            }
            else
            {
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientOneItem.imageDir);
            textBox2.Text = currentRecipe.ingredientOneItem.itemName + " X " + currentRecipe.ingredientOneCount;
            }

            if (currentRecipe.ingredientTwoItem == null)
            {
                pictureBox3.Image = null;
                textBox3.Text = null;
            }
            else
            {
            pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientTwoItem.imageDir);
            textBox3.Text = currentRecipe.ingredientTwoItem.itemName + " X " + currentRecipe.ingredientTwoCount;
            }
            if (currentRecipe.ingredientThreeItem == null)
            {
                pictureBox4.Image = null;
                textBox4.Text = null;
            }
            else
            {
            pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientThreeItem.imageDir);
            textBox4.Text = currentRecipe.ingredientThreeItem.itemName + " X " + currentRecipe.ingredientThreeCount;
            }
            if (currentRecipe.ingredientFourItem == null)
            {
                pictureBox5.Image = null;
                textBox5.Text = null;
            }
            else
            {
            pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentRecipe.ingredientFourItem.imageDir);
            textBox5.Text = currentRecipe.ingredientFourItem.itemName + " X " + currentRecipe.ingredientFourCount;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Image != null)
            {
                CraftingRecipe getCurrentRecipe = craftingRecipes.Find(x => x.craftedItem.itemName.Equals(recipeBox.SelectedItem));
                ItemWithImage getCurrentSelection = getCurrentRecipe.ingredientOneItem;
                List<BaseItemConvert> getBaseConverts = baseItems.FindAll(x => x.resultItem.itemName.Equals(getCurrentSelection.itemName));
                if (getBaseConverts.Count == 0)
                    return;
                Form ingredientForm = new IngredientForm(getBaseConverts);
                ingredientForm.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                CraftingRecipe getCurrentRecipe = craftingRecipes.Find(x => x.craftedItem.itemName.Equals(recipeBox.SelectedItem));
                ItemWithImage getCurrentSelection = getCurrentRecipe.ingredientTwoItem;
                List<BaseItemConvert> getBaseConverts = baseItems.FindAll(x => x.resultItem.itemName.Equals(getCurrentSelection.itemName));
                if (getBaseConverts.Count == 0)
                    return;
                Form ingredientForm = new IngredientForm(getBaseConverts);
                ingredientForm.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
            {
                CraftingRecipe getCurrentRecipe = craftingRecipes.Find(x => x.craftedItem.itemName.Equals(recipeBox.SelectedItem));
                ItemWithImage getCurrentSelection = getCurrentRecipe.ingredientThreeItem;
                List<BaseItemConvert> getBaseConverts = baseItems.FindAll(x => x.resultItem.itemName.Equals(getCurrentSelection.itemName));
                if (getBaseConverts.Count == 0)
                    return;
                Form ingredientForm = new IngredientForm(getBaseConverts);
                ingredientForm.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                CraftingRecipe getCurrentRecipe = craftingRecipes.Find(x => x.craftedItem.itemName.Equals(recipeBox.SelectedItem));
                ItemWithImage getCurrentSelection = getCurrentRecipe.ingredientFourItem;
                List<BaseItemConvert> getBaseConverts = baseItems.FindAll(x => x.resultItem.itemName.Equals(getCurrentSelection.itemName));
                if (getBaseConverts.Count == 0)
                    return;
                Form ingredientForm = new IngredientForm(getBaseConverts);
                ingredientForm.Show();
            }
        }
    }
}
