using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace triangles
{
    public partial class Form1 : Form
    {
        #region formVariables
        bool draw = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region triangleClass
        class Triangle
        {
            public int A { get; set; }
            public int B { get; set; }
            public int C { get; set; }

            public override string ToString()
            {
                return "a: " + A + "  b: " + B +" c: "+ C;
            }
        }

        // store unique triangles in a list
        List<Triangle> triangleList = new List<Triangle>();


        #endregion

        #region properties
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }
        #endregion

        #region drawGraphics
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Draw triangle if draw button is clicked
            if (draw)
            {
                Pen blackPen = new Pen(Color.Blue, 4);

                // Calculate triangle coordinates from speified lengths
                // Initial const position to start at center - there must be a better way around this :(
                const int x1 = 300;
                const int y1 = 100;
                int x2 = x1 - a;
                int y2 = y1 + a;
                int x3 = x2 + b;
                int y3 = y1 + c;

                // Create points that define triangle.
                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);
                Point point3 = new Point(x3, y3);
                Point[] trianglePoints =
                         {
                 point1,
                 point2,
                 point3
             };
                e.Graphics.DrawPolygon(blackPen, trianglePoints);
            }
            
        }
        #endregion

        #region drawButton
        private void drawButton_Click(object sender, EventArgs e)
        {
            draw = true;

            // Create new triangle object
            Triangle triangle = new Triangle();
            a = triangle.A;
            b = triangle.B;
            c = triangle.C;

            a = Convert.ToInt32(atextBox.Text);
            b = Convert.ToInt32(btextBox.Text);
            c = Convert.ToInt32(ctextBox.Text);

            // Only accept lengths greater than 0
            if (a != 0 && b != 0 && c != 0)
            {
                panel1.Refresh();
            }
            else
            {
                MessageBox.Show("ALERT: The values of a, b, c must be greater than 0");                
            }

            // hold a copy of triangleList vales for validation
            string val = ("a: " + a + "  b: " + b + " c: " + c);

            bool duplicate = false;

            // loop around all elements in triangs
            foreach (var item in triangleList)
            {
                // check in loop if item.ToString() is equal to the above string or not
                if (String.Equals(item.ToString(), val))
                {
                    duplicate = true;
                    break;
                }                
            }
            if (!duplicate)
            {
                // then add triangle to list and add list to listbox
                triangleList.Add(new Triangle() { A = a, B = b, C = c });
                listBox.Items.Add(triangleList.Last());
            }
        }
        #endregion

        #region deleteTriangle
        private void delete_Click(object sender, EventArgs e)
        {
            // delete triangle from triangleList and listbox
            if (listBox.SelectedIndex > -1)
            {
                string val = listBox.SelectedItem.ToString();
                foreach (var item in triangleList)
                {
                   
                    if (String.Equals(item.ToString(), val))
                    {
                        triangleList.Remove(item);
                        MessageBox.Show("Succesfully deleted triangle  " + val);
                        break;
                    }
                }
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                
            }
            else if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("ALERT: Triangle must be selected from the list!");
            }
        }
        #endregion

        #region unusedEvents
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region importExport
        private void export_button_Click(object sender, EventArgs e)
        {
            /* make an XML handler to reads and load values of each item 
             * in the triangleList as
             * <item> 
             *  <a>value</a>
             *  <b>value</b>
             *  <c>value</c>  
             * </item>
             * <item> 
             *  <a>value</a>
             *  <b>value</b>
             *  <c>value</c>  
             * </item>
             */
        }

        private void import_Button_Click(object sender, EventArgs e)
        {
            // XML handler to read from xml file and extract a,b,c values to listbox
             
        }
        #endregion
    }
}
