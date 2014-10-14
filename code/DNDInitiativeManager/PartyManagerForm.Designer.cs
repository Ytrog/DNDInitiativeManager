namespace DNDInitiativeManager
{
    partial class PartyManagerForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgParty = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.initiative = new DNDInitiativeManager.Initiative();
            ((System.ComponentModel.ISupportInitialize)(this.dgParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiative)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save party";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgParty
            // 
            this.dgParty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgParty.AutoGenerateColumns = false;
            this.dgParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.modifierDataGridViewTextBoxColumn});
            this.dgParty.DataSource = this.partyBindingSource;
            this.dgParty.Location = new System.Drawing.Point(13, 43);
            this.dgParty.Name = "dgParty";
            this.dgParty.Size = new System.Drawing.Size(654, 343);
            this.dgParty.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // modifierDataGridViewTextBoxColumn
            // 
            this.modifierDataGridViewTextBoxColumn.DataPropertyName = "Modifier";
            this.modifierDataGridViewTextBoxColumn.HeaderText = "Modifier";
            this.modifierDataGridViewTextBoxColumn.Name = "modifierDataGridViewTextBoxColumn";
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "Party";
            this.partyBindingSource.DataSource = this.initiative;
            // 
            // initiative
            // 
            this.initiative.DataSetName = "Initiative";
            this.initiative.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PartyManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 398);
            this.Controls.Add(this.dgParty);
            this.Controls.Add(this.btnSave);
            this.Name = "PartyManagerForm";
            this.Text = "Party Manager";
            this.Load += new System.EventHandler(this.PartyManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgParty;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private Initiative initiative;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierDataGridViewTextBoxColumn;
    }
}