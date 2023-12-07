using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using log4net;
using log4net.Config;
namespace ver._2
{

    public partial class Form2 : Form
    {
        static String SqlConn = "Server=localhost;Port=3306; Database=ver2;Uid=root;Pwd=1234";
        MySqlConnection conn = new MySqlConnection(SqlConn);
        MySqlCommand cm;
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 텍스트박스에서 텍스트 가져오기
            string textToSave = form1.login_text.Text;
            DateTime currentDateTime = DateTime.Now;
            string logEntry = $"로그인 시간: {currentDateTime}\t 로그아웃 아이디:{textToSave}";
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
            if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form1 = new Form1();
                form1.Visible = true;
                this.Close();

            }
            else
            {

            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            cm = new MySqlCommand("insert into stock (KIND,quantity,placePurchase,date) value (@KIND,@quantity,@placePurchase,@date)",conn);
            cm.Parameters.AddWithValue("@KIND", textBox1.Text);
            cm.Parameters.AddWithValue("@quantity", textBox2.Text);
            cm.Parameters.AddWithValue("@placePurchase", textBox3.Text);
            cm.Parameters.AddWithValue("@date", textBox4.Text);
            cm.ExecuteNonQuery();
            conn.Close();
            try
            {
                if (MessageBox.Show("입고를 하시겠습니까 ", "입고", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("입고가 완료되었습니다");
                }
                else
                {
                    MessageBox.Show("입고가 취소되었습니다");
                }
            }
            catch (DivideByZeroException textBox1)
            {
                MessageBox.Show("값을 넣어주세요");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
