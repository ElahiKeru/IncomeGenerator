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
            this.BTNRemoveBusiness = new System.Windows.Forms.Button();
            this.BTNAddBusiness = new System.Windows.Forms.Button();
            this.NUDMaint = new System.Windows.Forms.NumericUpDown();
            this.NUDProfit = new System.Windows.Forms.NumericUpDown();
            this.LBProfits = new System.Windows.Forms.Label();
            this.LBMaint = new System.Windows.Forms.Label();
            this.TBBusName = new System.Windows.Forms.TextBox();
            this.LBBusName = new System.Windows.Forms.Label();
            this.GBAdventurers = new System.Windows.Forms.GroupBox();
            this.BTNRemoveAdventurer = new System.Windows.Forms.Button();
            this.BTNAddAdventurer = new System.Windows.Forms.Button();
            this.NUDMod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TBAdventurerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LVAdventurers = new System.Windows.Forms.ListView();
            this.LBDays = new System.Windows.Forms.Label();
            this.NUDDays = new System.Windows.Forms.NumericUpDown();
            this.BTNSimulate = new System.Windows.Forms.Button();
            this.GBBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProfit)).BeginInit();
            this.GBAdventurers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDays)).BeginInit();
            this.SuspendLayout();
            // 
            // LVBusinesses
            // 
            this.LVBusinesses.Location = new System.Drawing.Point(4, 17);
            this.LVBusinesses.Margin = new System.Windows.Forms.Padding(2);
            this.LVBusinesses.Name = "LVBusinesses";
            this.LVBusinesses.Size = new System.Drawing.Size(305, 101);
            this.LVBusinesses.TabIndex = 0;
            this.LVBusinesses.UseCompatibleStateImageBehavior = false;
            this.LVBusinesses.View = System.Windows.Forms.View.Details;
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
            this.GBBusiness.Location = new System.Drawing.Point(11, 31);
            this.GBBusiness.Margin = new System.Windows.Forms.Padding(2);
            this.GBBusiness.Name = "GBBusiness";
            this.GBBusiness.Padding = new System.Windows.Forms.Padding(2);
            this.GBBusiness.Size = new System.Drawing.Size(505, 194);
            this.GBBusiness.TabIndex = 1;
            this.GBBusiness.TabStop = false;
            this.GBBusiness.Text = "Businesses";
            // 
            // BTNRemoveBusiness
            // 
            this.BTNRemoveBusiness.Location = new System.Drawing.Point(4, 122);
            this.BTNRemoveBusiness.Margin = new System.Windows.Forms.Padding(2);
            this.BTNRemoveBusiness.Name = "BTNRemoveBusiness";
            this.BTNRemoveBusiness.Size = new System.Drawing.Size(56, 19);
            this.BTNRemoveBusiness.TabIndex = 9;
            this.BTNRemoveBusiness.Text = "Remove";
            this.BTNRemoveBusiness.UseVisualStyleBackColor = true;
            this.BTNRemoveBusiness.Click += new System.EventHandler(this.BTNRemoveBusiness_Click);
            // 
            // BTNAddBusiness
            // 
            this.BTNAddBusiness.Location = new System.Drawing.Point(324, 99);
            this.BTNAddBusiness.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAddBusiness.Name = "BTNAddBusiness";
            this.BTNAddBusiness.Size = new System.Drawing.Size(56, 19);
            this.BTNAddBusiness.TabIndex = 8;
            this.BTNAddBusiness.Text = "Add";
            this.BTNAddBusiness.UseVisualStyleBackColor = true;
            this.BTNAddBusiness.Click += new System.EventHandler(this.BTNAddBusiness_Click);
            // 
            // NUDMaint
            // 
            this.NUDMaint.Location = new System.Drawing.Point(416, 38);
            this.NUDMaint.Margin = new System.Windows.Forms.Padding(2);
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
            this.NUDMaint.Size = new System.Drawing.Size(75, 20);
            this.NUDMaint.TabIndex = 3;
            this.NUDMaint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDProfit
            // 
            this.NUDProfit.Location = new System.Drawing.Point(416, 62);
            this.NUDProfit.Margin = new System.Windows.Forms.Padding(2);
            this.NUDProfit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDProfit.Name = "NUDProfit";
            this.NUDProfit.Size = new System.Drawing.Size(75, 20);
            this.NUDProfit.TabIndex = 4;
            this.NUDProfit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LBProfits
            // 
            this.LBProfits.AutoSize = true;
            this.LBProfits.Location = new System.Drawing.Point(321, 64);
            this.LBProfits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBProfits.Name = "LBProfits";
            this.LBProfits.Size = new System.Drawing.Size(75, 13);
            this.LBProfits.TabIndex = 5;
            this.LBProfits.Text = "Profit Multiplier";
            // 
            // LBMaint
            // 
            this.LBMaint.AutoSize = true;
            this.LBMaint.Location = new System.Drawing.Point(321, 41);
            this.LBMaint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBMaint.Name = "LBMaint";
            this.LBMaint.Size = new System.Drawing.Size(93, 13);
            this.LBMaint.TabIndex = 3;
            this.LBMaint.Text = "Maintenance Cost";
            // 
            // TBBusName
            // 
            this.TBBusName.Location = new System.Drawing.Point(416, 16);
            this.TBBusName.Margin = new System.Windows.Forms.Padding(2);
            this.TBBusName.Name = "TBBusName";
            this.TBBusName.Size = new System.Drawing.Size(76, 20);
            this.TBBusName.TabIndex = 2;
            // 
            // LBBusName
            // 
            this.LBBusName.AutoSize = true;
            this.LBBusName.Location = new System.Drawing.Point(321, 18);
            this.LBBusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBBusName.Name = "LBBusName";
            this.LBBusName.Size = new System.Drawing.Size(35, 13);
            this.LBBusName.TabIndex = 1;
            this.LBBusName.Text = "Name";
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
            this.GBAdventurers.Location = new System.Drawing.Point(11, 230);
            this.GBAdventurers.Margin = new System.Windows.Forms.Padding(2);
            this.GBAdventurers.Name = "GBAdventurers";
            this.GBAdventurers.Padding = new System.Windows.Forms.Padding(2);
            this.GBAdventurers.Size = new System.Drawing.Size(505, 186);
            this.GBAdventurers.TabIndex = 2;
            this.GBAdventurers.TabStop = false;
            this.GBAdventurers.Text = "Adventurers";
            // 
            // BTNRemoveAdventurer
            // 
            this.BTNRemoveAdventurer.Location = new System.Drawing.Point(4, 122);
            this.BTNRemoveAdventurer.Margin = new System.Windows.Forms.Padding(2);
            this.BTNRemoveAdventurer.Name = "BTNRemoveAdventurer";
            this.BTNRemoveAdventurer.Size = new System.Drawing.Size(56, 19);
            this.BTNRemoveAdventurer.TabIndex = 13;
            this.BTNRemoveAdventurer.Text = "Remove";
            this.BTNRemoveAdventurer.UseVisualStyleBackColor = true;
            this.BTNRemoveAdventurer.Click += new System.EventHandler(this.BTNRemoveAdventurer_Click);
            // 
            // BTNAddAdventurer
            // 
            this.BTNAddAdventurer.Location = new System.Drawing.Point(216, 99);
            this.BTNAddAdventurer.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAddAdventurer.Name = "BTNAddAdventurer";
            this.BTNAddAdventurer.Size = new System.Drawing.Size(56, 19);
            this.BTNAddAdventurer.TabIndex = 12;
            this.BTNAddAdventurer.Text = "Add";
            this.BTNAddAdventurer.UseVisualStyleBackColor = true;
            this.BTNAddAdventurer.Click += new System.EventHandler(this.BTNAddAdventurer_Click);
            // 
            // NUDMod
            // 
            this.NUDMod.Location = new System.Drawing.Point(280, 40);
            this.NUDMod.Margin = new System.Windows.Forms.Padding(2);
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
            this.NUDMod.Size = new System.Drawing.Size(75, 20);
            this.NUDMod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modifier";
            // 
            // TBAdventurerName
            // 
            this.TBAdventurerName.Location = new System.Drawing.Point(280, 17);
            this.TBAdventurerName.Margin = new System.Windows.Forms.Padding(2);
            this.TBAdventurerName.Name = "TBAdventurerName";
            this.TBAdventurerName.Size = new System.Drawing.Size(76, 20);
            this.TBAdventurerName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // LVAdventurers
            // 
            this.LVAdventurers.Location = new System.Drawing.Point(4, 17);
            this.LVAdventurers.Margin = new System.Windows.Forms.Padding(2);
            this.LVAdventurers.Name = "LVAdventurers";
            this.LVAdventurers.Size = new System.Drawing.Size(205, 101);
            this.LVAdventurers.TabIndex = 1;
            this.LVAdventurers.UseCompatibleStateImageBehavior = false;
            this.LVAdventurers.View = System.Windows.Forms.View.Details;
            // 
            // LBDays
            // 
            this.LBDays.AutoSize = true;
            this.LBDays.Location = new System.Drawing.Point(11, 9);
            this.LBDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBDays.Name = "LBDays";
            this.LBDays.Size = new System.Drawing.Size(83, 13);
            this.LBDays.TabIndex = 4;
            this.LBDays.Text = "Days Operating:";
            // 
            // NUDDays
            // 
            this.NUDDays.Location = new System.Drawing.Point(99, 7);
            this.NUDDays.Margin = new System.Windows.Forms.Padding(2);
            this.NUDDays.Name = "NUDDays";
            this.NUDDays.Size = new System.Drawing.Size(57, 20);
            this.NUDDays.TabIndex = 1;
            // 
            // BTNSimulate
            // 
            this.BTNSimulate.Location = new System.Drawing.Point(15, 420);
            this.BTNSimulate.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSimulate.Name = "BTNSimulate";
            this.BTNSimulate.Size = new System.Drawing.Size(56, 19);
            this.BTNSimulate.TabIndex = 14;
            this.BTNSimulate.Text = "Simulate";
            this.BTNSimulate.UseVisualStyleBackColor = true;
            this.BTNSimulate.Click += new System.EventHandler(this.BTNSimulate_Click);
            // 
            // IncomeGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 451);
            this.Controls.Add(this.BTNSimulate);
            this.Controls.Add(this.NUDDays);
            this.Controls.Add(this.LBDays);
            this.Controls.Add(this.GBAdventurers);
            this.Controls.Add(this.GBBusiness);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IncomeGeneratorForm";
            this.Text = "Income Generator";
            this.Load += new System.EventHandler(this.IncomeGeneratorForm_Load);
            this.GBBusiness.ResumeLayout(false);
            this.GBBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProfit)).EndInit();
            this.GBAdventurers.ResumeLayout(false);
            this.GBAdventurers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDays)).EndInit();
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

