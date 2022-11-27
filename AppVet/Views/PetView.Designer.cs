namespace AppVet.Views
{
    partial class PetView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvListPets = new System.Windows.Forms.DataGridView();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.tbSearchPet = new System.Windows.Forms.TextBox();
            this.lblSearchPet = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbPetColour = new System.Windows.Forms.TextBox();
            this.tbPetType = new System.Windows.Forms.TextBox();
            this.tbPetName = new System.Windows.Forms.TextBox();
            this.tbPetId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPetColour = new System.Windows.Forms.Label();
            this.lblPetType = new System.Windows.Forms.Label();
            this.lblpetName = new System.Windows.Forms.Label();
            this.lblPetId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPets)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pets";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(706, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 402);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvListPets);
            this.tabPage2.Controls.Add(this.btnAddPet);
            this.tabPage2.Controls.Add(this.btnEditPet);
            this.tabPage2.Controls.Add(this.btnDeletePet);
            this.tabPage2.Controls.Add(this.btnSearchPet);
            this.tabPage2.Controls.Add(this.tbSearchPet);
            this.tabPage2.Controls.Add(this.lblSearchPet);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pet list";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvListPets
            // 
            this.dgvListPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPets.Location = new System.Drawing.Point(8, 76);
            this.dgvListPets.Name = "dgvListPets";
            this.dgvListPets.RowTemplate.Height = 25;
            this.dgvListPets.Size = new System.Drawing.Size(567, 290);
            this.dgvListPets.TabIndex = 6;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPet.Location = new System.Drawing.Point(584, 76);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(71, 23);
            this.btnAddPet.TabIndex = 5;
            this.btnAddPet.Text = "Add new";
            this.btnAddPet.UseVisualStyleBackColor = true;
            // 
            // btnEditPet
            // 
            this.btnEditPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPet.Location = new System.Drawing.Point(584, 105);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(71, 23);
            this.btnEditPet.TabIndex = 4;
            this.btnEditPet.Text = "Edit";
            this.btnEditPet.UseVisualStyleBackColor = true;
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePet.Location = new System.Drawing.Point(584, 134);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(71, 23);
            this.btnDeletePet.TabIndex = 3;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPet.Location = new System.Drawing.Point(504, 45);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(71, 23);
            this.btnSearchPet.TabIndex = 2;
            this.btnSearchPet.Text = "Search";
            this.btnSearchPet.UseVisualStyleBackColor = true;
            // 
            // tbSearchPet
            // 
            this.tbSearchPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchPet.Location = new System.Drawing.Point(8, 45);
            this.tbSearchPet.Name = "tbSearchPet";
            this.tbSearchPet.Size = new System.Drawing.Size(490, 23);
            this.tbSearchPet.TabIndex = 1;
            // 
            // lblSearchPet
            // 
            this.lblSearchPet.AutoSize = true;
            this.lblSearchPet.Location = new System.Drawing.Point(8, 27);
            this.lblSearchPet.Name = "lblSearchPet";
            this.lblSearchPet.Size = new System.Drawing.Size(65, 15);
            this.lblSearchPet.TabIndex = 0;
            this.lblSearchPet.Text = "Search Pet:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPetColour);
            this.tabPage1.Controls.Add(this.tbPetType);
            this.tabPage1.Controls.Add(this.tbPetName);
            this.tabPage1.Controls.Add(this.tbPetId);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lblPetColour);
            this.tabPage1.Controls.Add(this.lblPetType);
            this.tabPage1.Controls.Add(this.lblpetName);
            this.tabPage1.Controls.Add(this.lblPetId);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pet details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbPetColour
            // 
            this.tbPetColour.Location = new System.Drawing.Point(52, 203);
            this.tbPetColour.Name = "tbPetColour";
            this.tbPetColour.Size = new System.Drawing.Size(279, 23);
            this.tbPetColour.TabIndex = 9;
            // 
            // tbPetType
            // 
            this.tbPetType.Location = new System.Drawing.Point(212, 135);
            this.tbPetType.Name = "tbPetType";
            this.tbPetType.Size = new System.Drawing.Size(119, 23);
            this.tbPetType.TabIndex = 8;
            // 
            // tbPetName
            // 
            this.tbPetName.Location = new System.Drawing.Point(52, 135);
            this.tbPetName.Name = "tbPetName";
            this.tbPetName.Size = new System.Drawing.Size(119, 23);
            this.tbPetName.TabIndex = 7;
            // 
            // tbPetId
            // 
            this.tbPetId.Location = new System.Drawing.Point(52, 68);
            this.tbPetId.Name = "tbPetId";
            this.tbPetId.Size = new System.Drawing.Size(119, 23);
            this.tbPetId.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPetColour
            // 
            this.lblPetColour.AutoSize = true;
            this.lblPetColour.Location = new System.Drawing.Point(52, 173);
            this.lblPetColour.Name = "lblPetColour";
            this.lblPetColour.Size = new System.Drawing.Size(61, 15);
            this.lblPetColour.TabIndex = 3;
            this.lblPetColour.Text = "Pet colour";
            // 
            // lblPetType
            // 
            this.lblPetType.AutoSize = true;
            this.lblPetType.Location = new System.Drawing.Point(212, 103);
            this.lblPetType.Name = "lblPetType";
            this.lblPetType.Size = new System.Drawing.Size(51, 15);
            this.lblPetType.TabIndex = 2;
            this.lblPetType.Text = "Pet Type";
            // 
            // lblpetName
            // 
            this.lblpetName.AutoSize = true;
            this.lblpetName.Location = new System.Drawing.Point(52, 103);
            this.lblpetName.Name = "lblpetName";
            this.lblpetName.Size = new System.Drawing.Size(62, 15);
            this.lblpetName.TabIndex = 1;
            this.lblpetName.Text = "Pet Name:";
            // 
            // lblPetId
            // 
            this.lblPetId.AutoSize = true;
            this.lblPetId.Location = new System.Drawing.Point(52, 40);
            this.lblPetId.Name = "lblPetId";
            this.lblPetId.Size = new System.Drawing.Size(41, 15);
            this.lblPetId.TabIndex = 0;
            this.lblPetId.Text = "Pet ID:";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPets)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dgvListPets;
        private Button btnAddPet;
        private Button btnEditPet;
        private Button btnDeletePet;
        private Button btnSearchPet;
        private TextBox tbSearchPet;
        private Label lblSearchPet;
        private TabPage tabPage1;
        private TextBox tbPetColour;
        private TextBox tbPetType;
        private TextBox tbPetName;
        private TextBox tbPetId;
        private Button btnCancel;
        private Button btnSave;
        private Label lblPetColour;
        private Label lblPetType;
        private Label lblpetName;
        private Label lblPetId;
        private Button btnClose;
    }
}