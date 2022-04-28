using WMPLib;

namespace Fuyu
{
	public partial class Form1 : Form
	{

		private string[] url = new string[3];
		private string[] text = new string[3];

		// メディアプレーヤークラスのインスタンスを作成する
		WindowsMediaPlayer _mediaPlayer = new WindowsMediaPlayer();

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

			//音声設定
			url[0] = "fuyuko_04.wav";
			url[1] = "fuyuko_05.wav";
			url[2] = "fuyuko_06.wav";

			//テキスト設定
			text[0] = "プロデューサーさん！お仕事お疲れ様です❤\n──な～んて、ちょっとは癒やされた？";
			text[1] = "さぁて！今日もふゆの可愛さで、みんなメロメロにしてやるわ！";
			text[2] = "ふゆは、誰もがひれ伏すトップアイドルになってやんの！それまで、一秒だって止まってらんないんだから！";
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Random rand = new System.Random();
			int Random = rand.Next(0, 3);
			label2.Text = text[Random];
			_mediaPlayer.URL = @url[Random];// mp3も使用可能
			_mediaPlayer.controls.play();
		}
	}
}