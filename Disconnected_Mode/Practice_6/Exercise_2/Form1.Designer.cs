namespace LoadDataSetXml
{
    partial class Form1
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.LoadSchemaButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(12, 12);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(342, 276);
            this.CustomersGrid.TabIndex = 0;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Location = new System.Drawing.Point(380, 12);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(342, 276);
            this.OrdersGrid.TabIndex = 1;
            // 
            // LoadSchemaButton
            // 
            this.LoadSchemaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadSchemaButton.ForeColor = System.Drawing.Color.DarkRed;
            this.LoadSchemaButton.Location = new System.Drawing.Point(193, 312);
            this.LoadSchemaButton.Name = "LoadSchemaButton";
            this.LoadSchemaButton.Size = new System.Drawing.Size(342, 52);
            this.LoadSchemaButton.TabIndex = 2;
            this.LoadSchemaButton.Text = "Load Schema";
            this.LoadSchemaButton.UseVisualStyleBackColor = true;
            this.LoadSchemaButton.Click += new System.EventHandler(this.LoadSchemaButton_Click);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadDataButton.ForeColor = System.Drawing.Color.DarkRed;
            this.LoadDataButton.Location = new System.Drawing.Point(193, 370);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(342, 52);
            this.LoadDataButton.TabIndex = 3;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.LoadSchemaButton);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Button LoadSchemaButton;
        private System.Windows.Forms.Button LoadDataButton;
    }
}

