namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "數值是否在1~99";
            this.MinimizeBox = this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            generateButton.Text = "執行";
            generateButton.Font = new Font("Arial", 12, FontStyle.Regular);

            valueTextBox.MaxLength = 3;

            titleLabel.Text = "請輸入數值:";
            titleLabel.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // 取得輸入數值
            int number = 0;
            try
            {
                number = GetNumber();
            }catch (Exception ex)
            {
                // 呈現錯誤原因
               MessageBox.Show(ex.Message);
                return;
            }

            // 數值是否介於1~99之間
            string result = GetResult(number);

            // 呈現結果
            MessageBox.Show(result);
        }

        private string GetResult(int number)
        {
            string result = string.Empty;
            if (number >= 1 && number <= 99)
            { result = $"{number} 介於1~99之間"; }
            else { result = $"{number} 沒有介於1~99之間";}

            return result;
        }

        private int GetNumber()
        {
            string input = valueTextBox.Text;
            // 試著將輸入的數值轉換成int
            bool isint = int.TryParse(input, out int value);
            // 若轉換成功，傳回result，若失敗則傳回例外
            return isint? value : throw new Exception("請輸入整數");
        }
    }
}