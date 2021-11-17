namespace aesEncryptionDecryption
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.keyField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vectorField = new System.Windows.Forms.TextBox();
            this.inputField = new System.Windows.Forms.RichTextBox();
            this.outputField = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton1.Location = new System.Drawing.Point(19, 294);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Зашифрувати";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.Location = new System.Drawing.Point(19, 322);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Розшифрувати";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // keyField
            // 
            this.keyField.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.keyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyField.Location = new System.Drawing.Point(19, 197);
            this.keyField.Margin = new System.Windows.Forms.Padding(2);
            this.keyField.Name = "keyField";
            this.keyField.Size = new System.Drawing.Size(140, 26);
            this.keyField.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(18, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вектор ініціалізації";
            // 
            // vectorField
            // 
            this.vectorField.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vectorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vectorField.Location = new System.Drawing.Point(19, 253);
            this.vectorField.Margin = new System.Windows.Forms.Padding(2);
            this.vectorField.Name = "vectorField";
            this.vectorField.Size = new System.Drawing.Size(147, 26);
            this.vectorField.TabIndex = 6;
            // 
            // inputField
            // 
            this.inputField.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputField.Location = new System.Drawing.Point(202, 11);
            this.inputField.Margin = new System.Windows.Forms.Padding(2);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(361, 335);
            this.inputField.TabIndex = 7;
            this.inputField.Text = "";
            // 
            // outputField
            // 
            this.outputField.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputField.Location = new System.Drawing.Point(595, 11);
            this.outputField.Margin = new System.Windows.Forms.Padding(2);
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(363, 335);
            this.outputField.TabIndex = 8;
            this.outputField.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 365);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 93);
            this.button2.TabIndex = 12;
            this.button2.Text = "Виконати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.vectorField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AES_128";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vectorField;
        private System.Windows.Forms.RichTextBox inputField;
        private System.Windows.Forms.RichTextBox outputField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

