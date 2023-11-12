namespace WinFormsApp9Option
{
    public partial class Form1 : Form
    {
        List<CVlad> list;
        BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();

            list = new List<CVlad>();

            list.Add(new CVlad { FIO = "Иванов Иван Иванович", Phone = "1234567", Registr = 1 });
            list.Add(new CVlad { FIO = "Петров Петр Петрович", Phone = "7654321", Registr = 2 });
            list.Add(new CVlad { FIO = "Сидоров Сидор Сидорович", Phone = "4567892", Registr = 3 });

            bindingSource = new BindingSource();
            bindingSource.DataSource = list;

            dataGridView1.DataSource = bindingSource;
        }
        public class CVlad
        {
            public string FIO { get; set; }
            public string Phone { get; set; }
            public int Registr { get; set; }

            public override string ToString()
            {
                return FIO + ", " + Phone + ", " + Registr;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            dataGridView1.Rows.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("Данных нет");
            }
        }
    }
}