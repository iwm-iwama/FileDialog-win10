namespace iwm_FileDialog
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.TbText = new System.Windows.Forms.TextBox();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTextSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTextSelect_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.ShowHelp = true;
			this.openFileDialog1.HelpRequest += new System.EventHandler(this.OpenFileDialog1_HelpRequest);
			// 
			// TbText
			// 
			this.TbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbText.BackColor = System.Drawing.Color.White;
			this.TbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbText.ContextMenuStrip = this.CmsNull;
			this.TbText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbText.ForeColor = System.Drawing.Color.Black;
			this.TbText.Location = new System.Drawing.Point(0, 0);
			this.TbText.Margin = new System.Windows.Forms.Padding(0);
			this.TbText.Multiline = true;
			this.TbText.Name = "TbText";
			this.TbText.ReadOnly = true;
			this.TbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbText.Size = new System.Drawing.Size(303, 160);
			this.TbText.TabIndex = 0;
			this.TbText.TabStop = false;
			this.TbText.WordWrap = false;
			this.TbText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbText_MouseUp);
			// 
			// CmsNull
			// 
			this.CmsNull.Name = "CmsNull";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// CmsTextSelect
			// 
			this.CmsTextSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsTextSelect_コピー});
			this.CmsTextSelect.Name = "CmsResult";
			this.CmsTextSelect.Size = new System.Drawing.Size(100, 26);
			// 
			// CmsTextSelect_コピー
			// 
			this.CmsTextSelect_コピー.Name = "CmsTextSelect_コピー";
			this.CmsTextSelect_コピー.Size = new System.Drawing.Size(99, 22);
			this.CmsTextSelect_コピー.Text = "コピー";
			this.CmsTextSelect_コピー.Click += new System.EventHandler(this.CmsTextSelect_コピー_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(304, 161);
			this.Controls.Add(this.TbText);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 800);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(320, 200);
			this.Name = "Form1";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ダミータイトル";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.CmsTextSelect.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox TbText;
		private System.Windows.Forms.ContextMenuStrip CmsTextSelect;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_コピー;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
	}
}

