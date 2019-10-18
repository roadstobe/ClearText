namespace ClearText
{
    partial class MainForm
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
            this.buttonLoadDictionary = new System.Windows.Forms.Button();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.textBoxMainText = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStat = new System.Windows.Forms.Label();
            this.textBoxStat = new System.Windows.Forms.TextBox();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadDictionary
            // 
            this.buttonLoadDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadDictionary.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadDictionary.Name = "buttonLoadDictionary";
            this.buttonLoadDictionary.Size = new System.Drawing.Size(113, 63);
            this.buttonLoadDictionary.TabIndex = 0;
            this.buttonLoadDictionary.Text = "Завантажити словник";
            this.buttonLoadDictionary.UseVisualStyleBackColor = true;
            this.buttonLoadDictionary.Click += new System.EventHandler(this.buttonLoadDictionary_Click);
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 4;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0531F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.9469F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayout.Controls.Add(this.button1, 1, 0);
            this.mainTableLayout.Controls.Add(this.buttonLoadDictionary, 0, 0);
            this.mainTableLayout.Controls.Add(this.labelFilter, 0, 1);
            this.mainTableLayout.Controls.Add(this.textBoxFilter, 0, 2);
            this.mainTableLayout.Controls.Add(this.textBoxMainText, 1, 2);
            this.mainTableLayout.Controls.Add(this.buttonShow, 1, 1);
            this.mainTableLayout.Controls.Add(this.buttonHide, 2, 1);
            this.mainTableLayout.Controls.Add(this.buttonSave, 1, 3);
            this.mainTableLayout.Controls.Add(this.labelStat, 3, 0);
            this.mainTableLayout.Controls.Add(this.textBoxStat, 3, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 4;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.75F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.25F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.mainTableLayout.Size = new System.Drawing.Size(819, 345);
            this.mainTableLayout.TabIndex = 1;
            // 
            // button1
            // 
            this.mainTableLayout.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(122, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Завантажити файл на перевірку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilter.Location = new System.Drawing.Point(3, 69);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(113, 48);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Фiльтр:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilter.Location = new System.Drawing.Point(3, 120);
            this.textBoxFilter.Multiline = true;
            this.textBoxFilter.Name = "textBoxFilter";
            this.mainTableLayout.SetRowSpan(this.textBoxFilter, 2);
            this.textBoxFilter.Size = new System.Drawing.Size(113, 222);
            this.textBoxFilter.TabIndex = 2;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // textBoxMainText
            // 
            this.mainTableLayout.SetColumnSpan(this.textBoxMainText, 2);
            this.textBoxMainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainText.Location = new System.Drawing.Point(122, 120);
            this.textBoxMainText.Multiline = true;
            this.textBoxMainText.Name = "textBoxMainText";
            this.textBoxMainText.Size = new System.Drawing.Size(443, 187);
            this.textBoxMainText.TabIndex = 4;
            // 
            // buttonShow
            // 
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Location = new System.Drawing.Point(122, 72);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(189, 42);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Показати виправлення";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHide.Location = new System.Drawing.Point(317, 72);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(248, 42);
            this.buttonHide.TabIndex = 5;
            this.buttonHide.Text = "Сховати виправлення";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonSave
            // 
            this.mainTableLayout.SetColumnSpan(this.buttonSave, 2);
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(122, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(443, 29);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Завантажити з виправленнями";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStat.Location = new System.Drawing.Point(571, 0);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(245, 69);
            this.labelStat.TabIndex = 6;
            this.labelStat.Text = "Статистика:";
            this.labelStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStat
            // 
            this.textBoxStat.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStat.Enabled = false;
            this.textBoxStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStat.Location = new System.Drawing.Point(571, 72);
            this.textBoxStat.Multiline = true;
            this.textBoxStat.Name = "textBoxStat";
            this.mainTableLayout.SetRowSpan(this.textBoxStat, 2);
            this.textBoxStat.Size = new System.Drawing.Size(245, 235);
            this.textBoxStat.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 345);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "MainForm";
            this.Text = "Clear Text";
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadDictionary;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMainText;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.TextBox textBoxStat;
    }
}

