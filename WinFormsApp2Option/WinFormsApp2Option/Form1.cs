using System.Windows.Forms;

namespace WinFormsApp2Option
{
    public partial class Form1 : Form
    {
        List<CJobless> list;
        BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();

            list = new List<CJobless>();

            list.Add(new CJobless { JoblessID = 1, LastName = "Иванов", FirstName = "Иван", Age = 25 });
            list.Add(new CJobless { JoblessID = 2, LastName = "Петров", FirstName = "Петр", Age = 30 });
            list.Add(new CJobless { JoblessID = 3, LastName = "Сидоров", FirstName = "Семен", Age = 35 });

            bindingSource = new BindingSource();
            bindingSource.DataSource = list;

            dataGridView1.DataSource = bindingSource;

        }

        public class CJobless
        {
            public int JoblessID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return LastName + " " + FirstName + ", " + Age;
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