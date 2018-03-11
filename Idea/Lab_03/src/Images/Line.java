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

    private int sign(int val)
    {
        if(val > 0)
            return 1;
        if(val < 0)
            return -1;
        return 0;
    }

    private void buildBresenhamFloat(Vertex a, Vertex b)
    {
        int
                x = a.x,
                y = a.y,
                dx = b.x - a.x,
                dy = b.y - a.y,
                sx = sign(dx),
                sy = sign(dy);

        boolean exchange = false;
        dy = Math.abs(dy);
        dx = Math.abs(dx);
        if(dy > dx)
        {
            int t = dy;
            dy = dx;
            dx = t;
            exchange = true;
        }
        float m = (float)dy/dx;
        float e = 0;

        if(!exchange)
        {
            Vertexes = new Vertex[dx];
            for(int i = 0; x != b.x; x += sx, i++)
            {
                Vertexes[i] = new Vertex(x, y);
                e += m;
                if(e >= 0.5)
                {
                    y += sy;
                    e -= 1.0f;
                }
            }
        }
        else
        {
            Vertexes = new Vertex[dx];
            for(int i = 0; y != b.y; y += sy, i++)
            {
                Vertexes[i] = new Vertex(x, y);
                e += m;
                if(e >= 0.5)
                {
                    x += sx;
                    e -= 1.0f;
                }
            }
        }

    }

    private void buildBresenhamIntegral(Vertex a, Vertex b)
    {
        int
                x = a.x,
                y = a.y,
                dx = b.x - a.x,
                dy = b.y - a.y,
                sx = sign(dx),
                sy = sign(dy);

        boolean exchange = false;
        dy = Math.abs(dy);
        dx = Math.abs(dx);
        if(dy > dx)
        {
            int t = dy;
            dy = dx;
            dx = t;
            exchange = true;
        }

        if(!exchange)
        {
            int e = 0;
            int m = dy;
            Vertexes = new Vertex[dx];
            for(int i = 0; x != b.x; x += sx, i++)
            {
                Vertexes[i] = new Vertex(x, y);
                e += m;
                if(2 * e >= dy)
                {
                    y += sy;
                    e -= dx;
                }
            }
        }
        else
        {
            int e = 0;
            int m = dy;
            Vertexes = new Vertex[dx];
            for(int i = 0; y != b.y; y += sy, i++)
            {
                Vertexes[i] = new Vertex(x, y);
                e += m;
                if(2 * e >= dx)
                {
                    x += sx;
                    e -= dx;
                }
            }
        }
    }
}
