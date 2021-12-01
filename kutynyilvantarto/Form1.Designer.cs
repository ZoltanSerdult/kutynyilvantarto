
namespace kutynyilvantarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_fajta = new System.Windows.Forms.TextBox();
            this.textBox_sulya = new System.Windows.Forms.TextBox();
            this.textBox_szuletett = new System.Windows.Forms.TextBox();
            this.ListBox_mutat = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_felvetel = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kutya neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kutya fajtája";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kutya súlya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kutya születése";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(138, 68);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev.TabIndex = 4;
            // 
            // textBox_fajta
            // 
            this.textBox_fajta.Location = new System.Drawing.Point(138, 104);
            this.textBox_fajta.Name = "textBox_fajta";
            this.textBox_fajta.Size = new System.Drawing.Size(100, 20);
            this.textBox_fajta.TabIndex = 5;
            // 
            // textBox_sulya
            // 
            this.textBox_sulya.Location = new System.Drawing.Point(138, 140);
            this.textBox_sulya.Name = "textBox_sulya";
            this.textBox_sulya.Size = new System.Drawing.Size(100, 20);
            this.textBox_sulya.TabIndex = 6;
            // 
            // textBox_szuletett
            // 
            this.textBox_szuletett.Location = new System.Drawing.Point(138, 173);
            this.textBox_szuletett.Name = "textBox_szuletett";
            this.textBox_szuletett.Size = new System.Drawing.Size(100, 20);
            this.textBox_szuletett.TabIndex = 7;
            // 
            // ListBox_mutat
            // 
            this.ListBox_mutat.FormattingEnabled = true;
            this.ListBox_mutat.Location = new System.Drawing.Point(266, 68);
            this.ListBox_mutat.Name = "ListBox_mutat";
            this.ListBox_mutat.Size = new System.Drawing.Size(268, 355);
            this.ListBox_mutat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(143, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kutya nyilvántartó";
            // 
            // button_felvetel
            // 
            this.button_felvetel.Location = new System.Drawing.Point(35, 211);
            this.button_felvetel.Name = "button_felvetel";
            this.button_felvetel.Size = new System.Drawing.Size(203, 35);
            this.button_felvetel.TabIndex = 10;
            this.button_felvetel.Text = "Új kutya felvétel";
            this.button_felvetel.UseVisualStyleBackColor = true;
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(35, 265);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(203, 32);
            this.button_modosit.TabIndex = 11;
            this.button_modosit.Text = "Kutya adatainak módositása";
            this.button_modosit.UseVisualStyleBackColor = true;
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(35, 316);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(203, 32);
            this.button_torles.TabIndex = 12;
            this.button_torles.Text = "Kutya törlése";
            this.button_torles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(576, 461);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.button_felvetel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBox_mutat);
            this.Controls.Add(this.textBox_szuletett);
            this.Controls.Add(this.textBox_sulya);
            this.Controls.Add(this.textBox_fajta);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kuya nyilvántartó";
            this.Load += new System.EventHandler(this.Form_mutat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_fajta;
        private System.Windows.Forms.TextBox textBox_sulya;
        private System.Windows.Forms.TextBox textBox_szuletett;
        private System.Windows.Forms.ListBox ListBox_mutat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_felvetel;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_torles;
    }
}

