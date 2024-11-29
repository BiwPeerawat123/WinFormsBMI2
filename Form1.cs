namespace WinFormsBMI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่ม "คำนวณ BMI"
            //Input รับค่า textBox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //double height = Convert.ToDouble(txtHeight.Text);
            //double height = 0;
            //if (double.TryParse(txtHeight.Text, out height) == false)
            //{
            //  MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            // return;   //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //}
            //double weight = 0;
            //if (double.TryParse(txtWeight.Text, out weight) == false)
            //{
            //  MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //  return;   //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //}
            //double weight = Convert.ToDouble(txtWeight.Text);
            double height = 0;
            double weight = 0;
            if(CheckDouble (txtHeight, txtWeight))
            {
                height = Convert.ToDouble (txtHeight.Text); 
                weight = Convert.ToDouble (txtWeight.Text); 
            }
            //Process คำนวณค่า BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);                        //เรียกใช้method BMI
            //Output แปลผล โดนนำค่า BMI มาเทียบกับค่ามาตรฐาน
            lblResult.Text = bmi.ToString();

        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;

            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void InputDataValid(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0) //.lrngth 
            {
                name.ForeColor = Color.DeepPink;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DeepPink;
            }
            else
            {
                age.ForeColor = Color.Black;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);

        }

        private double BMI(double h, double w)   //คำนวณค่า bmi ส่งค่าเข้ามา 2 ค่า คือน้ำหนักและส่วนสูง
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100)
        }
        
        private bool CheckDouble(TextBox txtW ,TextBox txtH)
        {
            double w = 0; 
            double h = 0;
            if((double.TryParse(txtW.Text, out w)==false)|| (double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }
    }
}
