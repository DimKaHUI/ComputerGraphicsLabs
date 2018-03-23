package Images;

import java.awt.*;

public class PixImage
{
    public static int PixelSize = 1;

    protected Vertex[] Vertexes;
    protected Color Color = java.awt.Color.BLACK;

    public PixImage()
    {
        Vertexes = new Vertex[0];
    }

    public void draw(Container canvas)
    {
        Graphics gr = canvas.getGraphics();
        //gr.translate(canvas.getWidth() / 2, canvas.getHeight() / 2);
        gr.setColor(Color);
        for(Vertex vertex : Vertexes)
        {
            if(vertex == null)
                continue;
            int x = PixelSize * vertex.x;
            int y = PixelSize * vertex.y;
            //gr.fillOval(x - PixelSize / 2, -(y + PixelSize / 2), PixelSize, PixelSize);
            gr.drawLine(x, y, x, y);
        }
    }
}
