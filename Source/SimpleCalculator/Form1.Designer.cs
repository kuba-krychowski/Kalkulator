namespace SimpleCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDodawanie = new System.Windows.Forms.Button();
            this.buttonOdejmowanie = new System.Windows.Forms.Button();
            this.buttonMnozenie = new System.Windows.Forms.Button();
            this.buttonDzielenie = new System.Windows.Forms.Button();
            this.buttonWynik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWynik
            // 
            this.tbWynik.CausesValidation = false;
            resources.ApplyResources(this.tbWynik, "tbWynik");
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.TextChanged += new System.EventHandler(this.tbWynik_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            resources.ApplyResources(this.button0, "button0");
            this.button0.Name = "button0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDodawanie
            // 
            resources.ApplyResources(this.buttonDodawanie, "buttonDodawanie");
            this.buttonDodawanie.Name = "buttonDodawanie";
            this.buttonDodawanie.UseVisualStyleBackColor = true;
            this.buttonDodawanie.Click += new System.EventHandler(this.buttonDodawanie_Click);
            // 
            // buttonOdejmowanie
            // 
            resources.ApplyResources(this.buttonOdejmowanie, "buttonOdejmowanie");
            this.buttonOdejmowanie.Name = "buttonOdejmowanie";
            this.buttonOdejmowanie.UseVisualStyleBackColor = true;
            this.buttonOdejmowanie.Click += new System.EventHandler(this.buttonOdejmowanie_Click);
            // 
            // buttonMnozenie
            // 
            resources.ApplyResources(this.buttonMnozenie, "buttonMnozenie");
            this.buttonMnozenie.Name = "buttonMnozenie";
            this.buttonMnozenie.UseVisualStyleBackColor = true;
            this.buttonMnozenie.Click += new System.EventHandler(this.buttonMnozenie_Click);
            // 
            // buttonDzielenie
            // 
            resources.ApplyResources(this.buttonDzielenie, "buttonDzielenie");
            this.buttonDzielenie.Name = "buttonDzielenie";
            this.buttonDzielenie.UseVisualStyleBackColor = true;
            this.buttonDzielenie.Click += new System.EventHandler(this.buttonDzielenie_Click);
            // 
            // buttonWynik
            // 
            resources.ApplyResources(this.buttonWynik, "buttonWynik");
            this.buttonWynik.Name = "buttonWynik";
            this.buttonWynik.UseVisualStyleBackColor = true;
            this.buttonWynik.Click += new System.EventHandler(this.buttonWynik_Click);
            // 
            // Kalkulator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonWynik);
            this.Controls.Add(this.buttonDzielenie);
            this.Controls.Add(this.buttonMnozenie);
            this.Controls.Add(this.buttonOdejmowanie);
            this.Controls.Add(this.buttonDodawanie);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbWynik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDodawanie;
        private System.Windows.Forms.Button buttonOdejmowanie;
        private System.Windows.Forms.Button buttonMnozenie;
        private System.Windows.Forms.Button buttonDzielenie;
        private System.Windows.Forms.Button buttonWynik;
    }
}

