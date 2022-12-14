namespace Felhasznalo_keppel
{
    partial class UjAdatForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AzonText = new System.Windows.Forms.TextBox();
            this.NevText = new System.Windows.Forms.TextBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.Profilkep = new System.Windows.Forms.PictureBox();
            this.HozzadButton = new System.Windows.Forms.Button();
            this.Kepgomb = new System.Windows.Forms.Button();
            this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Profilkep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(403, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új adat hozzáadása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Születési dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profilkép:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Azonosító:";
            // 
            // AzonText
            // 
            this.AzonText.Location = new System.Drawing.Point(109, 88);
            this.AzonText.Name = "AzonText";
            this.AzonText.ReadOnly = true;
            this.AzonText.Size = new System.Drawing.Size(100, 26);
            this.AzonText.TabIndex = 5;
            // 
            // NevText
            // 
            this.NevText.Location = new System.Drawing.Point(72, 127);
            this.NevText.Name = "NevText";
            this.NevText.Size = new System.Drawing.Size(137, 26);
            this.NevText.TabIndex = 6;
            // 
            // DateTime
            // 
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime.Location = new System.Drawing.Point(148, 181);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(129, 26);
            this.DateTime.TabIndex = 7;
            // 
            // Profilkep
            // 
            this.Profilkep.Location = new System.Drawing.Point(105, 244);
            this.Profilkep.Name = "Profilkep";
            this.Profilkep.Size = new System.Drawing.Size(196, 141);
            this.Profilkep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profilkep.TabIndex = 8;
            this.Profilkep.TabStop = false;
            // 
            // HozzadButton
            // 
            this.HozzadButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HozzadButton.Location = new System.Drawing.Point(518, 153);
            this.HozzadButton.Name = "HozzadButton";
            this.HozzadButton.Size = new System.Drawing.Size(174, 89);
            this.HozzadButton.TabIndex = 9;
            this.HozzadButton.Text = "Hozzáadás";
            this.HozzadButton.UseVisualStyleBackColor = true;
            this.HozzadButton.Click += new System.EventHandler(this.HozzadButton_Click);
            // 
            // Kepgomb
            // 
            this.Kepgomb.Location = new System.Drawing.Point(24, 423);
            this.Kepgomb.Name = "Kepgomb";
            this.Kepgomb.Size = new System.Drawing.Size(118, 52);
            this.Kepgomb.TabIndex = 10;
            this.Kepgomb.Text = "Kép tölt";
            this.Kepgomb.UseVisualStyleBackColor = true;
            this.Kepgomb.Click += new System.EventHandler(this.Kepgomb_Click);
            // 
            // FileOpenDialog
            // 
            this.FileOpenDialog.FileName = "openFileDialog1";
            // 
            // UjAdatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Kepgomb);
            this.Controls.Add(this.HozzadButton);
            this.Controls.Add(this.Profilkep);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.NevText);
            this.Controls.Add(this.AzonText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UjAdatForm";
            this.Text = "UjAdatForm";
            ((System.ComponentModel.ISupportInitialize)(this.Profilkep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox AzonText;
        public System.Windows.Forms.TextBox NevText;
        public System.Windows.Forms.DateTimePicker DateTime;
        public System.Windows.Forms.PictureBox Profilkep;
        private System.Windows.Forms.Button HozzadButton;
        public System.Windows.Forms.Button Kepgomb;
        public System.Windows.Forms.OpenFileDialog FileOpenDialog;
    }
}