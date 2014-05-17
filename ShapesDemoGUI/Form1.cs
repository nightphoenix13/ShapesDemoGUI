using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDemoGUI
{
    public partial class Form1 : Form
    {
        // global variables
        GeometricFigure shape;
        string output;

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(heightTextBox.Text) <= 0)
            {
                MessageBox.Show("Height must be a positive number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end if
            else if (Convert.ToInt32(widthTextBox.Text) <= 0)
            {
                MessageBox.Show("Width must be a positive number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end else if
            else
            {
                if (shapeComboBox.SelectedIndex == 0)
                {
                    shape = new Rectangle(Convert.ToInt32(heightTextBox.Text),
                        Convert.ToInt32(widthTextBox.Text));
                    output = "Rectangle\r\nHeight: ";
                    output += shape.Height;
                    output += "\r\nWidth: ";
                    output += shape.Width;
                    output += "\r\nArea: " + shape.ComputeArea();
                    shapeTextBox.Text = output;
                    createButton.Enabled = false;
                    newShapeButton.Enabled = true;
                } // end if
                else if (shapeComboBox.SelectedIndex == 1)
                {
                    if (Convert.ToInt32(heightTextBox.Text) !=
                        Convert.ToInt32(widthTextBox.Text))
                    {
                        MessageBox.Show("Height and Width must be equal.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end if
                    else
                    {
                        shape = new Square(Convert.ToInt32(heightTextBox.Text));
                        output = "Square\r\nHeight: ";
                        output += shape.Height;
                        output += "\r\nWidth: ";
                        output += shape.Width;
                        output += "\r\nArea: " + shape.ComputeArea();
                        shapeTextBox.Text = output;
                        createButton.Enabled = false;
                        newShapeButton.Enabled = true;
                    } // end else
                } // end else if
                else if (shapeComboBox.SelectedIndex == 2)
                {
                    shape = new Triangle(Convert.ToInt32(heightTextBox.Text),
                        Convert.ToInt32(widthTextBox.Text));
                    output = "Triangle\r\nHeight: ";
                    output += shape.Height;
                    output += "\r\nWidth: ";
                    output += shape.Width;
                    output += "\r\nArea: " + shape.ComputeArea();
                    shapeTextBox.Text = output;
                    createButton.Enabled = false;
                    newShapeButton.Enabled = true;
                } // end else if
            } // end else
        }

        private void newShapeButton_Click(object sender, EventArgs e)
        {
            shape = null;
            shapeTextBox.Text = "";
            createButton.Enabled = true;
            newShapeButton.Enabled = false;
        } // createButton_Click method end
    }
}
