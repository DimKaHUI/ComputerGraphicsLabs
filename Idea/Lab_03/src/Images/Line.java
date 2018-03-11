package Images;

import java.awt.*;

public class Line extends PixImage
{
    public enum Algorithm
    {
        INTEGRAL, BRESENHAM_INTEGRAL, BRESENHAM_FLOAT, BRESENHAM_LOW_STEP
    }

    public Line(Vertex start, Vertex end, Algorithm alg, Color color)
    {
        Color = color;
        if(start.compare(end))
        {
            Vertexes = new Vertex[1];
            Vertexes[0] = start;
            return;
        }

        switch(alg)
        {
        case INTEGRAL:
            buildIntegral(start, end);
            break;
        case BRESENHAM_INTEGRAL:
            buildBresenhamIntegral(start, end);
            break;
        case BRESENHAM_FLOAT:
            buildBresenhamFloat(start, end);
            break;
        case BRESENHAM_LOW_STEP:

            break;
        }
    }

    private void buildIntegral(Vertex start, Vertex end)
    {
        float
                x = start.x,
                y = start.y;
        int
                hx = end.x - start.x,
                hy = end.y - start.y,
                dx = Math.abs(hx),
                dy  = Math.abs(hy),
                l;
        if (dx > dy) l = dx + 1; else l = dy + 1;

        float sx = (float)hx / l;
        float sy = (float)hy / l;
        Vertexes = new Vertex[l];
        for(int i = 0; i < l; i++)
        {
            x += sx;
            y += sy;
            Vertexes[i] = new Vertex((int)x, (int)y);
        }
    }

    private void buildBresenhamFloat(Vertex a, Vertex b)
    {
        int hx = b.x - a.x;
        int hy = b.y - a.y;
        int dx = Math.abs(hx);
        int dy = Math.abs(hy);
        float error = 0;
        float derror = (float)dy / dx;
        int y = a.y;
        int diry = hy;
        if (diry > 0) diry = 1;
        if(diry < 0) diry = -1;

        Vertexes = new Vertex[Math.abs(hx)];
        int x_step = 1;
        if(hx < 0)
            x_step = -1;
        for(int x = a.x, i = 0; x != b.x; x += x_step, i++)
        {
            Vertexes[i] = new Vertex(x,y);
            error += derror;
            if(error >= 0.5)
            {
                y += diry;
                error -= 1.0;
            }
        }
    }

    private void buildBresenhamIntegral(Vertex a, Vertex b)
    {
        int
                hx = b.x - a.x,
                hy = b.y - a.y,
                dx = Math.abs(hx),
                dy = Math.abs(hy),
                error = 0,
                derror = dy,
                y = a.y,
                diry = hy;
        if (diry > 0) diry = 1;
        if (diry < 0) diry = -1;

        Vertexes = new Vertex[Math.abs(hx)];
        int x_step = 1;
        if(hx < 0)
            x_step = -1;
        for (int x = a.x, i = 0; x != b.x; x += x_step, i++)
        {
            Vertexes[i] = new Vertex(x, y);
            error += derror;
            if (2 * error >= dx)
            {
                y += diry;
                error -= dx;
            }
        }
    }
}
