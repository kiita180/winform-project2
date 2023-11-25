using Google.Protobuf.WellKnownTypes;
using log4net;
using log4net.Config;

namespace ver._2
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Form1));
        public Form1()
        {

            InitializeComponent();
            XmlConfigurator.Configure(new FileInfo("log4net.xml"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_text.Text == "" && paw_text.Text == "")
            {
                MessageBox.Show("���̵�� ��й�ȣ�� �Է����ּ���");
            }
            else if (login_text.Text == "root" && paw_text.Text == "")
            {
                MessageBox.Show("��й�ȣ�� �Է� �� �ּ���");
            }
            else if (login_text.Text == "" && paw_text.Text == "ehdrb123")
            {
                MessageBox.Show("���̵� �Է� �� �ּ���");
            }
            else
            {
                Visible = false;
                Form2 form2 = new Form2(this);
                form2.Visible = true;

                form2.nickname_rabel.Text = login_text.Text;
                MessageBox.Show(login_text.Text + "님 로그인 환영합니다");


                // 텍스트박스에서 텍스트 가져오기
                string textToSave = login_text.Text;
                DateTime currentDateTime = DateTime.Now;
                string logEntry = $"로그인 시간: {currentDateTime}\t 로그인 아이디:{textToSave}";
                // 저장 대화상자 열기
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.FileName = "log.txt"; // 파일 이름 설정

                // 저장할 파일 경로 설정
                string filePath = @"C:\Users\ehdrb\source\repos\winformProject2-master\winformProject2-master\ver.2\bin\Debug\log\log.txt";

                if (File.Exists(filePath))
                {
                    // 기존 파일의 내용 읽기
                    string existingContent = File.ReadAllText(filePath);

                    // 기존 내용과 새로운 내용 합치기
                    string combinedContent = logEntry + "\n" + existingContent;

                    // 텍스트 파일로 저장
                    File.WriteAllText(filePath, combinedContent);
                }
                else
                {
                    // 파일이 없을 경우 새로 생성하여 텍스트 저장
                    File.WriteAllText(filePath, logEntry);
                }


            }
        }

        private void login_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
