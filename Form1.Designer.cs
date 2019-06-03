namespace Milestone_3
{
    partial class Form1
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
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.restockItem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.yourInventory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(201, 45);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 0;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.Button1_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(201, 74);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(75, 23);
            this.removeItem.TabIndex = 1;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // restockItem
            // 
            this.restockItem.Location = new System.Drawing.Point(201, 103);
            this.restockItem.Name = "restockItem";
            this.restockItem.Size = new System.Drawing.Size(75, 23);
            this.restockItem.TabIndex = 2;
            this.restockItem.Text = "Restock";
            this.restockItem.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // yourInventory
            // 
            this.yourInventory.FormattingEnabled = true;
            this.yourInventory.Location = new System.Drawing.Point(49, 45);
            this.yourInventory.Name = "yourInventory";
            this.yourInventory.Size = new System.Drawing.Size(120, 95);
            this.yourInventory.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yourInventory);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.restockItem);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button restockItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox yourInventory;
    }
}

