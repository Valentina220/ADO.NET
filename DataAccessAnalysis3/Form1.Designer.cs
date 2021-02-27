namespace DataAccessAnalysis3
{
    partial class SalesData
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
            this.TerritoryName = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.SalesTerritoryGrid = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.UpdateGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTerritoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TerritoryName
            // 
            this.TerritoryName.FormattingEnabled = true;
            this.TerritoryName.Location = new System.Drawing.Point(12, 12);
            this.TerritoryName.Name = "TerritoryName";
            this.TerritoryName.Size = new System.Drawing.Size(395, 21);
            this.TerritoryName.TabIndex = 0;
            this.TerritoryName.SelectedIndexChanged += new System.EventHandler(this.TerritoryName_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.Orange;
            this.closeForm.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeForm.ForeColor = System.Drawing.Color.Maroon;
            this.closeForm.Location = new System.Drawing.Point(461, 12);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(166, 40);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = " Закрыть";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // SalesTerritoryGrid
            // 
            this.SalesTerritoryGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.SalesTerritoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesTerritoryGrid.Location = new System.Drawing.Point(12, 39);
            this.SalesTerritoryGrid.Name = "SalesTerritoryGrid";
            this.SalesTerritoryGrid.Size = new System.Drawing.Size(395, 205);
            this.SalesTerritoryGrid.TabIndex = 2;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.Orange;
            this.saveChanges.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.ForeColor = System.Drawing.Color.Maroon;
            this.saveChanges.Location = new System.Drawing.Point(229, 505);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(166, 40);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // UpdateGrid
            // 
            this.UpdateGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.UpdateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateGrid.Location = new System.Drawing.Point(12, 277);
            this.UpdateGrid.Name = "UpdateGrid";
            this.UpdateGrid.Size = new System.Drawing.Size(615, 207);
            this.UpdateGrid.TabIndex = 4;
            // 
            // SalesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(639, 566);
            this.Controls.Add(this.UpdateGrid);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.SalesTerritoryGrid);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.TerritoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные по продажам";
            this.Load += new System.EventHandler(this.SalesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesTerritoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TerritoryName;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.DataGridView SalesTerritoryGrid;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.DataGridView UpdateGrid;
    }
}

