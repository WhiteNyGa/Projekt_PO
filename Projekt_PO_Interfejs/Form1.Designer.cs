
namespace Projekt_PO_Interfejs
{
    partial class Form1
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
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.buttonDane = new System.Windows.Forms.Button();
            this.labelPola = new System.Windows.Forms.Label();
            this.comboGodzina = new System.Windows.Forms.ComboBox();
            this.comboDzien = new System.Windows.Forms.ComboBox();
            this.comboMiesiac = new System.Windows.Forms.ComboBox();
            this.comboRok = new System.Windows.Forms.ComboBox();
            this.labelDane = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStoly = new System.Windows.Forms.Label();
            this.labelGodziny = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboStol = new System.Windows.Forms.ComboBox();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(127, 45);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(100, 22);
            this.textImie.TabIndex = 0;
            this.textImie.Text = "Imię";
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(233, 45);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(100, 22);
            this.textNazwisko.TabIndex = 1;
            this.textNazwisko.Text = "Nazwisko";
            // 
            // buttonDane
            // 
            this.buttonDane.Location = new System.Drawing.Point(15, 127);
            this.buttonDane.Name = "buttonDane";
            this.buttonDane.Size = new System.Drawing.Size(100, 25);
            this.buttonDane.TabIndex = 2;
            this.buttonDane.Text = "Dalej";
            this.buttonDane.UseVisualStyleBackColor = true;
            // 
            // labelPola
            // 
            this.labelPola.AutoSize = true;
            this.labelPola.Location = new System.Drawing.Point(121, 9);
            this.labelPola.Name = "labelPola";
            this.labelPola.Size = new System.Drawing.Size(96, 17);
            this.labelPola.TabIndex = 3;
            this.labelPola.Text = "Wypełnij pola:";
            // 
            // comboGodzina
            // 
            this.comboGodzina.FormattingEnabled = true;
            this.comboGodzina.Location = new System.Drawing.Point(355, 86);
            this.comboGodzina.Name = "comboGodzina";
            this.comboGodzina.Size = new System.Drawing.Size(80, 24);
            this.comboGodzina.TabIndex = 4;
            this.comboGodzina.Text = "Godzina";
            // 
            // comboDzien
            // 
            this.comboDzien.FormattingEnabled = true;
            this.comboDzien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboDzien.Location = new System.Drawing.Point(127, 86);
            this.comboDzien.Name = "comboDzien";
            this.comboDzien.Size = new System.Drawing.Size(65, 24);
            this.comboDzien.TabIndex = 5;
            this.comboDzien.Text = "Dzień";
            // 
            // comboMiesiac
            // 
            this.comboMiesiac.FormattingEnabled = true;
            this.comboMiesiac.Location = new System.Drawing.Point(198, 86);
            this.comboMiesiac.Name = "comboMiesiac";
            this.comboMiesiac.Size = new System.Drawing.Size(75, 24);
            this.comboMiesiac.TabIndex = 6;
            this.comboMiesiac.Text = "Miesiąc";
            // 
            // comboRok
            // 
            this.comboRok.FormattingEnabled = true;
            this.comboRok.Location = new System.Drawing.Point(279, 86);
            this.comboRok.Name = "comboRok";
            this.comboRok.Size = new System.Drawing.Size(70, 24);
            this.comboRok.TabIndex = 7;
            this.comboRok.Text = "Rok";
            // 
            // labelDane
            // 
            this.labelDane.AutoSize = true;
            this.labelDane.Location = new System.Drawing.Point(12, 48);
            this.labelDane.Name = "labelDane";
            this.labelDane.Size = new System.Drawing.Size(106, 17);
            this.labelDane.TabIndex = 8;
            this.labelDane.Text = "Dane osobowe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data rezerwacji:";
            // 
            // labelStoly
            // 
            this.labelStoly.AutoSize = true;
            this.labelStoly.Location = new System.Drawing.Point(33, 176);
            this.labelStoly.Name = "labelStoly";
            this.labelStoly.Size = new System.Drawing.Size(85, 17);
            this.labelStoly.TabIndex = 10;
            this.labelStoly.Text = "Wolne stoły:";
            // 
            // labelGodziny
            // 
            this.labelGodziny.AutoSize = true;
            this.labelGodziny.Location = new System.Drawing.Point(5, 214);
            this.labelGodziny.Name = "labelGodziny";
            this.labelGodziny.Size = new System.Drawing.Size(116, 17);
            this.labelGodziny.TabIndex = 11;
            this.labelGodziny.Text = "Wybierz godziny:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(127, 214);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 12;
            // 
            // comboStol
            // 
            this.comboStol.FormattingEnabled = true;
            this.comboStol.Location = new System.Drawing.Point(127, 176);
            this.comboStol.Name = "comboStol";
            this.comboStol.Size = new System.Drawing.Size(121, 24);
            this.comboStol.TabIndex = 13;
            this.comboStol.Text = "Wybierz stół";
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(355, 275);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(111, 28);
            this.buttonZatwierdz.TabIndex = 14;
            this.buttonZatwierdz.Text = "Zatwierdz";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 344);
            this.Controls.Add(this.buttonZatwierdz);
            this.Controls.Add(this.comboStol);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelGodziny);
            this.Controls.Add(this.labelStoly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDane);
            this.Controls.Add(this.comboRok);
            this.Controls.Add(this.comboMiesiac);
            this.Controls.Add(this.comboDzien);
            this.Controls.Add(this.comboGodzina);
            this.Controls.Add(this.labelPola);
            this.Controls.Add(this.buttonDane);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.Button buttonDane;
        private System.Windows.Forms.Label labelPola;
        private System.Windows.Forms.ComboBox comboGodzina;
        private System.Windows.Forms.ComboBox comboDzien;
        private System.Windows.Forms.ComboBox comboMiesiac;
        private System.Windows.Forms.ComboBox comboRok;
        private System.Windows.Forms.Label labelDane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStoly;
        private System.Windows.Forms.Label labelGodziny;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboStol;
        private System.Windows.Forms.Button buttonZatwierdz;
    }
}

