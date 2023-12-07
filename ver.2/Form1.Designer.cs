namespace ver._2
{
    partial class Form1
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
            label1 = new Label();
            login_text = new TextBox();
            paw_text = new TextBox();
            label2 = new Label();
            label3 = new Label();
            login_butten = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 46);
            label1.TabIndex = 0;
            label1.Text = "로그인";
            // 
            // login_text
            // 
            login_text.Location = new Point(146, 226);
            login_text.Margin = new Padding(2);
            login_text.Name = "login_text";
            login_text.Size = new Size(199, 23);
            login_text.TabIndex = 1;
            login_text.TextChanged += login_text_TextChanged;
            // 
            // paw_text
            // 
            paw_text.Location = new Point(146, 270);
            paw_text.Margin = new Padding(2);
            paw_text.Name = "paw_text";
            paw_text.Size = new Size(199, 23);
            paw_text.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 225);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 272);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 4;
            label3.Text = "비밀번호";
            // 
            // login_butten
            // 
            login_butten.BackgroundImage = Properties.Resources._360_F_454099801_32LqElT2W1vgRQ6YRsp3h2IsKQxTCnaG;
            login_butten.Location = new Point(120, 320);
            login_butten.Margin = new Padding(2);
            login_butten.Name = "login_butten";
            login_butten.Size = new Size(191, 32);
            login_butten.TabIndex = 5;
            login_butten.UseVisualStyleBackColor = true;
            login_butten.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 435);
            Controls.Add(login_butten);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(paw_text);
            Controls.Add(login_text);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox login_text;
        public TextBox paw_text;
        public Button login_butten;
    }
}