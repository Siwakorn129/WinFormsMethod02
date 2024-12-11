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
                MessageBox.Show("โปรดกรอกชื่อให้พูกต้อง", "ข้อมุลผิดพลาด");
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
                MessageBox.Show("แสดงข้อมูลผิดพลาด", "โปรดกรอกให้ถูกต้อง");
            }
        }

        private void btnArrayParameter_Click(object sender, EventArgs e)
        {
            double[] data = new double[] { 1.5, 2.0, 3.25, 0.15 };
            double summary = sum(data);  //เรียกใช้ function
            string result = string.Join("/", data);
            result += Environment.NewLine;
            result += summary.ToString();
            MessageBox.Show(summary.ToString(), "ผลรวมค่าใน Array");
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
