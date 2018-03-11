package Images;

import java.awt.*;

public class PixImage
{
    protected Vertex[] Vertexes;
    protected Color Color = java.awt.Color.BLACK;

    public PixImage()
    {
        Vertexes = new Vertex[0];
    }

    public void draw(Container canvas)
    {
        Graphics gr = canvas.getGraphics();
        gr.translate(canvas.getWidth() / 2, canvas.getHeight() / 2);
        gr.setColor(Color);
        for(Vertex vertex : Vertexes)
        {
            //gr.drawRect(vertex.x, vertex.y, 1, 1);
            gr.drawOval(vertex.x - 1, -(vertex.y + 1), 1, 1);
        }
    }
}
