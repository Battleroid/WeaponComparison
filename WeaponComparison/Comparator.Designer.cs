namespace WeaponComparison
{
    partial class Comparator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.controlsGroup = new System.Windows.Forms.GroupBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponSelectionB = new System.Windows.Forms.ComboBox();
            this.weaponSelectionA = new System.Windows.Forms.ComboBox();
            this.comparisonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.weaponGroupA = new System.Windows.Forms.GroupBox();
            this.weaponGroupB = new System.Windows.Forms.GroupBox();
            this.showChartBtn = new System.Windows.Forms.Button();
            this.weaponAAttributes = new System.Windows.Forms.ListBox();
            this.weaponBAttributes = new System.Windows.Forms.ListBox();
            this.controlsGroup.SuspendLayout();
            this.comparisonTableLayout.SuspendLayout();
            this.weaponGroupA.SuspendLayout();
            this.weaponGroupB.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsGroup
            // 
            this.controlsGroup.Controls.Add(this.showChartBtn);
            this.controlsGroup.Controls.Add(this.compareBtn);
            this.controlsGroup.Controls.Add(this.label2);
            this.controlsGroup.Controls.Add(this.label1);
            this.controlsGroup.Controls.Add(this.weaponSelectionB);
            this.controlsGroup.Controls.Add(this.weaponSelectionA);
            this.controlsGroup.Location = new System.Drawing.Point(16, 15);
            this.controlsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.controlsGroup.Size = new System.Drawing.Size(876, 99);
            this.controlsGroup.TabIndex = 0;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Controls";
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(210, 26);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(75, 54);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weapon 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weapon 1";
            // 
            // weaponSelectionB
            // 
            this.weaponSelectionB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponSelectionB.FormattingEnabled = true;
            this.weaponSelectionB.Location = new System.Drawing.Point(83, 56);
            this.weaponSelectionB.Name = "weaponSelectionB";
            this.weaponSelectionB.Size = new System.Drawing.Size(121, 24);
            this.weaponSelectionB.TabIndex = 1;
            // 
            // weaponSelectionA
            // 
            this.weaponSelectionA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponSelectionA.FormattingEnabled = true;
            this.weaponSelectionA.Location = new System.Drawing.Point(83, 26);
            this.weaponSelectionA.Name = "weaponSelectionA";
            this.weaponSelectionA.Size = new System.Drawing.Size(121, 24);
            this.weaponSelectionA.TabIndex = 0;
            // 
            // comparisonTableLayout
            // 
            this.comparisonTableLayout.ColumnCount = 2;
            this.comparisonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comparisonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comparisonTableLayout.Controls.Add(this.weaponGroupA, 0, 0);
            this.comparisonTableLayout.Controls.Add(this.weaponGroupB, 1, 0);
            this.comparisonTableLayout.Location = new System.Drawing.Point(16, 121);
            this.comparisonTableLayout.Name = "comparisonTableLayout";
            this.comparisonTableLayout.RowCount = 1;
            this.comparisonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comparisonTableLayout.Size = new System.Drawing.Size(876, 511);
            this.comparisonTableLayout.TabIndex = 4;
            // 
            // weaponGroupA
            // 
            this.weaponGroupA.Controls.Add(this.weaponAAttributes);
            this.weaponGroupA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weaponGroupA.Location = new System.Drawing.Point(3, 3);
            this.weaponGroupA.Name = "weaponGroupA";
            this.weaponGroupA.Size = new System.Drawing.Size(432, 505);
            this.weaponGroupA.TabIndex = 0;
            this.weaponGroupA.TabStop = false;
            this.weaponGroupA.Text = "Weapon 1";
            // 
            // weaponGroupB
            // 
            this.weaponGroupB.Controls.Add(this.weaponBAttributes);
            this.weaponGroupB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weaponGroupB.Location = new System.Drawing.Point(441, 3);
            this.weaponGroupB.Name = "weaponGroupB";
            this.weaponGroupB.Size = new System.Drawing.Size(432, 505);
            this.weaponGroupB.TabIndex = 1;
            this.weaponGroupB.TabStop = false;
            this.weaponGroupB.Text = "Weapon 2";
            // 
            // showChartBtn
            // 
            this.showChartBtn.Location = new System.Drawing.Point(291, 26);
            this.showChartBtn.Name = "showChartBtn";
            this.showChartBtn.Size = new System.Drawing.Size(166, 54);
            this.showChartBtn.TabIndex = 5;
            this.showChartBtn.Text = "Show Damage Chart";
            this.showChartBtn.UseVisualStyleBackColor = true;
            this.showChartBtn.Click += new System.EventHandler(this.showChartBtn_Click);
            // 
            // weaponAAttributes
            // 
            this.weaponAAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponAAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponAAttributes.FormattingEnabled = true;
            this.weaponAAttributes.ItemHeight = 20;
            this.weaponAAttributes.Location = new System.Drawing.Point(7, 28);
            this.weaponAAttributes.Name = "weaponAAttributes";
            this.weaponAAttributes.Size = new System.Drawing.Size(419, 462);
            this.weaponAAttributes.TabIndex = 1;
            // 
            // weaponBAttributes
            // 
            this.weaponBAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponBAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponBAttributes.FormattingEnabled = true;
            this.weaponBAttributes.ItemHeight = 20;
            this.weaponBAttributes.Location = new System.Drawing.Point(7, 28);
            this.weaponBAttributes.Name = "weaponBAttributes";
            this.weaponBAttributes.Size = new System.Drawing.Size(419, 462);
            this.weaponBAttributes.TabIndex = 2;
            // 
            // Comparator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 644);
            this.Controls.Add(this.comparisonTableLayout);
            this.Controls.Add(this.controlsGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Comparator";
            this.Text = "Compare";
            this.Load += new System.EventHandler(this.Comparator_Load);
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            this.comparisonTableLayout.ResumeLayout(false);
            this.weaponGroupA.ResumeLayout(false);
            this.weaponGroupB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsGroup;
        private System.Windows.Forms.ComboBox weaponSelectionB;
        private System.Windows.Forms.ComboBox weaponSelectionA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel comparisonTableLayout;
        private System.Windows.Forms.GroupBox weaponGroupA;
        private System.Windows.Forms.GroupBox weaponGroupB;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Button showChartBtn;
        private System.Windows.Forms.ListBox weaponAAttributes;
        private System.Windows.Forms.ListBox weaponBAttributes;



    }
}

