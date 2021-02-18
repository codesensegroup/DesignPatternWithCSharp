namespace Adapter
{
    public class VectorRectangle : VectorObject
    {
        public VectorRectangle(int x, int y, int width, int height)
        {
            // Up-Line (Left Up Point->Right Up Point)
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            
            // Right-Line (Right Up Point -> Right Bottom Potin)
            Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
            
            // Left-Line (Left Up Point -> Left Bottom Potin)
            Add(new Line(new Point(x, y), new Point(x, y + height)));
            
            // Bottom-Line (Left Bottom Point -> Right Bottom Potin)
            Add(new Line(new Point(x, y + height), new Point(x + width, y + height)));
        }
    }
}
