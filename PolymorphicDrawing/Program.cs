//Alex Gardner - 3/25/26 - Lab 10: Polymorphic Drawing

using ShapeLib;

Console.WriteLine("Welcome to the Drawing Factory! Use the menus below to add or modify shapes to create drawings.");

List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>{ new RectangleFactory(), new CircleFactory() };

List<IGraphic2D> builtShapes = new List<IGraphic2D>();

int userInput = -1;

while(userInput != 3)
{
    Console.WriteLine("What would you like to do?" +
        "\n\t[0] Display Drawing" +
        "\n\t[1] Add Graphic" +
        "\n\t[2] Remove Graphic" +
        "\n\t[3] Exit");
    userInput = Convert.ToInt16(Console.ReadLine());

    switch (userInput)
    {
        case 0:
            //Display shapes
            Console.Clear();
            AbstractGraphic2D.Display(builtShapes);
            Console.ReadLine();
            Console.Clear();
            break;
        case 1:
            //Add a shape
            Console.WriteLine("What shape would you like to make?");
            for(int i = 0; i < availableShapeTypes.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {availableShapeTypes[i].Name}");
            }
            int shapeChoice = Convert.ToInt16(Console.ReadLine());
            builtShapes.Add(availableShapeTypes[shapeChoice].Create());
            break;
        case 2:
            //Remove a shape
            Console.WriteLine("What shape would you like to remove?");
            for(int i = 0; i < builtShapes.Count; i++)
            {
                IGraphic2D shape = builtShapes[i];
                Console.WriteLine($"\t[{i}] {shape.GetType().Name}");
            }
            shapeChoice = Convert.ToInt16(Console.ReadLine());

            builtShapes.RemoveAt(shapeChoice);
            break;
        case 3:
            //Do nothing - The program will exit
            break;
        default:
            Console.WriteLine("Input not recognized");
            break;
    }
}
Console.WriteLine("See ya!");