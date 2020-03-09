using System;
using System.Collections.Generic;
using System.Drawing;

namespace WidgetsConsoleAppNetCore {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Initialising objects");

			Square s = new Square(10, 20, 100);
			Rectangle r = new Rectangle(120, 20, 50, 60);
			Circle c = new Circle(40, 100, 20);
			Elipse e = new Elipse(150, 250, 10, 20);
			TextBox t1 = new TextBox(10, 10, 300, 30, "Test", Color.White);
			TextBox t2 = new TextBox(10, 50, 300, 30);
			Canvas cList = new Canvas(new List<Widget>() {
				new Square(10, 20, 100),
				new Rectangle(10, 20, 30, 40), 
				new Circle(40, 100, 20),
				new TextBox(10, 10, 300, 30) 
			});
			Console.WriteLine("Initialising complete\n");

			Console.WriteLine("Rendering Widgets");
			s.Draw();
			r.Draw();
			c.Draw();
			e.Draw();
			t1.Draw();
			t2.Draw();
			Console.WriteLine("Done\n");

			Console.WriteLine("Rendering Canvas");
			cList.Draw();
			Console.WriteLine("Done\n");

			Console.WriteLine("Rendering complete");
		}
	}
}
