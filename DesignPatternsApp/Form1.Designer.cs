namespace DesignPatternsApp
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
            singletonPattern = new RadioButton();
            selectDesignPattern = new Button();
            observerPattern = new RadioButton();
            adapterPattern = new RadioButton();
            SuspendLayout();
            // 
            // singletonPattern
            // 
            singletonPattern.AutoSize = true;
            singletonPattern.Location = new Point(49, 63);
            singletonPattern.Name = "singletonPattern";
            singletonPattern.Size = new Size(143, 24);
            singletonPattern.TabIndex = 0;
            singletonPattern.Text = "Singleton Pattern";
            singletonPattern.UseVisualStyleBackColor = true;
            // 
            // selectDesignPattern
            // 
            selectDesignPattern.Location = new Point(49, 25);
            selectDesignPattern.Name = "selectDesignPattern";
            selectDesignPattern.Size = new Size(175, 29);
            selectDesignPattern.TabIndex = 1;
            selectDesignPattern.Text = "Design Pattern Seç";
            selectDesignPattern.UseVisualStyleBackColor = true;
            selectDesignPattern.Click += selectDesignPattern_Click;
            // 
            // observerPattern
            // 
            observerPattern.AutoSize = true;
            observerPattern.Location = new Point(49, 93);
            observerPattern.Name = "observerPattern";
            observerPattern.Size = new Size(139, 24);
            observerPattern.TabIndex = 2;
            observerPattern.Text = "Observer Pattern";
            observerPattern.UseVisualStyleBackColor = true;
            // 
            // adapterPattern
            // 
            adapterPattern.AutoSize = true;
            adapterPattern.Location = new Point(49, 123);
            adapterPattern.Name = "adapterPattern";
            adapterPattern.Size = new Size(134, 24);
            adapterPattern.TabIndex = 3;
            adapterPattern.Text = "Adapter Pattern";
            adapterPattern.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adapterPattern);
            Controls.Add(observerPattern);
            Controls.Add(selectDesignPattern);
            Controls.Add(singletonPattern);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton singletonPattern;
        private Button selectDesignPattern;
        private RadioButton observerPattern;
        private RadioButton adapterPattern;
    }
}