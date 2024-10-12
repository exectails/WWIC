namespace WWIC
{
	public partial class FrmMain : Form
	{
		public FrmMain(string[] args)
		{
			this.InitializeComponent();

			if (args.Length != 0)
				this.ReadFile(args[0]);
		}

		private void LblDrop_Click(object sender, EventArgs e)
		{
			using var dialog = new OpenFileDialog();
			dialog.Filter = "Executable files (*.exe)|*.exe";

			if (dialog.ShowDialog() != DialogResult.OK)
				return;

			this.ReadFile(dialog.FileName);
		}

		private void FrmMain_DragEnter(object sender, DragEventArgs e)
		{
			if (e?.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void FrmMain_DragDrop(object sender, DragEventArgs e)
		{
			if (e?.Data == null || !e.Data.GetDataPresent(DataFormats.FileDrop))
				return;

			var files = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (files.Length == 0)
				return;

			this.ReadFile(files[0]);
		}

		private void ReadFile(string filePath)
		{
			try
			{
				var dt = PEHeaderReader.GetTimeDateStamp(filePath);
				this.TxtDate.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
			}
			catch
			{
				this.TxtDate.Text = "Invalid file";
			}
		}
	}
}
