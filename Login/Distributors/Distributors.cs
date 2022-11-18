using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarmanStoreProject.Distributors
{
    public partial class Distributors : Form
    {
        public Distributors()
        {
            InitializeComponent();
        }
        TextBox Mybutton1;
        DataGridView listBox1;
        private void Distributors_Load(object sender, EventArgs e)
        {
            BindingSource binding1 = new BindingSource();

            Mybutton1 = new TextBox();
            Mybutton1.Location = new Point(360, 198);
            Mybutton1.Text = "Cancel";
            Mybutton1.AutoSize = true;
            Mybutton1.BackColor = Color.LightPink;
            Mybutton1.Padding = new Padding(6);
            Mybutton1.Font = new Font("French Script MT", 18);
            MyFontList fonts = new MyFontList();
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                if (FontFamily.Families[i].IsStyleAvailable(FontStyle.Regular))
                    fonts.Add(new Font(FontFamily.Families[i], 11.0F, FontStyle.Regular));
            }
            listBox1 = new DataGridView();
            listBox1.Size = new Size(200, 300);
            this.Controls.Add(listBox1);
            binding1.DataSource = fonts;
            listBox1.DataSource = binding1;
            listBox1.AutoSize = true;
            listBox1.MaximumSize = this.Size;
            this.MaximumSize = MainForm.mainform.Size;
            //listBox1.DisplayMember = "Name";
            this.Controls.Add(Mybutton1);
            this.Mybutton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", binding1, "NAME", true));

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public class MyFontList : BindingList<Font>
        {

            protected override bool SupportsSearchingCore
            {
                get { return true; }
            }
            protected override int FindCore(PropertyDescriptor prop, object key)
            {
                // Ignore the prop value and search by family name.
                for (int i = 0; i < Count; ++i)
                {
                    if (Items[i].FontFamily.Name.ToLower() == ((string)key).ToLower())
                        return i;
                }
                return -1;
            }
        }
    }
}
