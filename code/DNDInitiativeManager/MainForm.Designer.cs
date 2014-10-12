namespace DNDInitiativeManager
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.newSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgInitiative = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initiativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initiativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.initiative = new DNDInitiativeManager.Initiative();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInitiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiative)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSheetToolStripMenuItem,
            this.partyToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(708, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // newSheetToolStripMenuItem
            // 
            this.newSheetToolStripMenuItem.Name = "newSheetToolStripMenuItem";
            this.newSheetToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.newSheetToolStripMenuItem.Text = "New sheet";
            this.newSheetToolStripMenuItem.Click += new System.EventHandler(this.newSheetToolStripMenuItem_Click);
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.partyToolStripMenuItem.Text = "Party";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dgInitiative
            // 
            this.dgInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInitiative.AutoGenerateColumns = false;
            this.dgInitiative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInitiative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.initiativeDataGridViewTextBoxColumn,
            this.modifierDataGridViewTextBoxColumn});
            this.dgInitiative.DataSource = this.initiativeBindingSource;
            this.dgInitiative.Location = new System.Drawing.Point(13, 28);
            this.dgInitiative.Name = "dgInitiative";
            this.dgInitiative.Size = new System.Drawing.Size(683, 386);
            this.dgInitiative.TabIndex = 1;
            this.dgInitiative.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgInitiative_UserDeletingRow);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            dataGridViewCellStyle2.NullValue = "NPC";
            this.typeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "PartyMember",
            "NPC"});
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // initiativeDataGridViewTextBoxColumn
            // 
            this.initiativeDataGridViewTextBoxColumn.DataPropertyName = "Initiative";
            this.initiativeDataGridViewTextBoxColumn.HeaderText = "Initiative";
            this.initiativeDataGridViewTextBoxColumn.Name = "initiativeDataGridViewTextBoxColumn";
            // 
            // modifierDataGridViewTextBoxColumn
            // 
            this.modifierDataGridViewTextBoxColumn.DataPropertyName = "Modifier";
            this.modifierDataGridViewTextBoxColumn.HeaderText = "Modifier";
            this.modifierDataGridViewTextBoxColumn.Name = "modifierDataGridViewTextBoxColumn";
            // 
            // initiativeBindingSource
            // 
            this.initiativeBindingSource.DataMember = "Initiative";
            this.initiativeBindingSource.DataSource = this.initiative;
            // 
            // initiative
            // 
            this.initiative.DataSetName = "Initiative";
            this.initiative.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 426);
            this.Controls.Add(this.dgInitiative);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "DND Initiative Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInitiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiative)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgInitiative;
        private Initiative initiative;
        private System.Windows.Forms.BindingSource initiativeBindingSource;
        private System.Windows.Forms.ToolStripMenuItem newSheetToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initiativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

