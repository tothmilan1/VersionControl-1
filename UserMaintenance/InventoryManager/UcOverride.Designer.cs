namespace InventoryManager
{
    partial class UcOverride
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
            textBoxOutOverride = new TextBox();
            textBoxLowOverride = new TextBox();
            textBoxReservedOverride = new TextBox();
            textBoxOnHandOverride = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSaveOverride = new Button();
            SuspendLayout();
            // 
            // textBoxOutOverride
            // 
            textBoxOutOverride.Location = new Point(26, 169);
            textBoxOutOverride.Name = "textBoxOutOverride";
            textBoxOutOverride.Size = new Size(164, 23);
            textBoxOutOverride.TabIndex = 15;
            // 
            // textBoxLowOverride
            // 
            textBoxLowOverride.Location = new Point(26, 125);
            textBoxLowOverride.Name = "textBoxLowOverride";
            textBoxLowOverride.Size = new Size(164, 23);
            textBoxLowOverride.TabIndex = 14;
            // 
            // textBoxReservedOverride
            // 
            textBoxReservedOverride.Location = new Point(26, 81);
            textBoxReservedOverride.Name = "textBoxReservedOverride";
            textBoxReservedOverride.Size = new Size(164, 23);
            textBoxReservedOverride.TabIndex = 13;
            // 
            // textBoxOnHandOverride
            // 
            textBoxOnHandOverride.Location = new Point(26, 37);
            textBoxOnHandOverride.Name = "textBoxOnHandOverride";
            textBoxOnHandOverride.Size = new Size(164, 23);
            textBoxOnHandOverride.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 151);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 11;
            label4.Text = "Termékkészlet kifogyási pont:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 107);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 10;
            label3.Text = "Alacsony termékkészleti pont:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "Foglalt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Raktáron:";
            // 
            // buttonSaveOverride
            // 
            buttonSaveOverride.Location = new Point(69, 198);
            buttonSaveOverride.Name = "buttonSaveOverride";
            buttonSaveOverride.Size = new Size(75, 23);
            buttonSaveOverride.TabIndex = 16;
            buttonSaveOverride.Text = "Felülírás";
            buttonSaveOverride.UseVisualStyleBackColor = true;
            // 
            // UcOverride
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSaveOverride);
            Controls.Add(textBoxOutOverride);
            Controls.Add(textBoxLowOverride);
            Controls.Add(textBoxReservedOverride);
            Controls.Add(textBoxOnHandOverride);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcOverride";
            Size = new Size(356, 293);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOutOverride;
        private TextBox textBoxLowOverride;
        private TextBox textBoxReservedOverride;
        private TextBox textBoxOnHandOverride;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSaveOverride;
    }
}
