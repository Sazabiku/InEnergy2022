namespace ИнЭнерджи.project
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
            this.теорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.натрийИонныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.литийИонныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.модельПотребленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.натрийИонныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теорияToolStripMenuItem,
            this.расчётыToolStripMenuItem,
            this.модельПотребленияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // теорияToolStripMenuItem
            // 
            this.теорияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.натрийИонныеToolStripMenuItem});
            this.теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            this.теорияToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.теорияToolStripMenuItem.Text = "Теория";
            // 
            // натрийИонныеToolStripMenuItem
            // 
            this.натрийИонныеToolStripMenuItem.Name = "натрийИонныеToolStripMenuItem";
            this.натрийИонныеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.натрийИонныеToolStripMenuItem.Text = "Литий-Ионные";
            this.натрийИонныеToolStripMenuItem.Click += new System.EventHandler(this.натрийИонныеToolStripMenuItem_Click);
            // 
            // расчётыToolStripMenuItem
            // 
            this.расчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.литийИонныеToolStripMenuItem1,
            this.натрийИонныеToolStripMenuItem1});
            this.расчётыToolStripMenuItem.Name = "расчётыToolStripMenuItem";
            this.расчётыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.расчётыToolStripMenuItem.Text = "Расчёты";
            // 
            // литийИонныеToolStripMenuItem1
            // 
            this.литийИонныеToolStripMenuItem1.Name = "литийИонныеToolStripMenuItem1";
            this.литийИонныеToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.литийИонныеToolStripMenuItem1.Text = "Литий-Ионные";
            this.литийИонныеToolStripMenuItem1.Click += new System.EventHandler(this.литийИонныеToolStripMenuItem1_Click);
            // 
            // модельПотребленияToolStripMenuItem
            // 
            this.модельПотребленияToolStripMenuItem.Name = "модельПотребленияToolStripMenuItem";
            this.модельПотребленияToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.модельПотребленияToolStripMenuItem.Text = "Модель Потребления";
            this.модельПотребленияToolStripMenuItem.Click += new System.EventHandler(this.модельПотребленияToolStripMenuItem_Click);
            // 
            // натрийИонныеToolStripMenuItem1
            // 
            this.натрийИонныеToolStripMenuItem1.Name = "натрийИонныеToolStripMenuItem1";
            this.натрийИонныеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.натрийИонныеToolStripMenuItem1.Text = "Натрий-Ионные";
            this.натрийИонныеToolStripMenuItem1.Click += new System.EventHandler(this.натрийИонныеToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 561);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adAstra.project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem натрийИонныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem литийИонныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem модельПотребленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem натрийИонныеToolStripMenuItem1;
    }
}

