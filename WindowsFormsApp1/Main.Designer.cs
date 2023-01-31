namespace WindowsFormsApp1
{
    partial class Main
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
            this.types = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.textC = new System.Windows.Forms.TextBox();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.bDispalay = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSort = new System.Windows.Forms.Button();
            this.textSurnA = new System.Windows.Forms.TextBox();
            this.textSurnB = new System.Windows.Forms.TextBox();
            this.textSurnC = new System.Windows.Forms.TextBox();
            this.labelSurnA = new System.Windows.Forms.Label();
            this.labelSurnB = new System.Windows.Forms.Label();
            this.labelSurnC = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // types
            // 
            this.types.BackColor = System.Drawing.Color.Gray;
            this.types.ForeColor = System.Drawing.SystemColors.MenuText;
            this.types.FormattingEnabled = true;
            this.types.Items.AddRange(new object[] {
            "Integer",
            "Double",
            "String",
            "Person",
            "None"});
            this.types.Location = new System.Drawing.Point(367, 44);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(130, 24);
            this.types.TabIndex = 0;
            this.types.SelectedIndexChanged += new System.EventHandler(this.types_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelType.Location = new System.Drawing.Point(300, 44);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(49, 20);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            // 
            // textA
            // 
            this.textA.BackColor = System.Drawing.Color.Gray;
            this.textA.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textA.Location = new System.Drawing.Point(367, 86);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(130, 22);
            this.textA.TabIndex = 1;
            this.textA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textA_KeyPress);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelA.Location = new System.Drawing.Point(300, 86);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 20);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelB.Location = new System.Drawing.Point(299, 155);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(22, 20);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            // 
            // textB
            // 
            this.textB.BackColor = System.Drawing.Color.Gray;
            this.textB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textB.Location = new System.Drawing.Point(367, 154);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(130, 22);
            this.textB.TabIndex = 4;
            this.textB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textA_KeyPress);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelC.Location = new System.Drawing.Point(299, 221);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(22, 20);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "C";
            // 
            // textC
            // 
            this.textC.BackColor = System.Drawing.Color.Gray;
            this.textC.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textC.Location = new System.Drawing.Point(367, 220);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(130, 22);
            this.textC.TabIndex = 6;
            this.textC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textA_KeyPress);
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.Color.Gray;
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textDisplay.Location = new System.Drawing.Point(46, 57);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(227, 198);
            this.textDisplay.TabIndex = 8;
            // 
            // bDispalay
            // 
            this.bDispalay.Location = new System.Drawing.Point(46, 284);
            this.bDispalay.Name = "bDispalay";
            this.bDispalay.Size = new System.Drawing.Size(75, 30);
            this.bDispalay.TabIndex = 9;
            this.bDispalay.Text = "Display";
            this.bDispalay.UseVisualStyleBackColor = true;
            this.bDispalay.Click += new System.EventHandler(this.bDispalay_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(431, 284);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 30);
            this.bAdd.TabIndex = 10;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(189, 284);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(75, 30);
            this.bSort.TabIndex = 11;
            this.bSort.Text = "Sort";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // textSurnA
            // 
            this.textSurnA.BackColor = System.Drawing.Color.Gray;
            this.textSurnA.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textSurnA.Location = new System.Drawing.Point(376, 114);
            this.textSurnA.Name = "textSurnA";
            this.textSurnA.Size = new System.Drawing.Size(130, 22);
            this.textSurnA.TabIndex = 12;
            this.textSurnA.Visible = false;
            // 
            // textSurnB
            // 
            this.textSurnB.BackColor = System.Drawing.Color.Gray;
            this.textSurnB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textSurnB.Location = new System.Drawing.Point(376, 182);
            this.textSurnB.Name = "textSurnB";
            this.textSurnB.Size = new System.Drawing.Size(130, 22);
            this.textSurnB.TabIndex = 13;
            this.textSurnB.Visible = false;
            // 
            // textSurnC
            // 
            this.textSurnC.BackColor = System.Drawing.Color.Gray;
            this.textSurnC.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textSurnC.Location = new System.Drawing.Point(376, 248);
            this.textSurnC.Name = "textSurnC";
            this.textSurnC.Size = new System.Drawing.Size(130, 22);
            this.textSurnC.TabIndex = 14;
            this.textSurnC.Visible = false;
            // 
            // labelSurnA
            // 
            this.labelSurnA.AutoSize = true;
            this.labelSurnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurnA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSurnA.Location = new System.Drawing.Point(278, 114);
            this.labelSurnA.Name = "labelSurnA";
            this.labelSurnA.Size = new System.Drawing.Size(83, 20);
            this.labelSurnA.TabIndex = 15;
            this.labelSurnA.Text = "Surname";
            this.labelSurnA.Visible = false;
            // 
            // labelSurnB
            // 
            this.labelSurnB.AutoSize = true;
            this.labelSurnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurnB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSurnB.Location = new System.Drawing.Point(278, 184);
            this.labelSurnB.Name = "labelSurnB";
            this.labelSurnB.Size = new System.Drawing.Size(83, 20);
            this.labelSurnB.TabIndex = 16;
            this.labelSurnB.Text = "Surname";
            this.labelSurnB.Visible = false;
            // 
            // labelSurnC
            // 
            this.labelSurnC.AutoSize = true;
            this.labelSurnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurnC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSurnC.Location = new System.Drawing.Point(279, 249);
            this.labelSurnC.Name = "labelSurnC";
            this.labelSurnC.Size = new System.Drawing.Size(83, 20);
            this.labelSurnC.TabIndex = 17;
            this.labelSurnC.Text = "Surname";
            this.labelSurnC.Visible = false;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(350, 284);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 30);
            this.bClear.TabIndex = 18;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(527, 356);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.labelSurnC);
            this.Controls.Add(this.labelSurnB);
            this.Controls.Add(this.labelSurnA);
            this.Controls.Add(this.textSurnC);
            this.Controls.Add(this.textSurnB);
            this.Controls.Add(this.textSurnA);
            this.Controls.Add(this.bSort);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bDispalay);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.types);
            this.MaximumSize = new System.Drawing.Size(545, 403);
            this.MinimumSize = new System.Drawing.Size(545, 403);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab11";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox types;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button bDispalay;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.TextBox textSurnA;
        private System.Windows.Forms.TextBox textSurnB;
        private System.Windows.Forms.TextBox textSurnC;
        private System.Windows.Forms.Label labelSurnA;
        private System.Windows.Forms.Label labelSurnB;
        private System.Windows.Forms.Label labelSurnC;
        private System.Windows.Forms.Button bClear;
    }
}

