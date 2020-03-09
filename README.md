# WidgetsConsoleApp

This is a C# Console Application for a simple drawing app that renders different shapes known as widgets on a canvas. The system comprise of different widgets, each able to render their unique features.

Widgets

Widgets have the following attributes:

•	Name - a string giving a widget a unique name e.g. square, circle.

•	X Coordinate - an integer that horizontally positioning the widget.

•	Y Coordinate - an integer that horizontally positioning the widget.

•	Size - an integer value that determines a simple size value for the widget.


Widgets is provideing a Draw() method which can handle how a particular widget renders itself. 


Shapes

The application provides the following shapes derived from widgets described above:

Square

•	Positioned using X and Y coordinates.

•	Has its own size.

•	Renders size and X/Y positions via its Draw method


Rectangle

•	Positioned using X and Y coordinates.

•	Has its own size.

•	Has height and width attributes unique to rectangles.

•	Renders size using height and width and X/Y positions via its Draw method


Circle

•	Positioned using X and Y coordinates.

•	Has its own size.

•	Renders size, and X/Y position via its Draw method


Ellipse

•	Positioned using X and Y coordinates.

•	Has its own size.

•	Has a horizontal and vertical diameter unique to ellipses.

•	Renders size using horizontal diameter and vertical diameter and X/Y positions via its Draw method


Text Box

•	Derives from rectangle.

•	Has a background colour.

•	Provides a Text attribute allowing string data to be set as the rendered content of the rectangle.

•	Renders size using height and width, X/Y positions, background colour and text content via its Draw method.

•	If no text content has been supplied, the background colour defaults to red when the Draw method provides background colour as part of its output.


Canvas

The application provides a Canvas for displaying the rendered content of widgets which has:

•	Ability to add multiple widgets to the canvas so each can be rendered according to the unique rendering of each widget.

•	Ability to print to the console the rendered output of each widget added to the canvas.


As a simple Console Application, this doesn't render any graphical output or write code to actually draw the widgets, but displaying only a text with the values for the widgets.
