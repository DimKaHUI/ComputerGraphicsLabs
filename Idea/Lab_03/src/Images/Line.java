package Images;

import java.awt.*;

public class Line extends PixImage
{
    public enum Algorithm
    {
        INTEGRAL, BRESENHAM_INTEGRAL, BRESENHAM_FLOAT, BRESENHAM_LOW_STEP, LIB
    }

    private Algorithm alg;
    private Vertex a, b;

    public Line(Vertex start, Vertex end, Algorithm alg, Color color)
    {
        this.alg = alg;
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
        case LIB:
            a = start;
            b = end;
            break;
        }
    }

    @Override
    public void draw(Container canvas)
    {
        if(alg != Algorithm.LIB)
            super.draw(canvas);
        else
        {
            Graphics gr = canvas.getGraphics();
            gr.translate(canvas.getWidth() / 2, canvas.getHeight() / 2);
            gr.setColor(Color);
            gr.drawLine(a.x, a.y, b.x, b.y);
        }
    }

    public static long GetTime(Algorithm alg)
    {
        long sec = 0;
        int xp[] = new int[150];
        int yp[] = new int[150];
        for(int i = 0; i < 10000; i ++)
        {
            double angleStep = 0.1;
            Vertex start = new Vertex(0, 0);
            for(double j = 0; j < Math.PI * 2; j += angleStep )
            {
                int x = (int) (100 * Math.cos(j));
                int y = (int) (100 * Math.sin(j));
                Vertex end = new Vertex(x, y);
                long tmp = System.nanoTime();
                switch(alg)
                {
                case INTEGRAL:
                    buildIntegral_timed(xp, yp, start, end);
                    break;
                case BRESENHAM_INTEGRAL:
                    buildBresenhamIntegral_timed(xp, yp, start, end);
                    break;
                case BRESENHAM_FLOAT:
                    buildBresenhamFloat_timed(xp, yp, start, end);
                    break;
                case BRESENHAM_LOW_STEP:
                    MulticolorLine.buildlowStep_timed(xp, yp, start, end);
                    break;
                }
                tmp = System.nanoTime() - tmp;
                sec += tmp;
            }
        }
        return sec / 10000;
    }

    public int countSteps()
    {
        int res = 0;
        int prevX = Vertexes[0].x;
        int prevY = Vertexes[0].y;
        for(int i = 0; i < Vertexes.length; i++)
        {
            if(!(prevX == Vertexes[i].x || prevY == Vertexes[i].y))
            {
                res++;
            }
            prevX = Vertexes[i].x;
            prevY = Vertexes[i].y;
        }
        return res;
    }

    private static void buildIntegral_timed(int xp[], int yp[], Vertex start, Vertex end)
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
        for(int i = 0; i < l; i++)
        {
            x += sx;
            y += sy;
            xp[i] = (int)x;
            yp[i] = (int)y;
        }
    }

    private static void buildBresenhamFloat_timed(int xp[], int yp[], Vertex a, Vertex b)
    {
        int
                x = a.x,
                y = a.y,
                dx = b.x - a.x,
                dy = b.y - a.y,
                //sx = sign(dx),
                //sy = sign(dy);
        sx, sy;
        if(dx > 0)
            sx = 1;
        else if (dx == 0)
            sx = 0;
        else
            sx = -1;

        if(dy > 0)
            sy = 1;
        else if (dy == 0)
            sy = 0;
        else
            sy = -1;

        boolean exchange = false;

        if(dy < 0)
            dy = -dy;

        if(dx < 0)
            dx = - dx;

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
            for(int i = 0; x != b.x; x += sx, i++)
            {
                xp[i] = x;
                yp[i] = y;
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
            for(int i = 0; y != b.y; y += sy, i++)
            {
                xp[i] = x;
                yp[i] = y;
                e += m;
                if(e >= 0.5)
                {
                    x += sx;
                    e -= 1.0f;
                }
            }
        }
    }

    private static void buildBresenhamIntegral_timed(int xp[], int yp[], Vertex a, Vertex b)
    {
        int
                x = a.x,
                y = a.y,
                dx = b.x - a.x,
                dy = b.y - a.y,
                //sx = sign(dx),
                //sy = sign(dy);
                sx, sy;
        if(dx > 0)
            sx = 1;
        else if (dx == 0)
            sx = 0;
        else
            sx = -1;

        if(dy > 0)
            sy = 1;
        else if (dy == 0)
            sy = 0;
        else
            sy = -1;


        boolean exchange = false;
        if(dy < 0)
            dy = -dy;

        if(dx < 0)
            dx = - dx;
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
            for(int i = 0; x != b.x; x += sx, i++)
            {
                xp[i] = x;
                yp[i] = y;
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
            for(int i = 0; y != b.y; y += sy, i++)
            {
                xp[i] = x;
                yp[i] = y;
                e += m;
                if(2 * e >= dx)
                {
                    x += sx;
                    e -= dx;
                }
            }
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
            Vertexes[i] = new Vertex((int)Math.floor(x), (int)Math.floor(y));
        }
    }

    public static int sign(int val)
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
        if (dy > dx)
        {
            int t = dy;
            dy = dx;
            dx = t;
            exchange = true;
        }
        float m = (float) dy / dx;
        float e = 0.5f;

        if (!exchange)
        {
            Vertexes = new Vertex[dx];
            for (int i = 0; x != b.x; x += sx, i++)
            {
                Vertexes[i] = new Vertex(x, y);
                e += m;
                if (e >= 0.5)
                {
                    y += sy;
                    e -= 1.0f;
                }
            }
        } else
        {
            Vertexes = new Vertex[dx];
            for (int i = 0; y != b.y; y += sy, i++)
            {
                Vertexes[i] = new Vertex(x, y);
                e += m;
                if (e >= 0.5)
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
