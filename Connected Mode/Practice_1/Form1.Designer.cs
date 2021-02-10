namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБазойДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsynchConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБазойДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСБазойДанныхToolStripMenuItem
            // 
            this.работаСБазойДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToolStripMenuItem,
            this.DisconnectToolStripMenuItem,
            this.AsynchConnectToolStripMenuItem,
            this.ConnectionListToolStripMenuItem});
            this.работаСБазойДанныхToolStripMenuItem.Name = "работаСБазойДанныхToolStripMenuItem";
            this.работаСБазойДанныхToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.работаСБазойДанныхToolStripMenuItem.Text = "&Работа с базой данных";
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.ConnectToolStripMenuItem.Text = "&Подключиться к БД";
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // DisconnectToolStripMenuItem
            // 
            this.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem";
            this.DisconnectToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.DisconnectToolStripMenuItem.Text = "&Отключиться от БД";
            this.DisconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // AsynchConnectToolStripMenuItem
            // 
            this.AsynchConnectToolStripMenuItem.Name = "AsynchConnectToolStripMenuItem";
            this.AsynchConnectToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.AsynchConnectToolStripMenuItem.Text = "&Асинхронное подключение к БД";
            this.AsynchConnectToolStripMenuItem.Click += new System.EventHandler(this.AsynchConnectToolStripMenuItem_Click);
            // 
            // ConnectionListToolStripMenuItem
            // 
            this.ConnectionListToolStripMenuItem.Name = "ConnectionListToolStripMenuItem";
            this.ConnectionListToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.ConnectionListToolStripMenuItem.Text = "&Список подключений";
            this.ConnectionListToolStripMenuItem.Click += new System.EventHandler(this.ConnectionListToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 224);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБазойДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsynchConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectionListToolStripMenuItem;
    }
}

