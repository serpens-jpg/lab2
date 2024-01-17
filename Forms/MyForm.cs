using _8xml.Strategy;
using _8xml.Strategy.Interfaces;
using System.Xml.Serialization;

namespace _8xml.Forms
{
    public partial class MyForm : Form
    {
        private IXSLTService xsltService;
        private IEnumerable<ScheduleItem> items;
        private IEnumerable<ScheduleItem> itemsToDisplay;

        private string xmlFilePath;

        public MyForm()
        {
            this.xsltService = new XSLTService();
            this.items = new List<ScheduleItem>();
            this.itemsToDisplay = new List<ScheduleItem>();
            InitializeComponent();
            this.xmlFilePath = default;
            this.saxBtn.Checked = true;
        }

        private void xsltButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XSLT Files|*.xslt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xsltPath = openFileDialog.FileName;
                var htmlSaveFileDialog = new SaveFileDialog();
                if (htmlSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.xsltService.ToXSLT(this.xmlFilePath, xsltPath, htmlSaveFileDialog.FileName + ".html");

                    MessageBox.Show("Успіх!");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml|All Files|*.*";
            openFileDialog.Title = "Select an XML File";
            this.RefreshAllControls();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = openFileDialog.FileName;
                this.Load(openFileDialog.FileName);
                this.RefreshTextBox();
            }
        }

        private void RefreshAllControls()
        {
            this.contentTextBox.Clear();
            this.items = new List<ScheduleItem>();
            this.itemsToDisplay = new List<ScheduleItem>();
            this.classnameComboBox.Items.Clear();
            this.userComboBox.Items.Clear();
            this.teacherComboBox.Items.Clear();
            this.classnameComboBox.SelectedIndex = -1;
            this.userComboBox.SelectedIndex = -1;
            this.teacherComboBox.SelectedIndex = -1;
            this.classnameComboBox.Text = "";
            this.userComboBox.Text = "";
            this.teacherComboBox.Text = "";
        }

        private void Load(string xmlPath)
        {
            IReadXMLStrategy readStrategy = default!;
            if (this.saxBtn.Checked)
            {
                readStrategy = new SAXReadXMLStrategy();
            }
            else
            {
                if (this.domButton.Checked)
                {
                    readStrategy = new DOMReadXMLStrategy();
                }
                else
                {
                    readStrategy = new LINQReadXMLStrategy();
                }
            }
            var items = readStrategy.Read(xmlPath);
            this.Update(items, firstTimeRender: true);

        }

        private void Update(IEnumerable<ScheduleItem> scheduleItems, bool firstTimeRender = false)
        {
            if (firstTimeRender)
                this.items = scheduleItems;

            this.contentTextBox.Text = "";

            foreach (var item in scheduleItems)
            {
                string itemInTextbox = "";

                itemInTextbox += $"Ідентифікатор = {item.Id}\n";
                itemInTextbox += $"Назва класу = {item.ClassName}\n";
                itemInTextbox += $"Розмір класу = {item.WorkingSpaceCapacity}\n";
                itemInTextbox += $"Користувач = {item.User}\n";
                itemInTextbox += $"Вчитель = {item.Teacher}\n";
                itemInTextbox += $"Час вільного доступу = {item.FreeAccessTime}\n\n";

                this.contentTextBox.Text += itemInTextbox;
            }


        }

        private void RefreshTextBox()
        {
            var classnames = this.items.Select(x => x.ClassName).Distinct().ToList();
            this.classnameComboBox.Items.Add("");
            this.classnameComboBox.Items.AddRange(classnames.ToArray());

            var users = this.items.Select(x => x.User).Distinct().ToList();
            this.userComboBox.Items.Add("");
            this.userComboBox.Items.AddRange(users.ToArray());

            var teachers = this.items.Select(x => x.Teacher).Distinct().ToList();
            this.teacherComboBox.Items.Add("");
            this.teacherComboBox.Items.AddRange(teachers.ToArray());
        }

        private void Save(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<ScheduleItem>));

            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, itemsToDisplay);
            }
        }

        private void classnameComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.Filter();

        private void Filter()
        {
            var classname = classnameComboBox.SelectedItem?.ToString();
            var user = userComboBox.SelectedItem?.ToString();
            var teacher = teacherComboBox.SelectedItem?.ToString();

            this.itemsToDisplay = this.items;

            if (!string.IsNullOrEmpty(classname) || !string.IsNullOrEmpty(user) || !string.IsNullOrEmpty(teacher))
            {
                this.itemsToDisplay = this.items.Where(x =>
                        (string.IsNullOrEmpty(classname) || x.ClassName == classname) &&
                        (string.IsNullOrEmpty(user) || x.User == user) &&
                        (string.IsNullOrEmpty(teacher) || x.Teacher == teacher)).ToList();
            }

            this.Update(this.itemsToDisplay);
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.Filter();

        private void teacherComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.Filter();

        private void clearButton_Click(object sender, EventArgs e) => RefreshAllControls();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Save(saveFileDialog.FileName);
                MessageBox.Show("Успіх!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}