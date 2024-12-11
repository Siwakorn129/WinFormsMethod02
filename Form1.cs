namespace WinFormsMethod02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            lblResult.Text = Circumference(r).ToString(); //���¡�� function 㹻���¤�����
        }

        double Circumference(double radius) //�觤��任����ż����ҧ����
        {
            return 2 * Math.PI * radius;
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            /*
            double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            CircleArea(r); //���¡�� void method CircleArea
            */

            //CircleArea(txtRadius); //���¡�� void method Ẻ�� Textbox

            CircleArea(txtRadius, lblResult);//���¡�� void method Ẻ�� Texbox ��� Lable
        }

        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lblResult.Text = area.ToString();

        }

        void CircleArea(TextBox txt)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            double area = Math.PI * r * r;
            lblResult.Text = area.ToString();
        }

        void CircleArea(TextBox txt, Label lbl)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString();
        }

        string triangle(string letter = "x", int size = 5)
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (global::System.Int32 j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private void btnTriangle01_Click(object sender, EventArgs e)
        {
            //txtOutput.Text = triangle();
            //txtOutput.Text = triangle(txtLetter.Text);
            //txtOutput.Text = triangle(txtLetter.Text, 9);
            txtOutput.Text = triangle(txtLetter.Text);
        }

        void ImproveName(ref string name)
        {
            name = name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("�ô��͡�������١��ͧ", "�����żԴ��Ҵ");
                return;
            }
        }

        private void txtRefParameter_Click(object sender, EventArgs e)
        {
            string FName = txtInput.Text;
            ImproveName(ref FName);
            txtInput.Text = FName;
        }

        Boolean improveName3(string name, out string x)
        {
            x = name.Trim();
            if (name.Length < 2)
            {
                x = "";
                return false;
            }
            return true;
        }

        private void txtOutputParameter_Click(object sender, EventArgs e)
        {
            string FName = "";
            if (improveName3(txtOutput.Text, out FName))
            {
                txtInput.Text = FName;
            }
            else
            {
                MessageBox.Show("�ʴ������żԴ��Ҵ", "�ô��͡���١��ͧ");
            }
        }

        private void btnArrayParameter_Click(object sender, EventArgs e)
        {
            double[] data = new double[] { 1.5, 2.0, 3.25, 0.15 };
            double summary = sum(data);  //���¡�� function
            string result = string.Join("/", data);
            result += Environment.NewLine;
            result += summary.ToString();
            MessageBox.Show(summary.ToString(), "��������� Array");
        }

        double sum(double[] dataArray)
        {
            double sum = 0;
            foreach (double d in dataArray)
            {
                sum += d;
            }
            return sum;
        }
    }
}
