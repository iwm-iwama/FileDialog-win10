using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iwm_FileDialog
{
	public partial class Form1 : Form
	{
		private const string VER = "FileDialog iwm20201115";
		private const string NL = "\r\n";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();

		private static bool EXEC = true;
		private static bool MULTI_SELECT = true;
		private static bool FULL_PATH = true;

		private const string HELP_TEXT =
			"＜オプション＞" + NL +
			" -sf | -singlefile" + NL +
			"   １ファイルのみ選択" + NL +
			" -no | -nameonly" + NL +
			"   ファイル名のみ抽出"
		;

		private TextBox TB = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Text = VER;

			// [0] は Program なので読み飛ばす
			for (int _i1 = 1; _i1 < ARGS.Length; _i1++)
			{
				string _s1 = ARGS[_i1];

				if (Regex.IsMatch(_s1, @"^\-h$") || Regex.IsMatch(_s1, @"^\-help$"))
				{
					EXEC = false;
				}
				else if (Regex.IsMatch(_s1, @"^\-sf$") || Regex.IsMatch(_s1, @"^\-singlefile$"))
				{
					MULTI_SELECT = false;
				}
				else if (Regex.IsMatch(_s1, @"^\-no$") || Regex.IsMatch(_s1, @"^\-nameonly$"))
				{
					FULL_PATH = false;
				}
			}

			if (EXEC)
			{
				Opacity = 0.0;
				Pub.Rtn = RtnFileSelect();
				Application.Exit();
			}
			else
			{
				Opacity = 1.0;
				TbText.Text = HELP_TEXT;
			}
		}

		private string RtnFileSelect()
		{
			OpenFileDialog ofd = openFileDialog1;

			ofd.InitialDirectory = Environment.CurrentDirectory;
			ofd.Multiselect = MULTI_SELECT;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				string sFn = "";

				foreach (string _s1 in ofd.FileNames)
				{
					string s1 = _s1;

					if (!FULL_PATH)
					{
						s1 = Path.GetFileName(_s1);
					}

					sFn += "\"" + s1 + "\"\t";
				}

				return sFn.TrimEnd();
			}

			return "";
		}

		private void OpenFileDialog1_HelpRequest(object sender, EventArgs e)
		{
			_ = MessageBox.Show(HELP_TEXT, "コマンドライン");
		}

		private void TbText_MouseUp(object sender, MouseEventArgs e)
		{
			CmsTextSelect_Open(e, TbText);
		}

		private void CmsTextSelect_Open(MouseEventArgs e, TextBox Tb)
		{
			if (Tb.SelectionLength > 0 && e.Button == MouseButtons.Left)
			{
				TB = Tb;
				CmsTextSelect.Show(Cursor.Position);
			}
		}

		private void CmsTextSelect_コピー_Click(object sender, EventArgs e)
		{
			TB.Copy();
		}
	}

	public class Pub
	{
		public static string Rtn = "";
	}

	public class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			Console.Write(Pub.Rtn);
		}
	}
}
