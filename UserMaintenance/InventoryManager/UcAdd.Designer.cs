namespace InventoryManager
{
    partial class UcAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxOnHandAdd = new TextBox();
            textBoxReservedAdd = new TextBox();
            textBoxLowAdd = new TextBox();
            textBoxOutAdd = new TextBox();
            btnSaveAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Raktáron:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Foglalt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 107);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 2;
            label3.Text = "Alacsony termékkészleti pont:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 151);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 3;
            label4.Text = "Termékkészlet kifogyási pont:";
            // 
            // textBoxOnHandAdd
            // 
            textBoxOnHandAdd.Location = new Point(27, 37);
            textBoxOnHandAdd.Name = "textBoxOnHandAdd";
            textBoxOnHandAdd.Size = new Size(164, 23);
            textBoxOnHandAdd.TabIndex = 4;
            // 
            // textBoxReservedAdd
            // 
            textBoxReservedAdd.Location = new Point(27, 81);
            textBoxReservedAdd.Name = "textBoxReservedAdd";
            textBoxReservedAdd.Size = new Size(164, 23);
            textBoxReservedAdd.TabIndex = 5;
            // 
            // textBoxLowAdd
            // 
            textBoxLowAdd.Location = new Point(27, 125);
            textBoxLowAdd.Name = "textBoxLowAdd";
            textBoxLowAdd.Size = new Size(164, 23);
            textBoxLowAdd.TabIndex = 6;
            // 
            // textBoxOutAdd
            // 
            textBoxOutAdd.Location = new Point(27, 169);
            textBoxOutAdd.Name = "textBoxOutAdd";
            textBoxOutAdd.Size = new Size(164, 23);
            textBoxOutAdd.TabIndex = 7;
            // 
            // btnSaveAdd
            // 
            btnSaveAdd.Location = new Point(65, 198);
            btnSaveAdd.Name = "btnSaveAdd";
            btnSaveAdd.Size = new Size(75, 23);
            btnSaveAdd.TabIndex = 8;
            btnSaveAdd.Text = "Hozzáadás";
            btnSaveAdd.UseVisualStyleBackColor = true;
            // 
            // UcAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSaveAdd);
            Controls.Add(textBoxOutAdd);
            Controls.Add(textBoxLowAdd);
            Controls.Add(textBoxReservedAdd);
            Controls.Add(textBoxOnHandAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcAdd";
            Size = new Size(348, 289);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxOnHandAdd;
        private TextBox textBoxReservedAdd;
        private TextBox textBoxLowAdd;
        private TextBox textBoxOutAdd;
        private Button btnSaveAdd;
    }
}
