namespace IncomeGenerator
{
    partial class IncomeGeneratorForm
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
            this.LVBusinesses = new System.Windows.Forms.ListView();
            this.GBBusiness = new System.Windows.Forms.GroupBox();
            this.GBAdventurers = new System.Windows.Forms.GroupBox();
            this.LVAdventurers = new System.Windows.Forms.ListView();
            this.LBDays = new System.Windows.Forms.Label();
            this.LBBusName = new System.Windows.Forms.Label();
            this.TBBusName = new System.Windows.Forms.TextBox();
            this.LBMaint = new System.Windows.Forms.Label();
            this.LBProfits = new System.Windows.Forms.Label();
            this.NUDProfit = new System.Windows.Forms.NumericUpDown();
            this.NUDDays = new System.Windows.Forms.NumericUpDown();
            this.NUDMaint = new System.Windows.Forms.NumericUpDown();
            this.NUDMod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TBAdventurerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNAddBusiness = new System.Windows.Forms.Button();
            this.BTNRemoveBusiness = new System.Windows.Forms.Button();
            this.BTNAddAdventurer = new System.Windows.Forms.Button();
            this.BTNRemoveAdventurer = new System.Windows.Forms.Button();
            this.BTNSimulate = new System.Windows.Forms.Button();
            this.GBBusiness.SuspendLayout();
            this.GBAdventurers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMod)).BeginInit();
            this.SuspendLayout();
            // 
            // LVBusinesses
            // 
            this.LVBusinesses.Location = new System.Drawing.Point(6, 21);
            this.LVBusinesses.Name = "LVBusinesses";
            this.LVBusinesses.Size = new System.Drawing.Size(243, 123);
            this.LVBusinesses.TabIndex = 0;
            this.LVBusinesses.UseCompatibleStateImageBehavior = false;
            // 
            // GBBusiness
            // 
            this.GBBusiness.Controls.Add(this.BTNRemoveBusiness);
            this.GBBusiness.Controls.Add(this.BTNAddBusiness);
            this.GBBusiness.Controls.Add(this.NUDMaint);
            this.GBBusiness.Controls.Add(this.NUDProfit);
            this.GBBusiness.Controls.Add(this.LBProfits);
            this.GBBusiness.Controls.Add(this.LBMaint);
            this.GBBusiness.Controls.Add(this.TBBusName);
            this.GBBusiness.Controls.Add(this.LBBusName);
            this.GBBusiness.Controls.Add(this.LVBusinesses);
            this.GBBusiness.Location = new System.Drawing.Point(12, 12);
            this.GBBusiness.Name = "GBBusiness";
            this.GBBusiness.Size = new System.Drawing.Size(498, 239);
            this.GBBusiness.TabIndex = 1;
            this.GBBusiness.TabStop = false;
            this.GBBusiness.Text = "Businesses";
            // 
            // GBAdventurers
            // 
            this.GBAdventurers.Controls.Add(this.BTNRemoveAdventurer);
            this.GBAdventurers.Controls.Add(this.BTNAddAdventurer);
            this.GBAdventurers.Controls.Add(this.NUDMod);
            this.GBAdventurers.Controls.Add(this.label1);
            this.GBAdventurers.Controls.Add(this.TBAdventurerName);
            this.GBAdventurers.Controls.Add(this.label2);
            this.GBAdventurers.Controls.Add(this.LVAdventurers);
            this.GBAdventurers.Location = new System.Drawing.Point(12, 257);
            this.GBAdventurers.Name = "GBAdventurers";
            this.GBAdventurers.Size = new System.Drawing.Size(498, 229);
            this.GBAdventurers.TabIndex = 2;
            this.GBAdventurers.TabStop = false;
            this.GBAdventurers.Text = "Adventurers";
            // 
            // LVAdventurers
            // 
            this.LVAdventurers.Location = new System.Drawing.Point(6, 21);
            this.LVAdventurers.Name = "LVAdventurers";
            this.LVAdventurers.Size = new System.Drawing.Size(243, 123);
            this.LVAdventurers.TabIndex = 1;
            this.LVAdventurers.UseCompatibleStateImageBehavior = false;
            // 
            // LBDays
            // 
            this.LBDays.AutoSize = true;
            this.LBDays.Location = new System.Drawing.Point(14, 503);
            this.LBDays.Name = "LBDays";
            this.LBDays.Size = new System.Drawing.Size(111, 17);
            this.LBDays.TabIndex = 4;
            this.LBDays.Text = "Days Operating:";
            // 
            // LBBusName
            // 
            this.LBBusName.AutoSize = true;
            this.LBBusName.Location = new System.Drawing.Point(255, 21);
            this.LBBusName.Name = "LBBusName";
            this.LBBusName.Size = new System.Drawing.Size(45, 17);
            this.LBBusName.TabIndex = 1;
            this.LBBusName.Text = "Name";
            // 
            // TBBusName
            // 
            this.TBBusName.Location = new System.Drawing.Point(382, 18);
            this.TBBusName.Name = "TBBusName";
            this.TBBusName.Size = new System.Drawing.Size(100, 22);
            this.TBBusName.TabIndex = 2;
            // 
            // LBMaint
            // 
            this.LBMaint.AutoSize = true;
            this.LBMaint.Location = new System.Drawing.Point(255, 49);
            this.LBMaint.Name = "LBMaint";
            this.LBMaint.Size = new System.Drawing.Size(121, 17);
            this.LBMaint.TabIndex = 3;
            this.LBMaint.Text = "Maintenance Cost";
            // 
            // LBProfits
            // 
            this.LBProfits.AutoSize = true;
            this.LBProfits.Location = new System.Drawing.Point(255, 77);
            this.LBProfits.Name = "LBProfits";
            this.LBProfits.Size = new System.Drawing.Size(101, 17);
            this.LBProfits.TabIndex = 5;
            this.LBProfits.Text = "Profit Multiplier";
            // 
            // NUDProfit
            // 
            this.NUDProfit.Location = new System.Drawing.Point(382, 75);
            this.NUDProfit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDProfit.Name = "NUDProfit";
            this.NUDProfit.Size = new System.Drawing.Size(100, 22);
            this.NUDProfit.TabIndex = 6;
            this.NUDProfit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NUDDays
            // 
            this.NUDDays.Location = new System.Drawing.Point(131, 501);
            this.NUDDays.Name = "NUDDays";
            this.NUDDays.Size = new System.Drawing.Size(76, 22);
            this.NUDDays.TabIndex = 5;
            // 
            // NUDMaint
            // 
            this.NUDMaint.Location = new System.Drawing.Point(382, 46);
            this.NUDMaint.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDMaint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDMaint.Name = "NUDMaint";
            this.NUDMaint.Size = new System.Drawing.Size(100, 22);
            this.NUDMaint.TabIndex = 7;
            this.NUDMaint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDMod
            // 
            this.NUDMod.Location = new System.Drawing.Point(319, 49);
            this.NUDMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDMod.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NUDMod.Name = "NUDMod";
            this.NUDMod.Size = new System.Drawing.Size(100, 22);
            this.NUDMod.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modifier";
            // 
            // TBAdventurerName
            // 
            this.TBAdventurerName.Location = new System.Drawing.Point(319, 21);
            this.TBAdventurerName.Name = "TBAdventurerName";
            this.TBAdventurerName.Size = new System.Drawing.Size(100, 22);
            this.TBAdventurerName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // BTNAddBusiness
            // 
            this.BTNAddBusiness.Location = new System.Drawing.Point(258, 121);
            this.BTNAddBusiness.Name = "BTNAddBusiness";
            this.BTNAddBusiness.Size = new System.Drawing.Size(75, 23);
            this.BTNAddBusiness.TabIndex = 8;
            this.BTNAddBusiness.Text = "Add";
            this.BTNAddBusiness.UseVisualStyleBackColor = true;
            this.BTNAddBusiness.Click += new System.EventHandler(this.BTNAddBusiness_Click);
            // 
            // BTNRemoveBusiness
            // 
            this.BTNRemoveBusiness.Location = new System.Drawing.Point(6, 150);
            this.BTNRemoveBusiness.Name = "BTNRemoveBusiness";
            this.BTNRemoveBusiness.Size = new System.Drawing.Size(75, 23);
            this.BTNRemoveBusiness.TabIndex = 9;
            this.BTNRemoveBusiness.Text = "Remove";
            this.BTNRemoveBusiness.UseVisualStyleBackColor = true;
            this.BTNRemoveBusiness.Click += new System.EventHandler(this.BTNRemoveBusiness_Click);
            // 
            // BTNAddAdventurer
            // 
            this.BTNAddAdventurer.Location = new System.Drawing.Point(258, 121);
            this.BTNAddAdventurer.Name = "BTNAddAdventurer";
            this.BTNAddAdventurer.Size = new System.Drawing.Size(75, 23);
            this.BTNAddAdventurer.TabIndex = 12;
            this.BTNAddAdventurer.Text = "Add";
            this.BTNAddAdventurer.UseVisualStyleBackColor = true;
            this.BTNAddAdventurer.Click += new System.EventHandler(this.BTNAddAdventurer_Click);
            // 
            // BTNRemoveAdventurer
            // 
            this.BTNRemoveAdventurer.Location = new System.Drawing.Point(6, 150);
            this.BTNRemoveAdventurer.Name = "BTNRemoveAdventurer";
            this.BTNRemoveAdventurer.Size = new System.Drawing.Size(75, 23);
            this.BTNRemoveAdventurer.TabIndex = 13;
            this.BTNRemoveAdventurer.Text = "Remove";
            this.BTNRemoveAdventurer.UseVisualStyleBackColor = true;
            this.BTNRemoveAdventurer.Click += new System.EventHandler(this.BTNRemoveAdventurer_Click);
            // 
            // BTNSimulate
            // 
            this.BTNSimulate.Location = new System.Drawing.Point(213, 500);
            this.BTNSimulate.Name = "BTNSimulate";
            this.BTNSimulate.Size = new System.Drawing.Size(75, 23);
            this.BTNSimulate.TabIndex = 14;
            this.BTNSimulate.Text = "Simulate";
            this.BTNSimulate.UseVisualStyleBackColor = true;
            this.BTNSimulate.Click += new System.EventHandler(this.BTNSimulate_Click);
            // 
            // IncomeGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 551);
            this.Controls.Add(this.BTNSimulate);
            this.Controls.Add(this.NUDDays);
            this.Controls.Add(this.LBDays);
            this.Controls.Add(this.GBAdventurers);
            this.Controls.Add(this.GBBusiness);
            this.Name = "IncomeGeneratorForm";
            this.Text = "Income Generator";
            this.GBBusiness.ResumeLayout(false);
            this.GBBusiness.PerformLayout();
            this.GBAdventurers.ResumeLayout(false);
            this.GBAdventurers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVBusinesses;
        private System.Windows.Forms.GroupBox GBBusiness;
        private System.Windows.Forms.GroupBox GBAdventurers;
        private System.Windows.Forms.ListView LVAdventurers;
        private System.Windows.Forms.NumericUpDown NUDMaint;
        private System.Windows.Forms.NumericUpDown NUDProfit;
        private System.Windows.Forms.Label LBProfits;
        private System.Windows.Forms.Label LBMaint;
        private System.Windows.Forms.TextBox TBBusName;
        private System.Windows.Forms.Label LBBusName;
        private System.Windows.Forms.Label LBDays;
        private System.Windows.Forms.NumericUpDown NUDDays;
        private System.Windows.Forms.Button BTNRemoveBusiness;
        private System.Windows.Forms.Button BTNAddBusiness;
        private System.Windows.Forms.Button BTNRemoveAdventurer;
        private System.Windows.Forms.Button BTNAddAdventurer;
        private System.Windows.Forms.NumericUpDown NUDMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAdventurerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNSimulate;
    }
}

