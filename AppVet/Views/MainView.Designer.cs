namespace AppVet.Views
{
    partial class MainView
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
            this.pMainView = new System.Windows.Forms.Panel();
            this.btnPets = new System.Windows.Forms.Button();
            this.pMainView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMainView
            // 
            this.pMainView.Controls.Add(this.btnPets);
            this.pMainView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMainView.Location = new System.Drawing.Point(0, 0);
            this.pMainView.Name = "pMainView";
            this.pMainView.Size = new System.Drawing.Size(162, 450);
            this.pMainView.TabIndex = 0;
            // 
            // btnPets
            // 
            this.btnPets.Location = new System.Drawing.Point(12, 12);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(138, 34);
            this.btnPets.TabIndex = 0;
            this.btnPets.Text = "Pets";
            this.btnPets.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMainView);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.pMainView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pMainView;
        private Button btnPets;
    }
}