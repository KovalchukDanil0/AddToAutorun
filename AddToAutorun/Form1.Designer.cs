
namespace AddToAutorun
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
            this.label1 = new System.Windows.Forms.Label();
            this.toRunTextBox = new System.Windows.Forms.TextBox();
            this.fileDialogATRButton = new System.Windows.Forms.Button();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.deleteKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application to run(exe):";
            // 
            // toRunTextBox
            // 
            this.toRunTextBox.Location = new System.Drawing.Point(133, 21);
            this.toRunTextBox.Name = "toRunTextBox";
            this.toRunTextBox.Size = new System.Drawing.Size(279, 20);
            this.toRunTextBox.TabIndex = 1;
            this.toRunTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toRunTextBox_KeyPress);
            // 
            // fileDialogATRButton
            // 
            this.fileDialogATRButton.Location = new System.Drawing.Point(418, 19);
            this.fileDialogATRButton.Name = "fileDialogATRButton";
            this.fileDialogATRButton.Size = new System.Drawing.Size(28, 23);
            this.fileDialogATRButton.TabIndex = 2;
            this.fileDialogATRButton.Text = "...";
            this.fileDialogATRButton.UseVisualStyleBackColor = true;
            this.fileDialogATRButton.Click += new System.EventHandler(this.fileDialogATRButton_Click);
            // 
            // addKeyButton
            // 
            this.addKeyButton.Location = new System.Drawing.Point(15, 52);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(56, 23);
            this.addKeyButton.TabIndex = 7;
            this.addKeyButton.Text = "Add";
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // deleteKeyButton
            // 
            this.deleteKeyButton.Location = new System.Drawing.Point(86, 52);
            this.deleteKeyButton.Name = "deleteKeyButton";
            this.deleteKeyButton.Size = new System.Drawing.Size(60, 23);
            this.deleteKeyButton.TabIndex = 8;
            this.deleteKeyButton.Text = "Delete";
            this.deleteKeyButton.UseVisualStyleBackColor = true;
            this.deleteKeyButton.Click += new System.EventHandler(this.deleteKeyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 87);
            this.Controls.Add(this.deleteKeyButton);
            this.Controls.Add(this.addKeyButton);
            this.Controls.Add(this.fileDialogATRButton);
            this.Controls.Add(this.toRunTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AddToAutorun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toRunTextBox;
        private System.Windows.Forms.Button fileDialogATRButton;
        private System.Windows.Forms.Button addKeyButton;
        private System.Windows.Forms.Button deleteKeyButton;
    }
}

