
namespace ReplaceNewSpot {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.mainFileTxt = new System.Windows.Forms.TextBox();
            this.JoinFileTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textOut = new System.Windows.Forms.TextBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "JoinXML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainFileTxt
            // 
            this.mainFileTxt.Location = new System.Drawing.Point(68, 45);
            this.mainFileTxt.Name = "mainFileTxt";
            this.mainFileTxt.Size = new System.Drawing.Size(219, 20);
            this.mainFileTxt.TabIndex = 1;
            // 
            // JoinFileTxt
            // 
            this.JoinFileTxt.Location = new System.Drawing.Point(68, 108);
            this.JoinFileTxt.Name = "JoinFileTxt";
            this.JoinFileTxt.Size = new System.Drawing.Size(219, 20);
            this.JoinFileTxt.TabIndex = 2;
            this.JoinFileTxt.Text = "/new/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main file .xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Join file .xml";
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(68, 206);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.ReadOnly = true;
            this.textOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOut.Size = new System.Drawing.Size(219, 66);
            this.textOut.TabIndex = 5;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copyright.Location = new System.Drawing.Point(148, 310);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(194, 16);
            this.Copyright.TabIndex = 6;
            this.Copyright.Text = "Copyright © [2023] [ Codesteyr ]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 335);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JoinFileTxt);
            this.Controls.Add(this.mainFileTxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "UniteSpot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mainFileTxt;
        private System.Windows.Forms.TextBox JoinFileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Label Copyright;
    }
}

