using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class cbx_Shapes : Form
    {
        //update in this week insallah qaqasss
        
        public Graphics Graphics { get; set; }
        public List<IFigure> Shapes { get; set; } = new List<IFigure>();
        public Color ShapeColor { get; set; } = Color.Black;
        public IFactory ShapeFactory { get; set; }
        public  interface IFigure
        {
             Point Point { get; set; }
             Size Size { get; set; }
             Color Color { get; set; }
             bool IsFill { get; set; }
        }
        class Circle : IFigure
        {
           public  Point Point { get; set; }
           public  Size Size { get; set; }
           public  Color Color { get; set; }
           public  bool IsFill { get; set; }
        }
        class Rectangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFill { get; set; }
        }
        class Triangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFill { get; set; }
        }
        public interface IFactory
        {
            IFigure GetFigure();
        }
        public class CircleFactory : IFactory
        {
            public IFigure GetFigure() => new Circle();
        }
        public class RectangleFactory : IFactory
        {
            public IFigure GetFigure() => new Rectangle();
        }
        public class TriangleFactory : IFactory
        {
            public IFigure GetFigure() => new Triangle();
        }
        public cbx_Shapes()
        {
            InitializeComponent();
            string[] shapes = new string[3]
            {
                "Circle",
                "Rectangle",
                 "Triangle"
            };
            comboBox1.Items.AddRange(shapes);
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                ShapeFactory = new RectangleFactory();
            }
            else if (comboBox1.SelectedItem.ToString() == "Circle")
            {
                ShapeFactory = new CircleFactory();
            }
        }
        private void cbx_Shapes_MouseClick(object sender, MouseEventArgs e)
        {
            IFigure figure = ShapeFactory.GetFigure();
            if(ShapeFactory.GetFigure()is Rectangle rect)
            {
                rect.Color = ShapeColor;
                rect.Size = new Size(int.Parse(txtBox_Width.Text), int.Parse(txtBox_Height.Text));
                rect.Point = e.Location;
                rect.IsFill = true;
                Shapes.Add(rect);
            }
            else if (ShapeFactory.GetFigure() is Circle circle)
            {
                circle.Color = ShapeColor;
                circle.Size = new Size(int.Parse(txtBox_Width.Text), int.Parse(txtBox_Height.Text));
                circle.Point = e.Location;
                circle.IsFill = true;
                Shapes.Add(circle);
            }
            else if (ShapeFactory.GetFigure() is Triangle triangle)
            {
                triangle.Color = ShapeColor;
                triangle.Size = new Size(int.Parse(txtBox_Width.Text), int.Parse(txtBox_Height.Text));
                triangle.Point = e.Location;
                triangle.IsFill = true;
                Shapes.Add(triangle);
            }
            this.Refresh();
        }
        private void cbx_Shapes_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ShapeColor, 5);
            SolidBrush brush = new SolidBrush(ShapeColor);
            using(var g = e.Graphics)
            {
                foreach (var shape in Shapes)
                { 
                    if(shape is Rectangle rect)
                    {
                        if (rect.IsFill)
                        {
                            g.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                        else
                        {
                            g.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                    }
                    else if(shape is Circle circle)
                    {
                        if (circle.IsFill)
                        {
                            g.FillEllipse(brush, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                        else
                        {
                            g.DrawEllipse(pen, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                    }
                    else if(shape is Triangle triangle)
                    {
                        if (triangle.IsFill)
                        {
                          
                        }
                        else
                        {
                          ///  g.DrawPolygon(pen, triangle.Point.X, triangle.Point.Y, triangle.Size.Width, triangle.Size.Height);
                        }
                    }
                }
            }
        }
        private void btn_ColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                ShapeColor = colorDialog1.Color;
            }
        }
    }
}
