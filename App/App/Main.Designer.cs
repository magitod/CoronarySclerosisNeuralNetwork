namespace App
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
            this.tab_neural_network = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_train_selection = new System.Windows.Forms.DataGridView();
            this.tab_neural_network.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_train_selection)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_neural_network
            // 
            this.tab_neural_network.Controls.Add(this.tabPage1);
            this.tab_neural_network.Controls.Add(this.tabPage2);
            this.tab_neural_network.Controls.Add(this.tabPage3);
            this.tab_neural_network.Location = new System.Drawing.Point(12, 12);
            this.tab_neural_network.Name = "tab_neural_network";
            this.tab_neural_network.SelectedIndex = 0;
            this.tab_neural_network.Size = new System.Drawing.Size(780, 495);
            this.tab_neural_network.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_train_selection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обучающая выборка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Структура НС";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(772, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Обучение НС";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_train_selection
            // 
            this.dgv_train_selection.AllowUserToAddRows = false;
            this.dgv_train_selection.AllowUserToDeleteRows = false;
            this.dgv_train_selection.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_train_selection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_train_selection.Location = new System.Drawing.Point(6, 6);
            this.dgv_train_selection.Name = "dgv_train_selection";
            this.dgv_train_selection.RowHeadersVisible = false;
            this.dgv_train_selection.Size = new System.Drawing.Size(760, 457);
            this.dgv_train_selection.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 514);
            this.Controls.Add(this.tab_neural_network);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tab_neural_network.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_train_selection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_neural_network;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_train_selection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

