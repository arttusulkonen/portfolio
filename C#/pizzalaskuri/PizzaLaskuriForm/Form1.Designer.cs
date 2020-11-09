namespace PizzaLaskuriForm
{
    partial class PizzaLaskuri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaLaskuri));
            this.tekstiLasten = new System.Windows.Forms.Label();
            this.lastenBox = new System.Windows.Forms.TextBox();
            this.normaaliBox = new System.Windows.Forms.TextBox();
            this.tekstiNormaali = new System.Windows.Forms.Label();
            this.perheBox = new System.Windows.Forms.TextBox();
            this.perheTeksti = new System.Windows.Forms.Label();
            this.resultLastenPizza = new System.Windows.Forms.Button();
            this.kokoReseptiButton = new System.Windows.Forms.Button();
            this.ResultNormPizza = new System.Windows.Forms.Button();
            this.ResultPerhePizza = new System.Windows.Forms.Button();
            this.resultJauhoTeksti = new System.Windows.Forms.Label();
            this.resultVesiTeksti = new System.Windows.Forms.Label();
            this.resultSuolaTeksti = new System.Windows.Forms.Label();
            this.resultHiivaTeksti = new System.Windows.Forms.Label();
            this.resultJauhoaBox = new System.Windows.Forms.TextBox();
            this.resultVesiBox = new System.Windows.Forms.TextBox();
            this.resultSuolaBox = new System.Windows.Forms.TextBox();
            this.resultHiivaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tekstiLasten
            // 
            this.tekstiLasten.AutoSize = true;
            this.tekstiLasten.Location = new System.Drawing.Point(30, 35);
            this.tekstiLasten.Name = "tekstiLasten";
            this.tekstiLasten.Size = new System.Drawing.Size(254, 16);
            this.tekstiLasten.TabIndex = 0;
            this.tekstiLasten.Text = "Kuinka paljon aiot valmistaa lasten pizza?";
            // 
            // lastenBox
            // 
            this.lastenBox.Location = new System.Drawing.Point(33, 66);
            this.lastenBox.Name = "lastenBox";
            this.lastenBox.Size = new System.Drawing.Size(100, 22);
            this.lastenBox.TabIndex = 1;
            this.lastenBox.TextChanged += new System.EventHandler(this.lastenBox_TextChanged);
            // 
            // normaaliBox
            // 
            this.normaaliBox.Location = new System.Drawing.Point(33, 153);
            this.normaaliBox.Name = "normaaliBox";
            this.normaaliBox.Size = new System.Drawing.Size(100, 22);
            this.normaaliBox.TabIndex = 3;
            this.normaaliBox.TextChanged += new System.EventHandler(this.normaaliBox_TextChanged);
            // 
            // tekstiNormaali
            // 
            this.tekstiNormaali.AutoSize = true;
            this.tekstiNormaali.Location = new System.Drawing.Point(30, 122);
            this.tekstiNormaali.Name = "tekstiNormaali";
            this.tekstiNormaali.Size = new System.Drawing.Size(270, 16);
            this.tekstiNormaali.TabIndex = 2;
            this.tekstiNormaali.Text = "Kuinka paljon aiot valmistaa normaali pizza?";
            // 
            // perheBox
            // 
            this.perheBox.Location = new System.Drawing.Point(33, 244);
            this.perheBox.Name = "perheBox";
            this.perheBox.Size = new System.Drawing.Size(100, 22);
            this.perheBox.TabIndex = 5;
            this.perheBox.TextChanged += new System.EventHandler(this.perheBox_TextChanged);
            // 
            // perheTeksti
            // 
            this.perheTeksti.AutoSize = true;
            this.perheTeksti.Location = new System.Drawing.Point(30, 213);
            this.perheTeksti.Name = "perheTeksti";
            this.perheTeksti.Size = new System.Drawing.Size(253, 16);
            this.perheTeksti.TabIndex = 4;
            this.perheTeksti.Text = "Kuinka paljon aiot valmistaa perhe pizza?";
            // 
            // resultLastenPizza
            // 
            this.resultLastenPizza.Location = new System.Drawing.Point(33, 301);
            this.resultLastenPizza.Name = "resultLastenPizza";
            this.resultLastenPizza.Size = new System.Drawing.Size(154, 23);
            this.resultLastenPizza.TabIndex = 6;
            this.resultLastenPizza.Text = "Result Lasten Pizza";
            this.resultLastenPizza.UseVisualStyleBackColor = true;
            this.resultLastenPizza.Click += new System.EventHandler(this.resultLastenPizza_Click);
            // 
            // kokoReseptiButton
            // 
            this.kokoReseptiButton.Location = new System.Drawing.Point(299, 301);
            this.kokoReseptiButton.Name = "kokoReseptiButton";
            this.kokoReseptiButton.Size = new System.Drawing.Size(135, 23);
            this.kokoReseptiButton.TabIndex = 7;
            this.kokoReseptiButton.Text = "Koko Resepti";
            this.kokoReseptiButton.UseVisualStyleBackColor = true;
            this.kokoReseptiButton.Click += new System.EventHandler(this.kokoReseptiButton_Click);
            // 
            // ResultNormPizza
            // 
            this.ResultNormPizza.Location = new System.Drawing.Point(33, 330);
            this.ResultNormPizza.Name = "ResultNormPizza";
            this.ResultNormPizza.Size = new System.Drawing.Size(154, 23);
            this.ResultNormPizza.TabIndex = 8;
            this.ResultNormPizza.Text = "Result Normaali Pizza";
            this.ResultNormPizza.UseVisualStyleBackColor = true;
            this.ResultNormPizza.Click += new System.EventHandler(this.ResultNormPizza_Click);
            // 
            // ResultPerhePizza
            // 
            this.ResultPerhePizza.Location = new System.Drawing.Point(33, 359);
            this.ResultPerhePizza.Name = "ResultPerhePizza";
            this.ResultPerhePizza.Size = new System.Drawing.Size(154, 23);
            this.ResultPerhePizza.TabIndex = 9;
            this.ResultPerhePizza.Text = "Result Perhe Pizza";
            this.ResultPerhePizza.UseVisualStyleBackColor = true;
            this.ResultPerhePizza.Click += new System.EventHandler(this.ResultPerhePizza_Click);
            // 
            // resultJauhoTeksti
            // 
            this.resultJauhoTeksti.AutoSize = true;
            this.resultJauhoTeksti.Location = new System.Drawing.Point(30, 408);
            this.resultJauhoTeksti.Name = "resultJauhoTeksti";
            this.resultJauhoTeksti.Size = new System.Drawing.Size(53, 16);
            this.resultJauhoTeksti.TabIndex = 10;
            this.resultJauhoTeksti.Text = "Jauhoa";
            // 
            // resultVesiTeksti
            // 
            this.resultVesiTeksti.AutoSize = true;
            this.resultVesiTeksti.Location = new System.Drawing.Point(30, 436);
            this.resultVesiTeksti.Name = "resultVesiTeksti";
            this.resultVesiTeksti.Size = new System.Drawing.Size(39, 16);
            this.resultVesiTeksti.TabIndex = 11;
            this.resultVesiTeksti.Text = "Vettä";
            // 
            // resultSuolaTeksti
            // 
            this.resultSuolaTeksti.AutoSize = true;
            this.resultSuolaTeksti.Location = new System.Drawing.Point(30, 467);
            this.resultSuolaTeksti.Name = "resultSuolaTeksti";
            this.resultSuolaTeksti.Size = new System.Drawing.Size(43, 16);
            this.resultSuolaTeksti.TabIndex = 12;
            this.resultSuolaTeksti.Text = "Suola";
            // 
            // resultHiivaTeksti
            // 
            this.resultHiivaTeksti.AutoSize = true;
            this.resultHiivaTeksti.Location = new System.Drawing.Point(30, 494);
            this.resultHiivaTeksti.Name = "resultHiivaTeksti";
            this.resultHiivaTeksti.Size = new System.Drawing.Size(39, 16);
            this.resultHiivaTeksti.TabIndex = 13;
            this.resultHiivaTeksti.Text = "Hiiva";
            // 
            // resultJauhoaBox
            // 
            this.resultJauhoaBox.Location = new System.Drawing.Point(91, 408);
            this.resultJauhoaBox.Name = "resultJauhoaBox";
            this.resultJauhoaBox.Size = new System.Drawing.Size(94, 22);
            this.resultJauhoaBox.TabIndex = 14;
            // 
            // resultVesiBox
            // 
            this.resultVesiBox.Location = new System.Drawing.Point(91, 436);
            this.resultVesiBox.Name = "resultVesiBox";
            this.resultVesiBox.Size = new System.Drawing.Size(94, 22);
            this.resultVesiBox.TabIndex = 15;
            // 
            // resultSuolaBox
            // 
            this.resultSuolaBox.Location = new System.Drawing.Point(91, 461);
            this.resultSuolaBox.Name = "resultSuolaBox";
            this.resultSuolaBox.Size = new System.Drawing.Size(96, 22);
            this.resultSuolaBox.TabIndex = 16;
            // 
            // resultHiivaBox
            // 
            this.resultHiivaBox.Location = new System.Drawing.Point(91, 489);
            this.resultHiivaBox.Name = "resultHiivaBox";
            this.resultHiivaBox.Size = new System.Drawing.Size(96, 22);
            this.resultHiivaBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "kg";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "litra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "gramma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "gramma";
            // 
            // PizzaLaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultHiivaBox);
            this.Controls.Add(this.resultSuolaBox);
            this.Controls.Add(this.resultVesiBox);
            this.Controls.Add(this.resultJauhoaBox);
            this.Controls.Add(this.resultHiivaTeksti);
            this.Controls.Add(this.resultSuolaTeksti);
            this.Controls.Add(this.resultVesiTeksti);
            this.Controls.Add(this.resultJauhoTeksti);
            this.Controls.Add(this.ResultPerhePizza);
            this.Controls.Add(this.ResultNormPizza);
            this.Controls.Add(this.kokoReseptiButton);
            this.Controls.Add(this.resultLastenPizza);
            this.Controls.Add(this.perheBox);
            this.Controls.Add(this.perheTeksti);
            this.Controls.Add(this.normaaliBox);
            this.Controls.Add(this.tekstiNormaali);
            this.Controls.Add(this.lastenBox);
            this.Controls.Add(this.tekstiLasten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PizzaLaskuri";
            this.Text = "PizzaLaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tekstiLasten;
        private System.Windows.Forms.TextBox lastenBox;
        private System.Windows.Forms.TextBox normaaliBox;
        private System.Windows.Forms.Label tekstiNormaali;
        private System.Windows.Forms.TextBox perheBox;
        private System.Windows.Forms.Label perheTeksti;
        private System.Windows.Forms.Button resultLastenPizza;
        private System.Windows.Forms.Button kokoReseptiButton;
        private System.Windows.Forms.Button ResultNormPizza;
        private System.Windows.Forms.Button ResultPerhePizza;
        private System.Windows.Forms.Label resultJauhoTeksti;
        private System.Windows.Forms.Label resultVesiTeksti;
        private System.Windows.Forms.Label resultSuolaTeksti;
        private System.Windows.Forms.Label resultHiivaTeksti;
        private System.Windows.Forms.TextBox resultJauhoaBox;
        private System.Windows.Forms.TextBox resultVesiBox;
        private System.Windows.Forms.TextBox resultSuolaBox;
        private System.Windows.Forms.TextBox resultHiivaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

