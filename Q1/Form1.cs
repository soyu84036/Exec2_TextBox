namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "�ƭȬO�_�b1~99";
            this.MinimizeBox = this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            generateButton.Text = "����";
            generateButton.Font = new Font("Arial", 12, FontStyle.Regular);

            valueTextBox.MaxLength = 3;

            titleLabel.Text = "�п�J�ƭ�:";
            titleLabel.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // ���o��J�ƭ�
            int number = 0;
            try
            {
                number = GetNumber();
            }catch (Exception ex)
            {
                // �e�{���~��]
               MessageBox.Show(ex.Message);
                return;
            }

            // �ƭȬO�_����1~99����
            string result = GetResult(number);

            // �e�{���G
            MessageBox.Show(result);
        }

        private string GetResult(int number)
        {
            string result = string.Empty;
            if (number >= 1 && number <= 99)
            { result = $"{number} ����1~99����"; }
            else { result = $"{number} �S������1~99����";}

            return result;
        }

        private int GetNumber()
        {
            string input = valueTextBox.Text;
            // �յ۱N��J���ƭ��ഫ��int
            bool isint = int.TryParse(input, out int value);
            // �Y�ഫ���\�A�Ǧ^result�A�Y���ѫh�Ǧ^�ҥ~
            return isint? value : throw new Exception("�п�J���");
        }
    }
}