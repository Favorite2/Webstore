namespace Furniture_store
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenProducts = new System.Windows.Forms.Button();
            this.buttonProvider = new System.Windows.Forms.Button();
            this.buttonOpenProduct = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(14, 135);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(274, 53);
            this.buttonOpenClients.TabIndex = 0;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.Location = new System.Drawing.Point(14, 195);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(274, 53);
            this.buttonOpenAgents.TabIndex = 1;
            this.buttonOpenAgents.Text = "Агенты";
            this.buttonOpenAgents.UseVisualStyleBackColor = true;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // buttonOpenProducts
            // 
            this.buttonOpenProducts.Location = new System.Drawing.Point(14, 255);
            this.buttonOpenProducts.Name = "buttonOpenProducts";
            this.buttonOpenProducts.Size = new System.Drawing.Size(274, 53);
            this.buttonOpenProducts.TabIndex = 2;
            this.buttonOpenProducts.Text = "Товары";
            this.buttonOpenProducts.UseVisualStyleBackColor = true;
            this.buttonOpenProducts.Click += new System.EventHandler(this.buttonOpenProducts_Click);
            // 
            // buttonProvider
            // 
            this.buttonProvider.Location = new System.Drawing.Point(14, 317);
            this.buttonProvider.Name = "buttonProvider";
            this.buttonProvider.Size = new System.Drawing.Size(274, 53);
            this.buttonProvider.TabIndex = 3;
            this.buttonProvider.Text = "Поставщик";
            this.buttonProvider.UseVisualStyleBackColor = true;
            this.buttonProvider.Click += new System.EventHandler(this.buttonProvider_Click);
            // 
            // buttonOpenProduct
            // 
            this.buttonOpenProduct.Location = new System.Drawing.Point(14, 380);
            this.buttonOpenProduct.Name = "buttonOpenProduct";
            this.buttonOpenProduct.Size = new System.Drawing.Size(274, 53);
            this.buttonOpenProduct.TabIndex = 4;
            this.buttonOpenProduct.Text = "Учёт товара";
            this.buttonOpenProduct.UseVisualStyleBackColor = true;
            this.buttonOpenProduct.Click += new System.EventHandler(this.buttonOpenProduct_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(14, 10);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 15);
            this.labelHello.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Furniture_store.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenProduct);
            this.Controls.Add(this.buttonProvider);
            this.Controls.Add(this.buttonOpenProducts);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenProducts;
        private System.Windows.Forms.Button buttonProvider;
        private System.Windows.Forms.Button buttonOpenProduct;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

