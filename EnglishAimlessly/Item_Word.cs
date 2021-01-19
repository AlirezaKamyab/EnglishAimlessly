using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class Item_Word : UserControl
    {
        private string _title = "Title";
        private string _description = "Description";
        private Color _titleColor = Color.Black;
        private Color _descriptionColor = Color.Black;
        private Color _backgroundColor = Color.White;
        public string Title { get { return _title; }
            set 
            {
                _title = value;
                TitleChanged?.Invoke(this);
            } 
        }
        public string Description { get { return _description; } 
            set 
            {
                _description = value;
                DescriptionChanged?.Invoke(this);
            }
        }

        public Color TitleColor { get { return _titleColor; }
            set 
            {
                _titleColor = value;
                TitleColorChanged?.Invoke(this);
            }
        }

        public Color DescriptionColor { get { return _descriptionColor; }
            set
            {
                _descriptionColor = value;
                DescriptionColorChanged?.Invoke(this);
            }
        }

        public Color BackgroundColor { get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                BackgroundColorChanged?.Invoke(this);
            }
        }

        public Item_Word()
        {
            InitializeComponent();
        }

        private void Item_Word_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            lblDescription.Text = Description;
            lblTitle.ForeColor = TitleColor;
            lblDescription.ForeColor = DescriptionColor;
            pnlMain.BackColor = BackgroundColor;
            TitleChanged += Item_Word_TitleChanged;
            DescriptionChanged += Item_Word_DescriptionChanged;
            TitleColorChanged += Item_Word_TitleColorChanged;
            DescriptionColorChanged += Item_Word_DescriptionColorChanged;
            BackgroundColorChanged += Item_Word_BackgroundColorChanged;
        }

        private void Item_Word_BackgroundColorChanged(object sender)
        {
            pnlMain.BackColor = BackgroundColor;
        }

        private void Item_Word_DescriptionColorChanged(object sender)
        {
            lblDescription.ForeColor = DescriptionColor;
        }

        private void Item_Word_TitleColorChanged(object sender)
        {
            lblTitle.ForeColor = TitleColor;
        }

        private void Item_Word_DescriptionChanged(object sender)
        {
            lblDescription.Text = Description;
        }

        private void Item_Word_TitleChanged(object sender)
        {
            lblTitle.Text = Title;
        }

        public delegate void ValueHander(object sender);
        public event ValueHander TitleChanged;
        public event ValueHander DescriptionChanged;

        public delegate void ColorHandler(object sender);
        public event ColorHandler TitleColorChanged;
        public event ColorHandler DescriptionColorChanged;
        public event ColorHandler BackgroundColorChanged;

        public delegate void ClickHander(object sender);
        public event ClickHander Clicked;
        private void lblTitle_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this);
        }
    }
}
