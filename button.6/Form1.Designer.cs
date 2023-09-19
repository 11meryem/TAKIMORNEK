namespace button._6
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
            this.btnfener = new System.Windows.Forms.Button();
            this.btntrab = new System.Windows.Forms.Button();
            this.btnbesik = new System.Windows.Forms.Button();
            this.btngalat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfener
            // 
            this.btnfener.Location = new System.Drawing.Point(26, 12);
            this.btnfener.Name = "btnfener";
            this.btnfener.Size = new System.Drawing.Size(111, 44);
            this.btnfener.TabIndex = 0;
            this.btnfener.Text = "Fenerbahçe";
            this.btnfener.UseVisualStyleBackColor = true;
            this.btnfener.Click += new System.EventHandler(this.btnfener_Click);
            // 
            // btntrab
            // 
            this.btntrab.Location = new System.Drawing.Point(26, 62);
            this.btntrab.Name = "btntrab";
            this.btntrab.Size = new System.Drawing.Size(111, 44);
            this.btntrab.TabIndex = 1;
            this.btntrab.Text = "Trabzon";
            this.btntrab.UseVisualStyleBackColor = true;
            this.btntrab.Click += new System.EventHandler(this.btntrab_Click);
            // 
            // btnbesik
            // 
            this.btnbesik.Location = new System.Drawing.Point(26, 112);
            this.btnbesik.Name = "btnbesik";
            this.btnbesik.Size = new System.Drawing.Size(111, 44);
            this.btnbesik.TabIndex = 2;
            this.btnbesik.Text = "Beşiktaş";
            this.btnbesik.UseVisualStyleBackColor = true;
            this.btnbesik.Click += new System.EventHandler(this.btnbesik_Click);
            // 
            // btngalat
            // 
            this.btngalat.Location = new System.Drawing.Point(26, 162);
            this.btngalat.Name = "btngalat";
            this.btngalat.Size = new System.Drawing.Size(111, 44);
            this.btngalat.TabIndex = 3;
            this.btngalat.Text = "Galatasaray";
            this.btngalat.UseVisualStyleBackColor = true;
            this.btngalat.Click += new System.EventHandler(this.btngalat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "TAKIMLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngalat);
            this.Controls.Add(this.btnbesik);
            this.Controls.Add(this.btntrab);
            this.Controls.Add(this.btnfener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfener;
        private System.Windows.Forms.Button btntrab;
        private System.Windows.Forms.Button btnbesik;
        private System.Windows.Forms.Button btngalat;
        private System.Windows.Forms.Label label1;
    }
}

