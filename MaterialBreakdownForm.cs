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
    public partial class MaterialBreakdownForm : Form
    {
        private readonly List<MaterialBreakdown> currentIngredientMaterials;
        private readonly List<MaterialBreakdown> allMaterialsToIngredients;

        public MaterialBreakdownForm(List<MaterialBreakdown> ingredientBases, List<MaterialBreakdown> breakdownList)
        {
            currentIngredientMaterials = ingredientBases;
            allMaterialsToIngredients = breakdownList;
            InitializeComponent();
            Text = "[MUTLIUSE] material can be used for other ingredients";
            TopMost = true;
        }

        private void IngredientForm_Load(object sender, EventArgs e)
        {
            List<MaterialBreakdown> usedByMultipleRecipes = new List<MaterialBreakdown>();
            foreach (MaterialBreakdown currentBreakdown in allMaterialsToIngredients)
            {
                List<MaterialBreakdown> getCurrentRecipe = allMaterialsToIngredients.FindAll(x => x.material.itemName.Equals(currentBreakdown.material.itemName));
                if (getCurrentRecipe.Count > 1 && !usedByMultipleRecipes.Contains(currentBreakdown))
                {
                    usedByMultipleRecipes.Add(currentBreakdown);
                }
            }

            label1.Text = currentIngredientMaterials[0].convertedIngredient.itemName;
            foreach(MaterialBreakdown baseItem in currentIngredientMaterials)
            {
                if (usedByMultipleRecipes.Contains(baseItem))
                {
                    materialList.Items.Add(baseItem.material.itemName + " [MULTIUSE]");
                }
                else
                {
                    materialList.Items.Add(baseItem.material.itemName);
                }
            }
            materialList.SelectedIndex = 0;
        }

        private void MaterialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "X " + currentIngredientMaterials[materialList.SelectedIndex].ingredientCount;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentIngredientMaterials[materialList.SelectedIndex].material.imageDir);
            textBox1.Text = currentIngredientMaterials[materialList.SelectedIndex].description;
        }
    }
}
