using System.Media;

namespace Fuyu
{
	public partial class Form1 : Form
	{

		private Point mousePoint;
		private int sec1 = 0;
		private int sec2 = 0;
		private int c_cnt = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			//ウインドウ固定
			this.FormBorderStyle = FormBorderStyle.None;

			//スクリーンのサイズ
			int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
			int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;

			//フォーム開始位置
			int appX = screenWidth - this.Width;
			int appY = screenHeight - this.Height;

			this.Location = new Point(appX, appY);

			//ラベルの親をピクチャに変更
			pictureBox1.Controls.Add(label1);
			pictureBox1.Controls.Add(label2);

		}
	}
}