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
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            lblResult.Text = Circumference(r).ToString(); //เรียกใช้ function ในประโยคคำสั่ง
        }

        double Circumference(double radius) //ส่งค่าไปประมวลผลอย่างเดียว
        {
            return 2 * Math.PI * radius;
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            /*
            double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            CircleArea(r); //เรียกใช้ void method CircleArea
            */

            //CircleArea(txtRadius); //เรียกใช้ void method แบบส่ง Textbox

            CircleArea(txtRadius, lblResult);//เรียกใช้ void method แบบส่ง Texbox และ Lable
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
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
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
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString();
        }
    }
}
