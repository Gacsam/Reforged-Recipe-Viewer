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
    public partial class IngredientForm : Form
    {
        private List<BaseItemConvert> baseItems;

        public IngredientForm(List<BaseItemConvert> baseItems)
        {
            this.baseItems = baseItems;
            InitializeComponent();
            Text = baseItems[0].resultItem.itemName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Text;
            foreach(BaseItemConvert baseItem in baseItems)
            {
                listBox1.Items.Add(baseItem.ingredientItem.itemName);
            }
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "X " + baseItems[listBox1.SelectedIndex].resultCount;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(baseItems[listBox1.SelectedIndex].ingredientItem.imageDir);
            textBox1.Text = baseItems[listBox1.SelectedIndex].description;
        }
    }
}
