namespace _13DialogResult
{
    partial class Form1
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
            this.msgBoxOpen = new System.Windows.Forms.Button();
            this.multiLineTextMsgBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgBoxOpen
            // 
            this.msgBoxOpen.Location = new System.Drawing.Point(63, 46);
            this.msgBoxOpen.Name = "msgBoxOpen";
            this.msgBoxOpen.Size = new System.Drawing.Size(201, 23);
            this.msgBoxOpen.TabIndex = 1;
            this.msgBoxOpen.Text = "Otvorite MessageBox";
            this.msgBoxOpen.UseVisualStyleBackColor = true;
            this.msgBoxOpen.Click += new System.EventHandler(this.msgBoxOpen_Click);
            // 
            // multiLineTextMsgBox
            // 
            this.multiLineTextMsgBox.Location = new System.Drawing.Point(44, 95);
            this.multiLineTextMsgBox.Multiline = true;
            this.multiLineTextMsgBox.Name = "multiLineTextMsgBox";
            this.multiLineTextMsgBox.Size = new System.Drawing.Size(230, 89);
            this.multiLineTextMsgBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 234);
            this.Controls.Add(this.multiLineTextMsgBox);
            this.Controls.Add(this.msgBoxOpen);
            this.Name = "Form1";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button msgBoxOpen;
        private System.Windows.Forms.TextBox multiLineTextMsgBox;
    }
}

