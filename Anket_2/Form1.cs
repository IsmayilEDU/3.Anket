using Anket_2.Class;
using MyLibrary.Classes;

namespace Anket_2
{
    public partial class Anket : Form
    {
        List<Person> people;
        public Anket()
        {
            InitializeComponent();
            people = MyJson.ReadFromJson<Person>("People");
            buttonLoad.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxPeople.Items.AddRange(people.ToArray());

        }

        private void ClikToLoad(object sender, MouseEventArgs e)
        {
            if (listBoxPeople.SelectedItem is Person person)
            {
                textBoxName.Text = person.Name;
                textBoxSurname.Text = person.Surname;
                textBoxEmail.Text = person.Email;
                textBoxPhone.Text = person.Phone;
                dateTimePickerBirthday.Value = person.Birthday;
                buttonSave.Enabled = false;
            }
        }

        private void ClickToClear(object sender, MouseEventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            dateTimePickerBirthday.Value = DateTime.Now;
            buttonSave.Enabled = true;
            buttonLoad.Enabled = false;
            listBoxPeople.SelectedItems.Clear();
        }

        private void ClickToSave(object sender, MouseEventArgs e)
        {
            try
            {
                people.Add(new Person(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxPhone.Text, dateTimePickerBirthday.Value));
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeIndexOfPeople(object sender, EventArgs e)
        {
            buttonLoad.Enabled = true;
        }
    }
}