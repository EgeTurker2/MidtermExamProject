namespace MidtermExamProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_texteditor = new System.Windows.Forms.Button();
            this.btn_stdgrdtdlist = new System.Windows.Forms.Button();
            this.btn_background = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_texteditor
            // 
            this.btn_texteditor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_texteditor.Location = new System.Drawing.Point(12, 72);
            this.btn_texteditor.Name = "btn_texteditor";
            this.btn_texteditor.Size = new System.Drawing.Size(150, 40);
            this.btn_texteditor.TabIndex = 0;
            this.btn_texteditor.Text = "Text Editor";
            this.btn_texteditor.UseVisualStyleBackColor = true;
            this.btn_texteditor.Click += new System.EventHandler(this.btn_texteditor_Click);
            // 
            // btn_stdgrdtdlist
            // 
            this.btn_stdgrdtdlist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_stdgrdtdlist.Location = new System.Drawing.Point(168, 72);
            this.btn_stdgrdtdlist.Name = "btn_stdgrdtdlist";
            this.btn_stdgrdtdlist.Size = new System.Drawing.Size(150, 40);
            this.btn_stdgrdtdlist.TabIndex = 1;
            this.btn_stdgrdtdlist.Text = "Student Grades and To-Do List ";
            this.btn_stdgrdtdlist.UseVisualStyleBackColor = true;
            // 
            // btn_background
            // 
            this.btn_background.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_background.Location = new System.Drawing.Point(324, 72);
            this.btn_background.Name = "btn_background";
            this.btn_background.Size = new System.Drawing.Size(150, 40);
            this.btn_background.TabIndex = 2;
            this.btn_background.Text = "Background Color Controller";
            this.btn_background.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_background);
            this.Controls.Add(this.btn_stdgrdtdlist);
            this.Controls.Add(this.btn_texteditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texteditor;
        private System.Windows.Forms.Button btn_stdgrdtdlist;
        private System.Windows.Forms.Button btn_background;
        private System.Windows.Forms.Label label1;
    }
}

