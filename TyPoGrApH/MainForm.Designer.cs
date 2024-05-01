namespace TyPoGrApH
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainRTextBox = new System.Windows.Forms.RichTextBox();
            this.MainLbl = new System.Windows.Forms.Label();
            this.MainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainRTextBox
            // 
            this.MainRTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MainRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainRTextBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainRTextBox.Location = new System.Drawing.Point(70, 135);
            this.MainRTextBox.Name = "MainRTextBox";
            this.MainRTextBox.Size = new System.Drawing.Size(663, 243);
            this.MainRTextBox.TabIndex = 0;
            this.MainRTextBox.Text = "";
            // 
            // MainLbl
            // 
            this.MainLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainLbl.BackColor = System.Drawing.Color.LavenderBlush;
            this.MainLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLbl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MainLbl.Location = new System.Drawing.Point(70, 78);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(663, 54);
            this.MainLbl.TabIndex = 1;
            this.MainLbl.Text = "ВВЕДИТЕ ТЕКСТ, КОТОРЫЙ ХОТИТЕ ИСПРАВИТЬ";
            this.MainLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainBtn
            // 
            this.MainBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MainBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.MainBtn.FlatAppearance.BorderSize = 2;
            this.MainBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MainBtn.Location = new System.Drawing.Point(297, 384);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(177, 64);
            this.MainBtn.TabIndex = 2;
            this.MainBtn.Text = "ИСПРАВИТЬ";
            this.MainBtn.UseVisualStyleBackColor = false;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 471);
            this.Controls.Add(this.MainBtn);
            this.Controls.Add(this.MainLbl);
            this.Controls.Add(this.MainRTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ТИПОГРАФ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainRTextBox;
        private System.Windows.Forms.Label MainLbl;
        private System.Windows.Forms.Button MainBtn;
    }
}

