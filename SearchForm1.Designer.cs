
namespace Информационная_система_Фитнес_клуба_Fitness_house
{
    partial class SearchForm1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Информационная_система_Фитнес_клуба_Fitness_house.Properties.Resources._2131212;
            this.groupBox1.Controls.Add(this.tbStr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(6, 67);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(348, 22);
            this.tbStr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите информацию для поиска";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.BackgroundImage = global::Информационная_система_Фитнес_клуба_Fitness_house.Properties.Resources._72cc936e88570a3b3265cb1b91e7765a;
            this.search.Location = new System.Drawing.Point(92, 133);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(103, 30);
            this.search.TabIndex = 1;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::Информационная_система_Фитнес_клуба_Fitness_house.Properties.Resources._72cc936e88570a3b3265cb1b91e7765a;
            this.close.Location = new System.Drawing.Point(201, 133);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(103, 30);
            this.close.TabIndex = 2;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SearchForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Информационная_система_Фитнес_клуба_Fitness_house.Properties.Resources._2131212;
            this.ClientSize = new System.Drawing.Size(396, 178);
            this.Controls.Add(this.close);
            this.Controls.Add(this.search);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button close;
    }
}