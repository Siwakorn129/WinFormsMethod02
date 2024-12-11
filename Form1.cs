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
    }
}
