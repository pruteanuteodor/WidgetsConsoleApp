using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WidgetsConsoleAppNetCore {
	abstract class Widget {
		public string Name { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int Size { get; set; }
		public abstract void Draw();
	}

	class Square : Widget {
		public override void Draw() => Console.WriteLine(Name + " (x: " + X + ", y: " + Y + ") Size: " + Size);
		public Square(int x, int y, int size) {
			Name = "Square";
			X = x;
			Y = y;
			Size = size;
		}
	}

	class Rectangle : Widget {
		public int Width { get; set; }
		public int Height { get; set; }
		public override void Draw() => Console.WriteLine(Name + " (x: " + X + ", y: " + Y + ") Width: " + Width + " Height: " + Height);
		public Rectangle(int x, int y, int width, int height) {
			Name = "Rectangle";
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}
	}

	class Circle : Widget {
		public override void Draw() => Console.WriteLine(Name + " (x: " + X + ", y: " + Y + ") Diameter: " + Size);
		public Circle(int x, int y, int size) {
			Name = "Circle";
			X = x;
			Y = y;
			Size = size;
		}
	}

	class Elipse : Widget {
		public int vDiameter { get; set; }
		public int hDiameter { get; set; }
		public override void Draw() => Console.WriteLine(Name + " (x: " + X + ", y: " + Y + ") Horisontal diameter: " + hDiameter + " Vertical diameter: " + vDiameter);
		public Elipse(int x, int y, int hD, int vD) {
			Name = "Elipse";
			X = x;
			Y = y;
			hDiameter = hD;
			vDiameter = vD;
		}
	}

	class TextBox : Rectangle {
		public Color BackgroundColor { get; set; }
		public string Text { get; set; }
		public override void Draw() {
			Console.WriteLine(Name + " (x: " + X + ", y: " + Y + ") Width: " + Width + " Height: " + Height + (Text == ""? "" : " Text: " + Text) + " Background color: " + BackgroundColor);
		}
		public TextBox(int x, int y, int width, int height, string text, Color bgColor) : base(x, y, width, height) {
			Name = "TextBox";
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Text = text;
			BackgroundColor = bgColor;
		}
		public TextBox(int x, int y, int width, int height) : base(x, y, width, height) {
			Name = "TextBox";
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Text = "";
			BackgroundColor = Color.Red;
		}
	}

	class Canvas {
		public List<Widget> Widgets { get; set; }
		public Canvas(List<Widget> widgets) => Widgets = widgets;

		public void Draw() {
			foreach(Widget w in Widgets) {
				w.Draw();
			}
		}
	}
}
