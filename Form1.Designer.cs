namespace bgw_compito2
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAvvia2 = new System.Windows.Forms.TextBox();
            this.txtAvvia100 = new System.Windows.Forms.TextBox();
            this.btnAvvia2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnAvvia100 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAvvia2
            // 
            this.txtAvvia2.Location = new System.Drawing.Point(47, 19);
            this.txtAvvia2.Multiline = true;
            this.txtAvvia2.Name = "txtAvvia2";
            this.txtAvvia2.Size = new System.Drawing.Size(106, 380);
            this.txtAvvia2.TabIndex = 0;
            this.txtAvvia2.TextChanged += new System.EventHandler(this.txtAvvia2_TextChanged);
            // 
            // txtAvvia100
            // 
            this.txtAvvia100.Location = new System.Drawing.Point(288, 19);
            this.txtAvvia100.Multiline = true;
            this.txtAvvia100.Name = "txtAvvia100";
            this.txtAvvia100.Size = new System.Drawing.Size(106, 380);
            this.txtAvvia100.TabIndex = 1;
            this.txtAvvia100.TextChanged += new System.EventHandler(this.txtAvvia100_TextChanged);
            // 
            // btnAvvia2
            // 
            this.btnAvvia2.Location = new System.Drawing.Point(47, 424);
            this.btnAvvia2.Name = "btnAvvia2";
            this.btnAvvia2.Size = new System.Drawing.Size(106, 26);
            this.btnAvvia2.TabIndex = 2;
            this.btnAvvia2.Text = "Avvia 2";
            this.btnAvvia2.UseVisualStyleBackColor = true;
            this.btnAvvia2.Click += new System.EventHandler(this.btnAvvia2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(47, 470);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(106, 26);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.Text = "Stop 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnAvvia100
            // 
            this.btnAvvia100.Location = new System.Drawing.Point(288, 424);
            this.btnAvvia100.Name = "btnAvvia100";
            this.btnAvvia100.Size = new System.Drawing.Size(106, 26);
            this.btnAvvia100.TabIndex = 4;
            this.btnAvvia100.Text = "Avvia 100";
            this.btnAvvia100.UseVisualStyleBackColor = true;
            this.btnAvvia100.Click += new System.EventHandler(this.btnAvvia100_Click);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(288, 470);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(106, 26);
            this.btnStop100.TabIndex = 5;
            this.btnStop100.Text = "Stop 100";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 26);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 554);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnAvvia100);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnAvvia2);
            this.Controls.Add(this.txtAvvia100);
            this.Controls.Add(this.txtAvvia2);
            this.Name = "frmMain";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAvvia2;
        private System.Windows.Forms.TextBox txtAvvia100;
        private System.Windows.Forms.Button btnAvvia2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnAvvia100;
        private System.Windows.Forms.Button btnStop100;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Button btnReset;
    }
}

