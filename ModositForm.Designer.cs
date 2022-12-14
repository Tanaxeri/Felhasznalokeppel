namespace Felhasznalo_keppel
{
    partial class ModositForm
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
            this.ModositButton = new System.Windows.Forms.Button();
            this.Profilkep = new System.Windows.Forms.PictureBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.NevText = new System.Windows.Forms.TextBox();
            this.AzonText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kepgomb = new System.Windows.Forms.Button();
            this.FileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Profilkep)).BeginInit();
            this.SuspendLayout();
            // 
            // ModositButton
            // 
            this.ModositButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModositButton.Location = new System.Drawing.Point(536, 150);
            this.ModositButton.Name = "ModositButton";
            this.ModositButton.Size = new System.Drawing.Size(174, 89);
            this.ModositButton.TabIndex = 19;
            this.ModositButton.Text = "Módosít";
            this.ModositButton.UseVisualStyleBackColor = true;
            this.ModositButton.Click += new System.EventHandler(this.ModositButton_Click);
            // 
            // Profilkep
            // 
            this.Profilkep.Location = new System.Drawing.Point(123, 241);
            this.Profilkep.Name = "Profilkep";
            this.Profilkep.Size = new System.Drawing.Size(196, 141);
            this.Profilkep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profilkep.TabIndex = 18;
            this.Profilkep.TabStop = false;
            // 
            // DateTime
            // 
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime.Location = new System.Drawing.Point(166, 178);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(129, 26);
            this.DateTime.TabIndex = 17;
            // 
            // NevText
            // 
            this.NevText.Location = new System.Drawing.Point(90, 124);
            this.NevText.Name = "NevText";
            this.NevText.Size = new System.Drawing.Size(137, 26);
            this.NevText.TabIndex = 16;
            // 
            // AzonText
            // 
            this.AzonText.Location = new System.Drawing.Point(127, 85);
            this.AzonText.Name = "AzonText";
            this.AzonText.ReadOnly = true;
            this.AzonText.Size = new System.Drawing.Size(100, 26);
            this.AzonText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Azonosító:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Profilkép:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Születési dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(421, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adatok módosítása";
            // 
            // Kepgomb
            // 
            this.Kepgomb.Location = new System.Drawing.Point(12, 406);
            this.Kepgomb.Name = "Kepgomb";
            this.Kepgomb.Size = new System.Drawing.Size(118, 52);
            this.Kepgomb.TabIndex = 20;
            this.Kepgomb.Text = "Kép tölt";
            this.Kepgomb.UseVisualStyleBackColor = true;
            this.Kepgomb.Click += new System.EventHandler(this.Kepgomb_Click);
            // 
            // FileOpenDialog
            // 
            this.FileOpenDialog.FileName = "openFileDialog1";
            // 
            // ModositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Kepgomb);
            this.Controls.Add(this.ModositButton);
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
            this.Name = "ModositForm";
            this.Text = "ModositForm";
            this.Load += new System.EventHandler(this.ModositForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Profilkep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModositButton;
        public System.Windows.Forms.PictureBox Profilkep;
        public System.Windows.Forms.DateTimePicker DateTime;
        public System.Windows.Forms.TextBox NevText;
        public System.Windows.Forms.TextBox AzonText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Kepgomb;
        public System.Windows.Forms.OpenFileDialog FileOpenDialog;
    }
}