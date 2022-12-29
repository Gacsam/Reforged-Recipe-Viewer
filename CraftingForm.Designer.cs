
namespace CraftingTool
{
    partial class CraftingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.recipeImage = new System.Windows.Forms.PictureBox();
            this.ingredientOne = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ingredientFour = new System.Windows.Forms.PictureBox();
            this.ingredientThree = new System.Windows.Forms.PictureBox();
            this.ingredientTwo = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.recipeBox = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientOne)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeImage
            // 
            this.recipeImage.BackColor = System.Drawing.SystemColors.Control;
            this.recipeImage.Location = new System.Drawing.Point(359, 5);
            this.recipeImage.Name = "recipeImage";
            this.recipeImage.Size = new System.Drawing.Size(200, 200);
            this.recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recipeImage.TabIndex = 4;
            this.recipeImage.TabStop = false;
            // 
            // ingredientOne
            // 
            this.ingredientOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ingredientOne.BackColor = System.Drawing.SystemColors.Control;
            this.ingredientOne.Location = new System.Drawing.Point(51, 3);
            this.ingredientOne.Name = "ingredientOne";
            this.ingredientOne.Size = new System.Drawing.Size(164, 164);
            this.ingredientOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ingredientOne.TabIndex = 4;
            this.ingredientOne.TabStop = false;
            this.ingredientOne.Click += new System.EventHandler(this.PictureBox_ingredientOne);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.3386F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ingredientFour, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ingredientThree, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ingredientTwo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ingredientOne, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.7971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 407);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(270, 374);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(265, 24);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(3, 374);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(261, 24);
            this.textBox4.TabIndex = 10;
            // 
            // ingredientFour
            // 
            this.ingredientFour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ingredientFour.BackColor = System.Drawing.SystemColors.Control;
            this.ingredientFour.Location = new System.Drawing.Point(320, 214);
            this.ingredientFour.Name = "ingredientFour";
            this.ingredientFour.Size = new System.Drawing.Size(164, 154);
            this.ingredientFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ingredientFour.TabIndex = 9;
            this.ingredientFour.TabStop = false;
            this.ingredientFour.Click += new System.EventHandler(this.PictureBox_ingredientFour);
            // 
            // ingredientThree
            // 
            this.ingredientThree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ingredientThree.BackColor = System.Drawing.SystemColors.Control;
            this.ingredientThree.Location = new System.Drawing.Point(51, 214);
            this.ingredientThree.Name = "ingredientThree";
            this.ingredientThree.Size = new System.Drawing.Size(164, 154);
            this.ingredientThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ingredientThree.TabIndex = 8;
            this.ingredientThree.TabStop = false;
            this.ingredientThree.Click += new System.EventHandler(this.PictureBox_ingredientThree);
            // 
            // ingredientTwo
            // 
            this.ingredientTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ingredientTwo.BackColor = System.Drawing.SystemColors.Control;
            this.ingredientTwo.Location = new System.Drawing.Point(320, 3);
            this.ingredientTwo.Name = "ingredientTwo";
            this.ingredientTwo.Size = new System.Drawing.Size(164, 164);
            this.ingredientTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ingredientTwo.TabIndex = 6;
            this.ingredientTwo.TabStop = false;
            this.ingredientTwo.Click += new System.EventHandler(this.PictureBox_ingredientTwo);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(270, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(265, 24);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(3, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(261, 24);
            this.textBox2.TabIndex = 5;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(24, 12);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(302, 21);
            this.categoryBox.Sorted = true;
            this.categoryBox.TabIndex = 8;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged);
            // 
            // recipeBox
            // 
            this.recipeBox.FormattingEnabled = true;
            this.recipeBox.Location = new System.Drawing.Point(24, 44);
            this.recipeBox.Name = "recipeBox";
            this.recipeBox.Size = new System.Drawing.Size(302, 121);
            this.recipeBox.Sorted = true;
            this.recipeBox.TabIndex = 9;
            this.recipeBox.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(176, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click images for material breakdown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(327, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 11;
            // 
            // CraftingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipeBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.recipeImage);
            this.MaximizeBox = false;
            this.Name = "CraftingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CraftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientOne)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox recipeImage;
        private System.Windows.Forms.PictureBox ingredientOne;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox ingredientFour;
        private System.Windows.Forms.PictureBox ingredientThree;
        private System.Windows.Forms.PictureBox ingredientTwo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ListBox recipeBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}