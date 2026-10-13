namespace lab1_konstrPO
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.buttonSaveGroups = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.bindingNavigatorStudents = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSourceStudents = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSaveStudents = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPageReport1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxReportStudents1 = new System.Windows.Forms.ComboBox();
            this.buttonExecuteRawSql = new System.Windows.Forms.Button();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.tabPageReport2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxReportStudents2 = new System.Windows.Forms.ComboBox();
            this.buttonExecuteProcedure = new System.Windows.Forms.Button();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();

            this.tabControlMain.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageReport1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.tabPageReport2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGroups);
            this.tabControlMain.Controls.Add(this.tabPageStudents);
            this.tabControlMain.Controls.Add(this.tabPageReport1);
            this.tabControlMain.Controls.Add(this.tabPageReport2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;

            // 
            // tabPageGroups (Вкладка 1: Группы)
            // 
            this.tabPageGroups.Controls.Add(this.buttonSaveGroups);
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(792, 424);
            this.tabPageGroups.TabIndex = 0;
            this.tabPageGroups.Text = "Группы";
            this.tabPageGroups.UseVisualStyleBackColor = true;

            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(776, 370);
            this.dataGridViewGroups.TabIndex = 0;

            // 
            // buttonSaveGroups
            // 
            this.buttonSaveGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveGroups.Location = new System.Drawing.Point(620, 385);
            this.buttonSaveGroups.Name = "buttonSaveGroups";
            this.buttonSaveGroups.Size = new System.Drawing.Size(164, 31);
            this.buttonSaveGroups.TabIndex = 1;
            this.buttonSaveGroups.Text = "Сохранить группы";
            this.buttonSaveGroups.UseVisualStyleBackColor = true;
            this.buttonSaveGroups.Click += new System.EventHandler(this.buttonSaveGroups_Click);

            // 
            // tabPageStudents (Вкладка 2: Студенты)
            // 
            this.tabPageStudents.Controls.Add(this.bindingNavigatorStudents);
            this.tabPageStudents.Controls.Add(this.buttonSaveStudents);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(792, 424);
            this.tabPageStudents.TabIndex = 1;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;

            // 
            // bindingNavigatorStudents
            // 
            this.bindingNavigatorStudents.AddNewItem = null;
            this.bindingNavigatorStudents.CountItem = null;
            this.bindingNavigatorStudents.DeleteItem = null;
            this.bindingNavigatorStudents.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorStudents.MoveFirstItem = null;
            this.bindingNavigatorStudents.MoveLastItem = null;
            this.bindingNavigatorStudents.MoveNextItem = null;
            this.bindingNavigatorStudents.MovePreviousItem = null;
            this.bindingNavigatorStudents.Name = "bindingNavigatorStudents";
            this.bindingNavigatorStudents.PositionItem = null;
            this.bindingNavigatorStudents.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigatorStudents.TabIndex = 2;

            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(8, 31);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 345);
            this.dataGridViewStudents.TabIndex = 0;

            // 
            // buttonSaveStudents
            // 
            this.buttonSaveStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveStudents.Location = new System.Drawing.Point(620, 385);
            this.buttonSaveStudents.Name = "buttonSaveStudents";
            this.buttonSaveStudents.Size = new System.Drawing.Size(164, 31);
            this.buttonSaveStudents.TabIndex = 1;
            this.buttonSaveStudents.Text = "Сохранить студентов";
            this.buttonSaveStudents.UseVisualStyleBackColor = true;
            this.buttonSaveStudents.Click += new System.EventHandler(this.buttonSaveStudents_Click);

            // 
            // tabPageReport1 (Вкладка 3: Успеваемость SQL)
            // 
            this.tabPageReport1.Controls.Add(this.label1);
            this.tabPageReport1.Controls.Add(this.comboBoxReportStudents1);
            this.tabPageReport1.Controls.Add(this.buttonExecuteRawSql);
            this.tabPageReport1.Controls.Add(this.dataGridViewReport1);
            this.tabPageReport1.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport1.Name = "tabPageReport1";
            this.tabPageReport1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport1.Size = new System.Drawing.Size(792, 424);
            this.tabPageReport1.TabIndex = 2;
            this.tabPageReport1.Text = "Успеваемость (SQL)";
            this.tabPageReport1.UseVisualStyleBackColor = true;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите студента:";

            // 
            // comboBoxReportStudents1
            // 
            this.comboBoxReportStudents1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportStudents1.FormattingEnabled = true;
            this.comboBoxReportStudents1.Location = new System.Drawing.Point(124, 12);
            this.comboBoxReportStudents1.Name = "comboBoxReportStudents1";
            this.comboBoxReportStudents1.Size = new System.Drawing.Size(220, 21);
            this.comboBoxReportStudents1.TabIndex = 2;

            // 
            // buttonExecuteRawSql
            // 
            this.buttonExecuteRawSql.Location = new System.Drawing.Point(350, 10);
            this.buttonExecuteRawSql.Name = "buttonExecuteRawSql";
            this.buttonExecuteRawSql.Size = new System.Drawing.Size(130, 23);
            this.buttonExecuteRawSql.TabIndex = 1;
            this.buttonExecuteRawSql.Text = "Сформировать";
            this.buttonExecuteRawSql.UseVisualStyleBackColor = true;
            this.buttonExecuteRawSql.Click += new System.EventHandler(this.buttonExecuteRawSql_Click);

            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Location = new System.Drawing.Point(8, 42);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.Size = new System.Drawing.Size(776, 374);
            this.dataGridViewReport1.TabIndex = 0;

            // 
            // tabPageReport2 (Вкладка 4: Средний балл Функция)
            // 
            this.tabPageReport2.Controls.Add(this.label2);
            this.tabPageReport2.Controls.Add(this.comboBoxReportStudents2);
            this.tabPageReport2.Controls.Add(this.buttonExecuteProcedure);
            this.tabPageReport2.Controls.Add(this.dataGridViewReport2);
            this.tabPageReport2.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport2.Name = "tabPageReport2";
            this.tabPageReport2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport2.Size = new System.Drawing.Size(792, 424);
            this.tabPageReport2.TabIndex = 3;
            this.tabPageReport2.Text = "Средний балл (Функция)";
            this.tabPageReport2.UseVisualStyleBackColor = true;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите студента:";

            // 
            // comboBoxReportStudents2
            // 
            this.comboBoxReportStudents2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportStudents2.FormattingEnabled = true;
            this.comboBoxReportStudents2.Location = new System.Drawing.Point(124, 12);
            this.comboBoxReportStudents2.Name = "comboBoxReportStudents2";
            this.comboBoxReportStudents2.Size = new System.Drawing.Size(220, 21);
            this.comboBoxReportStudents2.TabIndex = 2;

            // 
            // buttonExecuteProcedure
            // 
            this.buttonExecuteProcedure.Location = new System.Drawing.Point(350, 10);
            this.buttonExecuteProcedure.Name = "buttonExecuteProcedure";
            this.buttonExecuteProcedure.Size = new System.Drawing.Size(130, 23);
            this.buttonExecuteProcedure.TabIndex = 1;
            this.buttonExecuteProcedure.Text = "Вызвать функцию";
            this.buttonExecuteProcedure.UseVisualStyleBackColor = true;
            this.buttonExecuteProcedure.Click += new System.EventHandler(this.buttonExecuteProcedure_Click);

            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(8, 42);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.Size = new System.Drawing.Size(776, 374);
            this.dataGridViewReport2.TabIndex = 0;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Учет успеваемости студентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageReport1.ResumeLayout(false);
            this.tabPageReport1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.tabPageReport2.ResumeLayout(false);
            this.tabPageReport2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Button buttonSaveGroups;

        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonSaveStudents;
        private System.Windows.Forms.BindingSource bindingSourceStudents;
        private System.Windows.Forms.BindingNavigator bindingNavigatorStudents;

        private System.Windows.Forms.TabPage tabPageReport1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxReportStudents1;
        private System.Windows.Forms.Button buttonExecuteRawSql;
        private System.Windows.Forms.DataGridView dataGridViewReport1;

        private System.Windows.Forms.TabPage tabPageReport2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReportStudents2;
        private System.Windows.Forms.Button buttonExecuteProcedure;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
    }
}