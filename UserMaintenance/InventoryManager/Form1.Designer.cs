namespace InventoryManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxProduct = new TextBox();
            textBoxCategory = new TextBox();
            listBoxProduct = new ListBox();
            listBoxCategory = new ListBox();
            dataGridView = new DataGridView();
            panel = new Panel();
            btnAdd = new Button();
            btnOverride = new Button();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxProduct
            // 
            textBoxProduct.Location = new Point(20, 26);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(190, 23);
            textBoxProduct.TabIndex = 0;
            textBoxProduct.TextChanged += textBoxProduct_TextChanged;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(20, 347);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(190, 23);
            textBoxCategory.TabIndex = 1;
            textBoxCategory.TextChanged += textBoxCategory_TextChanged;
            // 
            // listBoxProduct
            // 
            listBoxProduct.FormattingEnabled = true;
            listBoxProduct.ItemHeight = 15;
            listBoxProduct.Location = new Point(20, 55);
            listBoxProduct.Name = "listBoxProduct";
            listBoxProduct.Size = new Size(190, 259);
            listBoxProduct.TabIndex = 2;
            listBoxProduct.SelectedIndexChanged += listBoxProduct_SelectedIndexChanged;
            // 
            // listBoxCategory
            // 
            listBoxCategory.FormattingEnabled = true;
            listBoxCategory.ItemHeight = 15;
            listBoxCategory.Location = new Point(20, 376);
            listBoxCategory.Name = "listBoxCategory";
            listBoxCategory.Size = new Size(190, 259);
            listBoxCategory.TabIndex = 3;
            listBoxCategory.SelectedIndexChanged += listBoxCategory_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(240, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(392, 609);
            dataGridView.TabIndex = 4;
            // 
            // panel
            // 
            panel.Location = new Point(667, 55);
            panel.Name = "panel";
            panel.Size = new Size(419, 364);
            panel.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(667, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Készletek hozzáadása";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnOverride
            // 
            btnOverride.Location = new Point(808, 25);
            btnOverride.Name = "btnOverride";
            btnOverride.Size = new Size(135, 23);
            btnOverride.TabIndex = 7;
            btnOverride.Text = "Készletek felülírása";
            btnOverride.UseVisualStyleBackColor = true;
            btnOverride.Click += btnOverride_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1122, 658);
            Controls.Add(btnOverride);
            Controls.Add(btnAdd);
            Controls.Add(panel);
            Controls.Add(dataGridView);
            Controls.Add(listBoxCategory);
            Controls.Add(listBoxProduct);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxProduct);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProduct;
        private TextBox textBoxCategory;
        private ListBox listBoxProduct;
        private ListBox listBoxCategory;
        private DataGridView dataGridView;
        private Panel panel;
        private Button btnAdd;
        private Button btnOverride;
        private BindingSource productBindingSource;
    }
}