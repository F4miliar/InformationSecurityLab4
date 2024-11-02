namespace InformationSecurityLab4
{
    partial class FormEdit
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonObjectAdd = new System.Windows.Forms.Button();
            this.labelObjectName = new System.Windows.Forms.Label();
            this.textBoxObjectName = new System.Windows.Forms.TextBox();
            this.dataGridViewAccesses = new System.Windows.Forms.DataGridView();
            this.comboBoxUserPick = new System.Windows.Forms.ComboBox();
            this.comboBoxObjectPick = new System.Windows.Forms.ComboBox();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.buttonObjectDelete = new System.Windows.Forms.Button();
            this.numericUpDownAccessPick = new System.Windows.Forms.NumericUpDown();
            this.buttonAccessAdd = new System.Windows.Forms.Button();
            this.dataGridViewUsersPrivilages = new System.Windows.Forms.DataGridView();
            this.dataGridViewObjectPrivilages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersPrivilages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivilages)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(12, 32);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(9, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(103, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Имя пользователя";
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(13, 59);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(99, 23);
            this.buttonUserAdd.TabIndex = 2;
            this.buttonUserAdd.Text = "Добавить";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // buttonObjectAdd
            // 
            this.buttonObjectAdd.Location = new System.Drawing.Point(139, 59);
            this.buttonObjectAdd.Name = "buttonObjectAdd";
            this.buttonObjectAdd.Size = new System.Drawing.Size(99, 23);
            this.buttonObjectAdd.TabIndex = 5;
            this.buttonObjectAdd.Text = "Добавить";
            this.buttonObjectAdd.UseVisualStyleBackColor = true;
            this.buttonObjectAdd.Click += new System.EventHandler(this.buttonObjectAdd_Click);
            // 
            // labelObjectName
            // 
            this.labelObjectName.AutoSize = true;
            this.labelObjectName.Location = new System.Drawing.Point(135, 9);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(92, 13);
            this.labelObjectName.TabIndex = 4;
            this.labelObjectName.Text = "Название файла";
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Location = new System.Drawing.Point(138, 32);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.Size = new System.Drawing.Size(100, 20);
            this.textBoxObjectName.TabIndex = 3;
            // 
            // dataGridViewAccesses
            // 
            this.dataGridViewAccesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccesses.Location = new System.Drawing.Point(13, 101);
            this.dataGridViewAccesses.MultiSelect = false;
            this.dataGridViewAccesses.Name = "dataGridViewAccesses";
            this.dataGridViewAccesses.ReadOnly = true;
            this.dataGridViewAccesses.RowHeadersVisible = false;
            this.dataGridViewAccesses.RowHeadersWidth = 51;
            this.dataGridViewAccesses.Size = new System.Drawing.Size(225, 150);
            this.dataGridViewAccesses.TabIndex = 6;
            this.dataGridViewAccesses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccesses_CellClick);
            // 
            // comboBoxUserPick
            // 
            this.comboBoxUserPick.FormattingEnabled = true;
            this.comboBoxUserPick.Location = new System.Drawing.Point(13, 258);
            this.comboBoxUserPick.Name = "comboBoxUserPick";
            this.comboBoxUserPick.Size = new System.Drawing.Size(99, 21);
            this.comboBoxUserPick.TabIndex = 7;
            this.comboBoxUserPick.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserPick_SelectedIndexChanged);
            // 
            // comboBoxObjectPick
            // 
            this.comboBoxObjectPick.FormattingEnabled = true;
            this.comboBoxObjectPick.Location = new System.Drawing.Point(138, 257);
            this.comboBoxObjectPick.Name = "comboBoxObjectPick";
            this.comboBoxObjectPick.Size = new System.Drawing.Size(99, 21);
            this.comboBoxObjectPick.TabIndex = 8;
            this.comboBoxObjectPick.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjectPick_SelectedIndexChanged);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(12, 285);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(99, 23);
            this.buttonUserDelete.TabIndex = 9;
            this.buttonUserDelete.Text = "Удалить";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // buttonObjectDelete
            // 
            this.buttonObjectDelete.Location = new System.Drawing.Point(138, 285);
            this.buttonObjectDelete.Name = "buttonObjectDelete";
            this.buttonObjectDelete.Size = new System.Drawing.Size(99, 23);
            this.buttonObjectDelete.TabIndex = 10;
            this.buttonObjectDelete.Text = "Удалить";
            this.buttonObjectDelete.UseVisualStyleBackColor = true;
            this.buttonObjectDelete.Click += new System.EventHandler(this.buttonObjectDelete_Click);
            // 
            // numericUpDownAccessPick
            // 
            this.numericUpDownAccessPick.Location = new System.Drawing.Point(13, 314);
            this.numericUpDownAccessPick.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownAccessPick.Name = "numericUpDownAccessPick";
            this.numericUpDownAccessPick.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownAccessPick.TabIndex = 11;
            // 
            // buttonAccessAdd
            // 
            this.buttonAccessAdd.Location = new System.Drawing.Point(70, 314);
            this.buttonAccessAdd.Name = "buttonAccessAdd";
            this.buttonAccessAdd.Size = new System.Drawing.Size(167, 23);
            this.buttonAccessAdd.TabIndex = 12;
            this.buttonAccessAdd.Text = "Изменить права";
            this.buttonAccessAdd.UseVisualStyleBackColor = true;
            this.buttonAccessAdd.Click += new System.EventHandler(this.buttonAccessAdd_Click);
            // 
            // dataGridViewUsersPrivilages
            // 
            this.dataGridViewUsersPrivilages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersPrivilages.Location = new System.Drawing.Point(12, 343);
            this.dataGridViewUsersPrivilages.MultiSelect = false;
            this.dataGridViewUsersPrivilages.Name = "dataGridViewUsersPrivilages";
            this.dataGridViewUsersPrivilages.ReadOnly = true;
            this.dataGridViewUsersPrivilages.RowHeadersVisible = false;
            this.dataGridViewUsersPrivilages.RowHeadersWidth = 51;
            this.dataGridViewUsersPrivilages.Size = new System.Drawing.Size(225, 59);
            this.dataGridViewUsersPrivilages.TabIndex = 13;
            this.dataGridViewUsersPrivilages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsersPrivilages_CellClick);
            // 
            // dataGridViewObjectPrivilages
            // 
            this.dataGridViewObjectPrivilages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjectPrivilages.Location = new System.Drawing.Point(12, 408);
            this.dataGridViewObjectPrivilages.MultiSelect = false;
            this.dataGridViewObjectPrivilages.Name = "dataGridViewObjectPrivilages";
            this.dataGridViewObjectPrivilages.ReadOnly = true;
            this.dataGridViewObjectPrivilages.RowHeadersVisible = false;
            this.dataGridViewObjectPrivilages.RowHeadersWidth = 51;
            this.dataGridViewObjectPrivilages.Size = new System.Drawing.Size(225, 59);
            this.dataGridViewObjectPrivilages.TabIndex = 14;
            this.dataGridViewObjectPrivilages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjectPrivilages_CellClick);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 477);
            this.Controls.Add(this.dataGridViewObjectPrivilages);
            this.Controls.Add(this.dataGridViewUsersPrivilages);
            this.Controls.Add(this.buttonAccessAdd);
            this.Controls.Add(this.numericUpDownAccessPick);
            this.Controls.Add(this.buttonObjectDelete);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.comboBoxObjectPick);
            this.Controls.Add(this.comboBoxUserPick);
            this.Controls.Add(this.dataGridViewAccesses);
            this.Controls.Add(this.buttonObjectAdd);
            this.Controls.Add(this.labelObjectName);
            this.Controls.Add(this.textBoxObjectName);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersPrivilages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectPrivilages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonObjectAdd;
        private System.Windows.Forms.Label labelObjectName;
        private System.Windows.Forms.TextBox textBoxObjectName;
        private System.Windows.Forms.DataGridView dataGridViewAccesses;
        private System.Windows.Forms.ComboBox comboBoxUserPick;
        private System.Windows.Forms.ComboBox comboBoxObjectPick;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonObjectDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownAccessPick;
        private System.Windows.Forms.Button buttonAccessAdd;
        private System.Windows.Forms.DataGridView dataGridViewUsersPrivilages;
        private System.Windows.Forms.DataGridView dataGridViewObjectPrivilages;
    }
}