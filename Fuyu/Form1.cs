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

			//�E�C���h�E�Œ�
			this.FormBorderStyle = FormBorderStyle.None;

			//�X�N���[���̃T�C�Y
			int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
			int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;

			//�t�H�[���J�n�ʒu
			int appX = screenWidth - this.Width;
			int appY = screenHeight - this.Height;

			this.Location = new Point(appX, appY);

			//���x���̐e���s�N�`���ɕύX
			pictureBox1.Controls.Add(label1);
			pictureBox1.Controls.Add(label2);

		}
	}
}