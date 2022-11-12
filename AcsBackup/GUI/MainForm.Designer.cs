﻿namespace AcsBackup.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.historyButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.restoreButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.mirrorOperationsQueueControl = new AcsBackup.GUI.MirrorOperationsQueueControl();
            this.label2 = new System.Windows.Forms.Label();
            this.queuePanel = new System.Windows.Forms.Panel();
            this.shutdownWhenDoneCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHddNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.queuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "data_copy.png");
            // 
            // historyButton
            // 
            this.historyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyButton.Enabled = false;
            this.historyButton.Image = global::AcsBackup.Properties.Resources.history;
            this.historyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.Location = new System.Drawing.Point(593, 149);
            this.historyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.historyButton.Name = "historyButton";
            this.historyButton.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.historyButton.Size = new System.Drawing.Size(134, 36);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "Tarihçe...";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.historyButton, "Display the history of the selected mirror task.");
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleButton.Enabled = false;
            this.scheduleButton.Image = global::AcsBackup.Properties.Resources.clock;
            this.scheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleButton.Location = new System.Drawing.Point(593, 209);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Padding = new System.Windows.Forms.Padding(11, 0, 14, 0);
            this.scheduleButton.Size = new System.Drawing.Size(134, 36);
            this.scheduleButton.TabIndex = 5;
            this.scheduleButton.Text = "Takvim...";
            this.scheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.scheduleButton, "Schedule the selected mirror task.");
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::AcsBackup.Properties.Resources.data_copy_add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(593, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(11, 0, 14, 0);
            this.addButton.Size = new System.Drawing.Size(134, 36);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Görev Ekle...";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.addButton, "Add a new mirror task.");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Enabled = false;
            this.editButton.Image = global::AcsBackup.Properties.Resources.data_copy;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(593, 44);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Padding = new System.Windows.Forms.Padding(11, 0, 37, 0);
            this.editButton.Size = new System.Drawing.Size(134, 36);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Düzenle";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.editButton, "Edit the selected mirror task.");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Image = global::AcsBackup.Properties.Resources.data_copy_delete;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(593, 89);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Padding = new System.Windows.Forms.Padding(11, 0, 26, 0);
            this.removeButton.Size = new System.Drawing.Size(134, 36);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Kaldır";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.removeButton, "Remove the selected mirror task.");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::AcsBackup.Properties.Resources.about32;
            this.pictureBox1.Location = new System.Drawing.Point(706, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 43);
            this.pictureBox1.TabIndex = 1003;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(16, 0, 74, 0);
            this.label1.Size = new System.Drawing.Size(758, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zirve Datasını yönetin, yedekleme ve geri yükleme işlemlerini gerçekleştirin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.historyButton);
            this.mainPanel.Controls.Add(this.scheduleButton);
            this.mainPanel.Controls.Add(this.listView1);
            this.mainPanel.Controls.Add(this.restoreButton);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Controls.Add(this.backupButton);
            this.mainPanel.Controls.Add(this.editButton);
            this.mainPanel.Controls.Add(this.removeButton);
            this.mainPanel.Location = new System.Drawing.Point(16, 190);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 332);
            this.mainPanel.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(585, 244);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kaynak";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hedef";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Son Başarılı Operasyon";
            this.columnHeader4.Width = 110;
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.Enabled = false;
            this.restoreButton.Image = global::AcsBackup.Properties.Resources.data_previous24;
            this.restoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restoreButton.Location = new System.Drawing.Point(426, 271);
            this.restoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Padding = new System.Windows.Forms.Padding(23, 0, 34, 0);
            this.restoreButton.Size = new System.Drawing.Size(160, 61);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.Text = "Geri Yükle";
            this.restoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backupButton.Enabled = false;
            this.backupButton.Image = global::AcsBackup.Properties.Resources.data_next24;
            this.backupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupButton.Location = new System.Drawing.Point(0, 271);
            this.backupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backupButton.Name = "backupButton";
            this.backupButton.Padding = new System.Windows.Forms.Padding(23, 0, 31, 0);
            this.backupButton.Size = new System.Drawing.Size(160, 61);
            this.backupButton.TabIndex = 6;
            this.backupButton.Text = "Yedek Al";
            this.backupButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // mirrorOperationsQueueControl
            // 
            this.mirrorOperationsQueueControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorOperationsQueueControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mirrorOperationsQueueControl.Location = new System.Drawing.Point(0, 24);
            this.mirrorOperationsQueueControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mirrorOperationsQueueControl.Name = "mirrorOperationsQueueControl";
            this.mirrorOperationsQueueControl.Size = new System.Drawing.Size(726, 145);
            this.mirrorOperationsQueueControl.TabIndex = 1;
            this.mirrorOperationsQueueControl.AllFinished += new System.EventHandler(this.mirrorOperationsQueueControl_AllFinished);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "İşlem Kuyruğu:";
            // 
            // queuePanel
            // 
            this.queuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queuePanel.Controls.Add(this.shutdownWhenDoneCheckBox);
            this.queuePanel.Controls.Add(this.mirrorOperationsQueueControl);
            this.queuePanel.Controls.Add(this.label2);
            this.queuePanel.Location = new System.Drawing.Point(16, 526);
            this.queuePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queuePanel.Name = "queuePanel";
            this.queuePanel.Size = new System.Drawing.Size(726, 199);
            this.queuePanel.TabIndex = 1;
            // 
            // shutdownWhenDoneCheckBox
            // 
            this.shutdownWhenDoneCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shutdownWhenDoneCheckBox.AutoSize = true;
            this.shutdownWhenDoneCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.shutdownWhenDoneCheckBox.Location = new System.Drawing.Point(0, 175);
            this.shutdownWhenDoneCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shutdownWhenDoneCheckBox.Name = "shutdownWhenDoneCheckBox";
            this.shutdownWhenDoneCheckBox.Size = new System.Drawing.Size(139, 24);
            this.shutdownWhenDoneCheckBox.TabIndex = 2;
            this.shutdownWhenDoneCheckBox.Text = "Bittiğinde Kapat";
            this.shutdownWhenDoneCheckBox.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1004;
            this.label3.Text = "Ürün Seri No:";
            // 
            // txtHddNo
            // 
            this.txtHddNo.AutoSize = true;
            this.txtHddNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHddNo.ForeColor = System.Drawing.Color.Red;
            this.txtHddNo.Location = new System.Drawing.Point(122, 100);
            this.txtHddNo.Name = "txtHddNo";
            this.txtHddNo.Size = new System.Drawing.Size(0, 25);
            this.txtHddNo.TabIndex = 1005;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 743);
            this.Controls.Add(this.txtHddNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queuePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 470);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcsBackup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.queuePanel.ResumeLayout(false);
            this.queuePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button backupButton;
		private System.Windows.Forms.Button restoreButton;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button scheduleButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button historyButton;
		private MirrorOperationsQueueControl mirrorOperationsQueueControl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel queuePanel;
		private System.Windows.Forms.CheckBox shutdownWhenDoneCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtHddNo;
    }
}