namespace PRG272Group5PM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecoveryscore = new System.Windows.Forms.Label();
            this.txtRecovery = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.CAnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHousing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecoveryscore);
            this.groupBox1.Controls.Add(this.txtRecovery);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtSpecies);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAnimalID);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblSpecies);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAnimalID);
            this.groupBox1.Location = new System.Drawing.Point(30, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Animal";
            // 
            // lblRecoveryscore
            // 
            this.lblRecoveryscore.AutoSize = true;
            this.lblRecoveryscore.Location = new System.Drawing.Point(1, 174);
            this.lblRecoveryscore.Name = "lblRecoveryscore";
            this.lblRecoveryscore.Size = new System.Drawing.Size(87, 13);
            this.lblRecoveryscore.TabIndex = 9;
            this.lblRecoveryscore.Text = "Recovery Score:";
            // 
            // txtRecovery
            // 
            this.txtRecovery.Location = new System.Drawing.Point(94, 171);
            this.txtRecovery.Name = "txtRecovery";
            this.txtRecovery.Size = new System.Drawing.Size(100, 20);
            this.txtRecovery.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(94, 133);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(94, 101);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 20);
            this.txtSpecies.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(94, 35);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalID.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 136);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(21, 101);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(21, 35);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(55, 13);
            this.lblAnimalID.TabIndex = 0;
            this.lblAnimalID.Text = "Animal ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAnimalID,
            this.CName,
            this.CSpecies,
            this.CAge,
            this.CRecovery,
            this.CStatus,
            this.CHousing});
            this.dgvAnimals.Location = new System.Drawing.Point(245, 38);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.Size = new System.Drawing.Size(745, 204);
            this.dgvAnimals.TabIndex = 2;
            // 
            // CAnimalID
            // 
            this.CAnimalID.HeaderText = "AnimalID";
            this.CAnimalID.DataPropertyName = "AnimalID";
            this.CAnimalID.Name = "CAnimalID";
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.DataPropertyName = "Name";
            this.CName.Name = "CName";
            // 
            // CSpecies
            // 
            this.CSpecies.HeaderText = "Species";
            this.CSpecies.DataPropertyName = "Species";
            this.CSpecies.Name = "CSpecies";
            // 
            // CAge
            // 
            this.CAge.HeaderText = "Age";
            this.CAge.DataPropertyName = "Age";
            this.CAge.Name = "CAge";
            // 
            // CRecovery
            // 
            this.CRecovery.HeaderText = "Recovery Score";
            this.CRecovery.DataPropertyName = "Recoverystat";
            this.CRecovery.Name = "CRecovery";
            // 
            // CStatus
            // 
            this.CStatus.HeaderText = "Status";
            this.CStatus.DataPropertyName = "Status";
            this.CStatus.Name = "CStatus";
            // 
            // CHousing
            // 
            this.CHousing.HeaderText = "Housing Unit";
            this.CHousing.DataPropertyName = "Housing";
            this.CHousing.Name = "CHousing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 350);
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblRecoveryscore;
        private System.Windows.Forms.TextBox txtRecovery;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRecovery;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHousing;
    }
}

