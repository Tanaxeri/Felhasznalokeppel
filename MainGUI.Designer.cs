namespace Felhasznalo_keppel
{
    partial class MainGUI
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
            this.Felhaszdata = new System.Windows.Forms.DataGridView();
            this.UjAdat_M = new System.Windows.Forms.Button();
            this.Modos_M = new System.Windows.Forms.Button();
            this.Torol_M = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Felhaszdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(347, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználók nyilvántartása";
            // 
            // Felhaszdata
            // 
            this.Felhaszdata.AllowUserToAddRows = false;
            this.Felhaszdata.AllowUserToDeleteRows = false;
            this.Felhaszdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Felhaszdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Felhaszdata.Location = new System.Drawing.Point(0, 256);
            this.Felhaszdata.Name = "Felhaszdata";
            this.Felhaszdata.ReadOnly = true;
            this.Felhaszdata.Size = new System.Drawing.Size(1200, 402);
            this.Felhaszdata.TabIndex = 1;
            this.Felhaszdata.SelectionChanged += new System.EventHandler(this.Felhaszdata_SelectionChanged);
            // 
            // UjAdat_M
            // 
            this.UjAdat_M.Location = new System.Drawing.Point(68, 152);
            this.UjAdat_M.Name = "UjAdat_M";
            this.UjAdat_M.Size = new System.Drawing.Size(160, 54);
            this.UjAdat_M.TabIndex = 2;
            this.UjAdat_M.Text = "Új adat";
            this.UjAdat_M.UseVisualStyleBackColor = true;
            this.UjAdat_M.Click += new System.EventHandler(this.UjAdat_M_Click);
            // 
            // Modos_M
            // 
            this.Modos_M.Location = new System.Drawing.Point(323, 152);
            this.Modos_M.Name = "Modos_M";
            this.Modos_M.Size = new System.Drawing.Size(160, 54);
            this.Modos_M.TabIndex = 3;
            this.Modos_M.Text = "Módosítás";
            this.Modos_M.UseVisualStyleBackColor = true;
            this.Modos_M.Click += new System.EventHandler(this.Modos_M_Click);
            // 
            // Torol_M
            // 
            this.Torol_M.Location = new System.Drawing.Point(592, 152);
            this.Torol_M.Name = "Torol_M";
            this.Torol_M.Size = new System.Drawing.Size(160, 54);
            this.Torol_M.TabIndex = 4;
            this.Torol_M.Text = "Törlés";
            this.Torol_M.UseVisualStyleBackColor = true;
            this.Torol_M.Click += new System.EventHandler(this.Torol_M_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Torol_M);
            this.Controls.Add(this.Modos_M);
            this.Controls.Add(this.UjAdat_M);
            this.Controls.Add(this.Felhaszdata);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Felhaszdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Felhaszdata;
        private System.Windows.Forms.Button UjAdat_M;
        private System.Windows.Forms.Button Modos_M;
        private System.Windows.Forms.Button Torol_M;
    }
}

