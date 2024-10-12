namespace WWIC
{
	partial class FrmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.LblDate = new Label();
			this.LblDrop = new Label();
			this.TxtDate = new TextBox();
			this.SuspendLayout();
			// 
			// LblDate
			// 
			this.LblDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.LblDate.AutoSize = true;
			this.LblDate.Location = new Point(20, 110);
			this.LblDate.Name = "LblDate";
			this.LblDate.Size = new Size(103, 15);
			this.LblDate.TabIndex = 0;
			this.LblDate.Text = "Compilation Date:";
			this.LblDate.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LblDrop
			// 
			this.LblDrop.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.LblDrop.ForeColor = Color.Gray;
			this.LblDrop.Location = new Point(0, 0);
			this.LblDrop.Name = "LblDrop";
			this.LblDrop.Size = new Size(269, 110);
			this.LblDrop.TabIndex = 1;
			this.LblDrop.Text = "Drop EXE here";
			this.LblDrop.TextAlign = ContentAlignment.MiddleCenter;
			this.LblDrop.Click += this.LblDrop_Click;
			// 
			// TxtDate
			// 
			this.TxtDate.BackColor = SystemColors.Control;
			this.TxtDate.BorderStyle = BorderStyle.None;
			this.TxtDate.Location = new Point(129, 111);
			this.TxtDate.Name = "TxtDate";
			this.TxtDate.ReadOnly = true;
			this.TxtDate.Size = new Size(111, 16);
			this.TxtDate.TabIndex = 2;
			this.TxtDate.TabStop = false;
			this.TxtDate.Text = "0000-00-00 00:00";
			this.TxtDate.TextAlign = HorizontalAlignment.Right;
			// 
			// FrmMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(269, 136);
			this.Controls.Add(this.LblDate);
			this.Controls.Add(this.TxtDate);
			this.Controls.Add(this.LblDrop);
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "WWIC";
			this.DragDrop += this.FrmMain_DragDrop;
			this.DragEnter += this.FrmMain_DragEnter;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private Label LblDate;
		private Label LblDrop;
		private TextBox TxtDate;
	}
}
