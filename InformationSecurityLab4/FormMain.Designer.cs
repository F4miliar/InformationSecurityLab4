namespace InformationSecurityLab4
{
    partial class FormMain
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
            this.comboBoxUserPick = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.listBoxObject = new System.Windows.Forms.ListBox();
            this.textBoxObjectEdit = new System.Windows.Forms.TextBox();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUserPick
            // 
            this.comboBoxUserPick.FormattingEnabled = true;
            this.comboBoxUserPick.Location = new System.Drawing.Point(159, 9);
            this.comboBoxUserPick.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUserPick.Name = "comboBoxUserPick";
            this.comboBoxUserPick.Size = new System.Drawing.Size(102, 21);
            this.comboBoxUserPick.TabIndex = 0;
            this.comboBoxUserPick.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserPick_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(9, 7);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(133, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Пользователь";
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Location = new System.Drawing.Point(311, 9);
            this.buttonUserEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(169, 20);
            this.buttonUserEdit.TabIndex = 2;
            this.buttonUserEdit.Text = "Редактировать пользователя";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
            // 
            // listBoxObject
            // 
            this.listBoxObject.FormattingEnabled = true;
            this.listBoxObject.Location = new System.Drawing.Point(13, 39);
            this.listBoxObject.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxObject.Name = "listBoxObject";
            this.listBoxObject.Size = new System.Drawing.Size(248, 212);
            this.listBoxObject.TabIndex = 3;
            this.listBoxObject.SelectedIndexChanged += new System.EventHandler(this.listBoxObject_SelectedIndexChanged);
            // 
            // textBoxObjectEdit
            // 
            this.textBoxObjectEdit.Location = new System.Drawing.Point(266, 39);
            this.textBoxObjectEdit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObjectEdit.Multiline = true;
            this.textBoxObjectEdit.Name = "textBoxObjectEdit";
            this.textBoxObjectEdit.Size = new System.Drawing.Size(248, 170);
            this.textBoxObjectEdit.TabIndex = 4;
            this.textBoxObjectEdit.TextChanged += new System.EventHandler(this.textBoxObjectEdit_TextChanged);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Enabled = false;
            this.buttonPaste.Location = new System.Drawing.Point(266, 214);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(124, 37);
            this.buttonPaste.TabIndex = 5;
            this.buttonPaste.Text = "Вставить";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Location = new System.Drawing.Point(390, 214);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(124, 37);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 262);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.textBoxObjectEdit);
            this.Controls.Add(this.listBoxObject);
            this.Controls.Add(this.buttonUserEdit);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUserPick);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Матрица доступа (Выбор)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserPick;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonUserEdit;
        private System.Windows.Forms.ListBox listBoxObject;
        private System.Windows.Forms.TextBox textBoxObjectEdit;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonCopy;
    }
}

