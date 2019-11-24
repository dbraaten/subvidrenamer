namespace SubVidRenamer
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
			this.textFolder = new System.Windows.Forms.TextBox();
			this.textExtensions = new System.Windows.Forms.TextBox();
			this.listBoxFinal = new System.Windows.Forms.ListBox();
			this.checkSetNames = new System.Windows.Forms.CheckBox();
			this.listBoxSource = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.buttonRename = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.scrollLog = new System.Windows.Forms.TextBox();
			this.checkRemoveFolders = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textFolder
			// 
			this.textFolder.Location = new System.Drawing.Point(147, 35);
			this.textFolder.Name = "textFolder";
			this.textFolder.Size = new System.Drawing.Size(278, 20);
			this.textFolder.TabIndex = 0;
			this.textFolder.TextChanged += new System.EventHandler(this.OnFolderChanged);
			// 
			// textExtensions
			// 
			this.textExtensions.Location = new System.Drawing.Point(147, 61);
			this.textExtensions.Name = "textExtensions";
			this.textExtensions.Size = new System.Drawing.Size(278, 20);
			this.textExtensions.TabIndex = 1;
			this.textExtensions.TextChanged += new System.EventHandler(this.OnExtensionsChanged);
			// 
			// listBoxFinal
			// 
			this.listBoxFinal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxFinal.FormattingEnabled = true;
			this.listBoxFinal.Location = new System.Drawing.Point(447, 3);
			this.listBoxFinal.Name = "listBoxFinal";
			this.listBoxFinal.Size = new System.Drawing.Size(438, 310);
			this.listBoxFinal.TabIndex = 2;
			// 
			// checkSetNames
			// 
			this.checkSetNames.AutoSize = true;
			this.checkSetNames.Location = new System.Drawing.Point(449, 61);
			this.checkSetNames.Name = "checkSetNames";
			this.checkSetNames.Size = new System.Drawing.Size(229, 17);
			this.checkSetNames.TabIndex = 3;
			this.checkSetNames.Text = "Set names to immediate parent folder name";
			this.checkSetNames.UseVisualStyleBackColor = true;
			this.checkSetNames.CheckedChanged += new System.EventHandler(this.OnCheckedSetNames);
			// 
			// listBoxSource
			// 
			this.listBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxSource.FormattingEnabled = true;
			this.listBoxSource.Location = new System.Drawing.Point(3, 3);
			this.listBoxSource.Name = "listBoxSource";
			this.listBoxSource.Size = new System.Drawing.Size(438, 310);
			this.listBoxSource.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Folder";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Extensions";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(449, 33);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(78, 22);
			this.buttonBrowse.TabIndex = 7;
			this.buttonBrowse.Text = "Browse...";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.OnClickedBrowse);
			// 
			// buttonRename
			// 
			this.buttonRename.Location = new System.Drawing.Point(562, 32);
			this.buttonRename.Name = "buttonRename";
			this.buttonRename.Size = new System.Drawing.Size(77, 22);
			this.buttonRename.TabIndex = 8;
			this.buttonRename.Text = "Rename";
			this.buttonRename.UseVisualStyleBackColor = true;
			this.buttonRename.Click += new System.EventHandler(this.OnClickedRename);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.checkRemoveFolders);
			this.splitContainer1.Panel1.Controls.Add(this.textFolder);
			this.splitContainer1.Panel1.Controls.Add(this.buttonRename);
			this.splitContainer1.Panel1.Controls.Add(this.textExtensions);
			this.splitContainer1.Panel1.Controls.Add(this.buttonBrowse);
			this.splitContainer1.Panel1.Controls.Add(this.checkSetNames);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(888, 520);
			this.splitContainer1.SplitterDistance = 115;
			this.splitContainer1.TabIndex = 9;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.listBoxFinal, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBoxSource, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.scrollLog, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 401);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// scrollLog
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.scrollLog, 2);
			this.scrollLog.Location = new System.Drawing.Point(3, 319);
			this.scrollLog.Multiline = true;
			this.scrollLog.Name = "scrollLog";
			this.scrollLog.Size = new System.Drawing.Size(882, 78);
			this.scrollLog.TabIndex = 5;
			// 
			// checkRemoveFolders
			// 
			this.checkRemoveFolders.AutoSize = true;
			this.checkRemoveFolders.Location = new System.Drawing.Point(449, 84);
			this.checkRemoveFolders.Name = "checkRemoveFolders";
			this.checkRemoveFolders.Size = new System.Drawing.Size(222, 17);
			this.checkRemoveFolders.TabIndex = 9;
			this.checkRemoveFolders.Text = "Remove folder after Rename (to Recycle)";
			this.checkRemoveFolders.UseVisualStyleBackColor = true;
			this.checkRemoveFolders.CheckedChanged += new System.EventHandler(this.OnCheckedRemoveFolder);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 520);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "SubVid Renamer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
			this.Load += new System.EventHandler(this.OnLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textFolder;
		private System.Windows.Forms.TextBox textExtensions;
		private System.Windows.Forms.ListBox listBoxFinal;
		private System.Windows.Forms.CheckBox checkSetNames;
		private System.Windows.Forms.ListBox listBoxSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Button buttonRename;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox scrollLog;
		private System.Windows.Forms.CheckBox checkRemoveFolders;
	}
}

