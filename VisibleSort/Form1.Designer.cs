namespace VisibleSort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.generateNumsButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.index1Key = new System.Windows.Forms.NumericUpDown();
            this.index2Key = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.index1Key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.index2Key)).BeginInit();
            this.SuspendLayout();
            // 
            // nextStepButton
            // 
            this.nextStepButton.Location = new System.Drawing.Point(448, 231);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(111, 54);
            this.nextStepButton.TabIndex = 0;
            this.nextStepButton.Text = "следующий шаг";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // generateNumsButton
            // 
            this.generateNumsButton.Location = new System.Drawing.Point(281, 231);
            this.generateNumsButton.Name = "generateNumsButton";
            this.generateNumsButton.Size = new System.Drawing.Size(111, 54);
            this.generateNumsButton.TabIndex = 1;
            this.generateNumsButton.Text = "сгенерировать массив";
            this.generateNumsButton.UseVisualStyleBackColor = true;
            this.generateNumsButton.Click += new System.EventHandler(this.generateNumsButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // index1Key
            // 
            this.index1Key.Location = new System.Drawing.Point(108, 74);
            this.index1Key.Name = "index1Key";
            this.index1Key.Size = new System.Drawing.Size(120, 23);
            this.index1Key.TabIndex = 2;
            // 
            // index2Key
            // 
            this.index2Key.Location = new System.Drawing.Point(243, 74);
            this.index2Key.Name = "index2Key";
            this.index2Key.Size = new System.Drawing.Size(120, 23);
            this.index2Key.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 305);
            this.Controls.Add(this.index2Key);
            this.Controls.Add(this.index1Key);
            this.Controls.Add(this.generateNumsButton);
            this.Controls.Add(this.nextStepButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.index1Key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.index2Key)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button nextStepButton;
        private Button generateNumsButton;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown index1Key;
        private NumericUpDown index2Key;
    }
}