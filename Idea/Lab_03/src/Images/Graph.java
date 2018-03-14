package Images;

import java.awt.*;

public class Graph
{
    float x_pnt[];
    float y_pnt[];
    int pointSize;
    float x_scale, y_scale;
    Color Color;
    public Graph(float x[], float y[], float x_scale, float y_scale, int pointSize, Color color)
    {
        this.x_pnt = x;
        this.y_pnt = y;
        this.x_scale = x_scale;
        this.y_scale = y_scale;
        this.pointSize = pointSize;
        this.Color = color;
    }

    public Graph(Vertex points[], float x_scale, float y_scale, int pointSize, Color color)
    {
        x_pnt = new float[points.length];
        y_pnt = new float[points.length];
        for(int i = 0; i < points.length; i++)
        {
            x_pnt[i] = points[i].x;
            y_pnt[i] = points[i].y;
        }
        this.x_scale = x_scale;
        this.y_scale = y_scale;
        this.pointSize = pointSize;
        this.Color = color;
    }

    public void draw(Container canvas)
    {
        Graphics gr = canvas.getGraphics();
        gr.translate(canvas.getWidth() / 2, canvas.getHeight() / 2);

        gr.setColor(java.awt.Color.BLACK);

        // Drawing notches
        // X
        float prevNotch = 0;
        for(int x = 0; x < canvas.getWidth() / 2; x += 1)
        {
            if (Math.abs(x * x_scale - prevNotch) >= 30)
            {
                gr.drawLine((int) (x * x_scale), -5, (int) (x * x_scale), 5);
                gr.drawString(String.valueOf(x), (int) (x * x_scale) - 5, 15);
                prevNotch = x*x_scale;
            }

        }

        // Y
        prevNotch = 0;
        for(int y = 0; y < canvas.getHeight() / 2; y += 1)
        {
            if (Math.abs(y * y_scale - prevNotch) >= 15)
            {
                gr.drawLine(-5, -(int) (y * y_scale), 5, -(int) (y * y_scale));
                gr.drawString(String.valueOf(y), -30, -(int) (y * y_scale) + 5);
                prevNotch = y * y_scale;
            }
        }

        gr.setColor(Color);

        for(int i = 0; i < x_pnt.length; i++)
        {
            int x = (int)(x_pnt[i] * x_scale);
            int y = (int)(y_pnt[i] * y_scale);
            gr.fillOval(x - pointSize/2, -(y+pointSize/2), pointSize, pointSize);
        }
    }
}
