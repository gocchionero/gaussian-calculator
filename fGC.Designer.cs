namespace GaussianCalculator
{
    partial class fGC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGC));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lSteps = new System.Windows.Forms.Label();
            this.tbSteps = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bEvolve = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coeff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgwData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(688, 431);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgwData
            // 
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Average,
            this.StDev,
            this.Coeff});
            this.dgwData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwData.Location = new System.Drawing.Point(0, 0);
            this.dgwData.Name = "dgwData";
            this.dgwData.RowTemplate.Height = 24;
            this.dgwData.Size = new System.Drawing.Size(688, 395);
            this.dgwData.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lSteps);
            this.flowLayoutPanel1.Controls.Add(this.tbSteps);
            this.flowLayoutPanel1.Controls.Add(this.bClear);
            this.flowLayoutPanel1.Controls.Add(this.bEvolve);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(688, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lSteps
            // 
            this.lSteps.AutoSize = true;
            this.lSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.lSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSteps.Location = new System.Drawing.Point(3, 0);
            this.lSteps.Name = "lSteps";
            this.lSteps.Size = new System.Drawing.Size(52, 28);
            this.lSteps.TabIndex = 0;
            this.lSteps.Text = "Steps";
            // 
            // tbSteps
            // 
            this.tbSteps.Location = new System.Drawing.Point(61, 3);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Size = new System.Drawing.Size(53, 22);
            this.tbSteps.TabIndex = 1;
            this.tbSteps.Text = "10";
            this.tbSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bClear
            // 
            this.bClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bClear.Location = new System.Drawing.Point(120, 3);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 22);
            this.bClear.TabIndex = 2;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.Clear);
            // 
            // bEvolve
            // 
            this.bEvolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bEvolve.Location = new System.Drawing.Point(201, 3);
            this.bEvolve.Name = "bEvolve";
            this.bEvolve.Size = new System.Drawing.Size(75, 22);
            this.bEvolve.TabIndex = 3;
            this.bEvolve.Text = "Evolve";
            this.bEvolve.UseVisualStyleBackColor = true;
            this.bEvolve.Click += new System.EventHandler(this.Evolve);
            // 
            // Average
            // 
            this.Average.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Average.DefaultCellStyle = dataGridViewCellStyle1;
            this.Average.HeaderText = "Average";
            this.Average.Name = "Average";
            this.Average.ToolTipText = "Average value of the Gaussian";
            // 
            // StDev
            // 
            this.StDev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StDev.DefaultCellStyle = dataGridViewCellStyle2;
            this.StDev.HeaderText = "StDev";
            this.StDev.Name = "StDev";
            this.StDev.ToolTipText = "Standard deviation of the Gaussian";
            // 
            // Coeff
            // 
            this.Coeff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coeff.DefaultCellStyle = dataGridViewCellStyle3;
            this.Coeff.HeaderText = "Coeff";
            this.Coeff.Name = "Coeff";
            this.Coeff.ToolTipText = "Weight coefficient for the Gaussian linear combination";
            // 
            // fGC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 431);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGC";
            this.Text = "Gaussian Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lSteps;
        private System.Windows.Forms.TextBox tbSteps;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bEvolve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn StDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coeff;


    }
}

