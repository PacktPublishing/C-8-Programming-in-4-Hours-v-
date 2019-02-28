namespace IssueTrackerApp
{
    partial class frmIssueTracker
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
            this.lblIssueID = new System.Windows.Forms.Label();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.txtIssueTitle = new System.Windows.Forms.TextBox();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.txtIssueDesc = new System.Windows.Forms.TextBox();
            this.lblIssueDescription = new System.Windows.Forms.Label();
            this.lblIssuePriority = new System.Windows.Forms.Label();
            this.cmbPriorityList = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblIssueType = new System.Windows.Forms.Label();
            this.grpAddEditIssue = new System.Windows.Forms.GroupBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgrdIssues = new System.Windows.Forms.DataGridView();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuePriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllIssues = new System.Windows.Forms.Label();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpAddEditIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdIssues)).BeginInit();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueID.Location = new System.Drawing.Point(78, 23);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(54, 15);
            this.lblIssueID.TabIndex = 0;
            this.lblIssueID.Text = "Issue ID:";
            // 
            // txtIssueID
            // 
            this.txtIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueID.ForeColor = System.Drawing.Color.Navy;
            this.txtIssueID.Location = new System.Drawing.Point(141, 23);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(296, 20);
            this.txtIssueID.TabIndex = 1;
            // 
            // txtIssueTitle
            // 
            this.txtIssueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueTitle.ForeColor = System.Drawing.Color.Navy;
            this.txtIssueTitle.Location = new System.Drawing.Point(141, 49);
            this.txtIssueTitle.Name = "txtIssueTitle";
            this.txtIssueTitle.Size = new System.Drawing.Size(296, 20);
            this.txtIssueTitle.TabIndex = 3;
            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueTitle.Location = new System.Drawing.Point(67, 49);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(65, 15);
            this.lblIssueTitle.TabIndex = 2;
            this.lblIssueTitle.Text = "Issue Title:";
            // 
            // txtIssueDesc
            // 
            this.txtIssueDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueDesc.ForeColor = System.Drawing.Color.Navy;
            this.txtIssueDesc.Location = new System.Drawing.Point(141, 75);
            this.txtIssueDesc.Multiline = true;
            this.txtIssueDesc.Name = "txtIssueDesc";
            this.txtIssueDesc.Size = new System.Drawing.Size(296, 97);
            this.txtIssueDesc.TabIndex = 5;
            // 
            // lblIssueDescription
            // 
            this.lblIssueDescription.AutoSize = true;
            this.lblIssueDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDescription.Location = new System.Drawing.Point(28, 75);
            this.lblIssueDescription.Name = "lblIssueDescription";
            this.lblIssueDescription.Size = new System.Drawing.Size(104, 15);
            this.lblIssueDescription.TabIndex = 4;
            this.lblIssueDescription.Text = "Issue Description:";
            // 
            // lblIssuePriority
            // 
            this.lblIssuePriority.AutoSize = true;
            this.lblIssuePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuePriority.Location = new System.Drawing.Point(85, 179);
            this.lblIssuePriority.Name = "lblIssuePriority";
            this.lblIssuePriority.Size = new System.Drawing.Size(47, 15);
            this.lblIssuePriority.TabIndex = 6;
            this.lblIssuePriority.Text = "Priority:";
            // 
            // cmbPriorityList
            // 
            this.cmbPriorityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriorityList.ForeColor = System.Drawing.Color.Navy;
            this.cmbPriorityList.FormattingEnabled = true;
            this.cmbPriorityList.Location = new System.Drawing.Point(141, 179);
            this.cmbPriorityList.Name = "cmbPriorityList";
            this.cmbPriorityList.Size = new System.Drawing.Size(135, 21);
            this.cmbPriorityList.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Navy;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(141, 206);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(135, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Navy;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(141, 233);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(135, 21);
            this.cmbType.TabIndex = 11;
            // 
            // lblIssueType
            // 
            this.lblIssueType.AutoSize = true;
            this.lblIssueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueType.Location = new System.Drawing.Point(96, 233);
            this.lblIssueType.Name = "lblIssueType";
            this.lblIssueType.Size = new System.Drawing.Size(36, 15);
            this.lblIssueType.TabIndex = 10;
            this.lblIssueType.Text = "Type:";
            // 
            // grpAddEditIssue
            // 
            this.grpAddEditIssue.Controls.Add(this.btnResolve);
            this.grpAddEditIssue.Controls.Add(this.btnSave);
            this.grpAddEditIssue.Controls.Add(this.btnNew);
            this.grpAddEditIssue.Controls.Add(this.txtIssueDesc);
            this.grpAddEditIssue.Controls.Add(this.cmbType);
            this.grpAddEditIssue.Controls.Add(this.lblIssueID);
            this.grpAddEditIssue.Controls.Add(this.lblIssueType);
            this.grpAddEditIssue.Controls.Add(this.txtIssueID);
            this.grpAddEditIssue.Controls.Add(this.cmbStatus);
            this.grpAddEditIssue.Controls.Add(this.lblIssueTitle);
            this.grpAddEditIssue.Controls.Add(this.label1);
            this.grpAddEditIssue.Controls.Add(this.txtIssueTitle);
            this.grpAddEditIssue.Controls.Add(this.cmbPriorityList);
            this.grpAddEditIssue.Controls.Add(this.lblIssueDescription);
            this.grpAddEditIssue.Controls.Add(this.lblIssuePriority);
            this.grpAddEditIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddEditIssue.Location = new System.Drawing.Point(12, 12);
            this.grpAddEditIssue.Name = "grpAddEditIssue";
            this.grpAddEditIssue.Size = new System.Drawing.Size(465, 307);
            this.grpAddEditIssue.TabIndex = 12;
            this.grpAddEditIssue.TabStop = false;
            this.grpAddEditIssue.Text = "Add/Edit Issue";
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(303, 260);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 14;
            this.btnResolve.Text = "Resolve Issue";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(141, 260);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgrdIssues
            // 
            this.dgrdIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueID,
            this.IssueTitle,
            this.IssueDescription,
            this.IssuePriority,
            this.IssueStatus});
            this.dgrdIssues.Location = new System.Drawing.Point(12, 363);
            this.dgrdIssues.MultiSelect = false;
            this.dgrdIssues.Name = "dgrdIssues";
            this.dgrdIssues.ReadOnly = true;
            this.dgrdIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdIssues.Size = new System.Drawing.Size(776, 405);
            this.dgrdIssues.TabIndex = 13;
            this.dgrdIssues.SelectionChanged += new System.EventHandler(this.dgrdIssues_SelectionChanged);
            // 
            // IssueID
            // 
            this.IssueID.DataPropertyName = "IssueID";
            this.IssueID.HeaderText = "Issue ID";
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            // 
            // IssueTitle
            // 
            this.IssueTitle.DataPropertyName = "IssueTitle";
            this.IssueTitle.HeaderText = "Title";
            this.IssueTitle.Name = "IssueTitle";
            this.IssueTitle.ReadOnly = true;
            this.IssueTitle.Width = 150;
            // 
            // IssueDescription
            // 
            this.IssueDescription.DataPropertyName = "IssueDescription";
            this.IssueDescription.HeaderText = "Description";
            this.IssueDescription.Name = "IssueDescription";
            this.IssueDescription.ReadOnly = true;
            this.IssueDescription.Width = 220;
            // 
            // IssuePriority
            // 
            this.IssuePriority.DataPropertyName = "IssuePriority";
            this.IssuePriority.HeaderText = "Priority";
            this.IssuePriority.Name = "IssuePriority";
            this.IssuePriority.ReadOnly = true;
            this.IssuePriority.Width = 120;
            // 
            // IssueStatus
            // 
            this.IssueStatus.DataPropertyName = "IssueStatus";
            this.IssueStatus.HeaderText = "Status";
            this.IssueStatus.Name = "IssueStatus";
            this.IssueStatus.ReadOnly = true;
            this.IssueStatus.Width = 120;
            // 
            // lblAllIssues
            // 
            this.lblAllIssues.AutoSize = true;
            this.lblAllIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllIssues.Location = new System.Drawing.Point(12, 333);
            this.lblAllIssues.Name = "lblAllIssues";
            this.lblAllIssues.Size = new System.Drawing.Size(72, 15);
            this.lblAllIssues.TabIndex = 14;
            this.lblAllIssues.Text = "All Issues:";
            // 
            // lstLogs
            // 
            this.lstLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(6, 19);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(282, 277);
            this.lstLogs.TabIndex = 15;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.lstLogs);
            this.grpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLog.Location = new System.Drawing.Point(494, 12);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(294, 307);
            this.grpLog.TabIndex = 16;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log Detail";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(713, 333);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmIssueTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.lblAllIssues);
            this.Controls.Add(this.dgrdIssues);
            this.Controls.Add(this.grpAddEditIssue);
            this.Name = "frmIssueTracker";
            this.Text = "Issue Tracker App";
            this.Load += new System.EventHandler(this.frmIssueTracker_Load);
            this.grpAddEditIssue.ResumeLayout(false);
            this.grpAddEditIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdIssues)).EndInit();
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.TextBox txtIssueTitle;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.TextBox txtIssueDesc;
        private System.Windows.Forms.Label lblIssueDescription;
        private System.Windows.Forms.Label lblIssuePriority;
        private System.Windows.Forms.ComboBox cmbPriorityList;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.GroupBox grpAddEditIssue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgrdIssues;
        private System.Windows.Forms.Label lblAllIssues;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuePriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueStatus;
        private System.Windows.Forms.Button btnResolve;
    }
}

