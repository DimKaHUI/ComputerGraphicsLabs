package Images;

import java.awt.*;

public class Line extends PixImage
{
    public enum Algorithm
    {
        INTEGRAL, BREZENGHEM_INTEGRAL, BREZENGHEM_FLOAT, BREZENGHEM_LOW_STEP
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
        case BREZENGHEM_INTEGRAL:

            break;
        case BREZENGHEM_FLOAT:

            break;
        case BREZENGHEM_LOW_STEP:

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
}
