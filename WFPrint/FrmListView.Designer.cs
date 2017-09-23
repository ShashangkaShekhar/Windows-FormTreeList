namespace WFPrint
{
    partial class FrmListView
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
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 25);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Expand All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // treeListView1
            // 
            this.treeListView1.AutoArrange = false;
            this.treeListView1.BackColor = System.Drawing.Color.White;
            this.treeListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeListView1.FullRowSelect = true;
            this.treeListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.treeListView1.Location = new System.Drawing.Point(8, 43);
            this.treeListView1.MultiSelect = false;
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.PersistentCheckBoxes = false;
            this.treeListView1.RowHeight = 25;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.ShowItemToolTips = true;
            this.treeListView1.ShowSortIndicators = false;
            this.treeListView1.Size = new System.Drawing.Size(326, 229);
            this.treeListView1.TabIndex = 3;
            this.treeListView1.TriggerCellOverEventsWhenOverHeader = false;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.UseHotControls = false;
            this.treeListView1.UseOverlays = false;
            this.treeListView1.UseWaitCursorWhenExpanding = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.treeListView1_FormatRow);
            this.treeListView1.SelectionChanged += new System.EventHandler(this.treeListView1_SelectionChanged);
            // 
            // FrmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 284);
            this.Controls.Add(this.treeListView1);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListView";
            this.Text = "FrmListView";
            this.Load += new System.EventHandler(this.FrmListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private BrightIdeasSoftware.TreeListView treeListView1;
    }
}