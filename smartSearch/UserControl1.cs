using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smartSearch
{
    public partial class UserControl1 : UserControl
    {
        Size _controlSize;
        Rectangle _originalBounds;
        bool expanded = false;

        
        public UserControl1()
        {
            InitializeComponent();
            _controlSize = this.Size;
            this.Height = bt_search.Height;
            _originalBounds = this.Bounds;

            Console.WriteLine(Bounds.Height + " VS " + this.Height);

            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (!expanded)
            {
                var res = from Control control in this.Parent.Controls
                          where this.Location.X < control.Location.X &&
                            control.Location.X < this.Location.X + this.Width &&
                            control.Bounds.IntersectsWith(this.Bounds) &&
                            !control.Name.Equals(this.Name)
                          select control;

                List<Control> List = res.ToList();

                this.Size = _controlSize;
                this.BringToFront();

                foreach (Control p in List)
                {
                    p.BringToFront();
                    Console.WriteLine(p.Name);
                }
                expanded = true;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Height = bt_search.Height;
            expanded = false;
        }

        private void UserControl1_Leave(object sender, EventArgs e)
        {
            this.Height = bt_search.Height;
            expanded = false;
        }

    }
}
