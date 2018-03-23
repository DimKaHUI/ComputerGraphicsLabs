package Images;

import java.awt.*;

public class MulticolorLine extends PixImage
{
    private Color base;
    private Color back;
    private Graphics gr;
    private Vertex start, end;
    private int levels;

    public MulticolorLine(Vertex start, Vertex end,  Color baseColor, Color backColor, Container canvas, int levels)
    {
        base = baseColor;
        back = backColor;
        this.start = start;
        this.end = end;

        gr = canvas.getGraphics();
        //gr.translate(canvas.getWidth() / 2, canvas.getHeight() / 2);
        this.levels = levels;
    }
    private void plot(int x, int y, float c)
    {
        int r = base.getRed();
        int g = base.getGreen();
        int b = base.getBlue();
        r += (1-c) * (back.getRed() - r);
        g += (1-c) * (back.getGreen() - g);
        b += (1-c) * (back.getBlue() - b);

        if(c <= 1)
            gr.setColor(new Color(r, g, b));
        else
            gr.setColor(base);
        gr.drawOval(x - 1, -y - 1, 1, 1);
        gr.setColor(new Color(r, g, b));
        x = PixImage.PixelSize * x;
        y = PixImage.PixelSize * y;
        //gr.fillOval(x - PixImage.PixelSize / 2, -y - PixImage.PixelSize / 2, PixImage.PixelSize, PixImage.PixelSize);
        gr.drawLine(x, y, x, y);
    }

    private static void plot_timed(int x, int y, float c, int[] xp, int[] yp)
    {
        int r = 0;
        int g = 0;
        int b = 0;
        r += (1-c) * (255 - r);
        g += (1-c) * (255 - g);
        b += (1-c) * (255 - b);
        new Color(r, g, b);
        xp[0] = x;
        yp[0] = y;
    }

    private static int ipart(float x)
    {
        return (int)x;
    }

    private static float fpart(float x)
    {
        return Math.abs(x - ipart(x));
    }

    private static int sign1(float x)
    {
        if(x >= 0)
            return 1;
        return -1;
    }

    public void draw(Container canvas)
    {
        int x = start.x;
        int y = start.y;

        int dx = end.x - start.x;
        int dy = end.y - start.y;

        if(dx == 0 && dy == 0)
        {
            plot(x, y, 1);
            return;
        }

        int sx = (int)Math.signum(dx);
        int sy = (int)Math.signum(dy);
        dx = Math.abs(dx);
        dy = Math.abs(dy);

        int fl = 0;

        if (dy > dx)
        {
            fl = 1;
            int tmp = dx;
            dx = dy;
            dy = tmp;
        }

        float f = (float)levels / 2.0f;
        float m = (float)levels * ((float)dy / (float)dx);
        float w = (float)levels - m;

        for(int i = 0; i < dx; i++)
        {
            plot(x, y, f / (float)levels);
            if(f < w)
            {
                if (fl == 0)
                    x += sx;
                else
                    y += sy;
                f += m;
            }
            else
            {
                y += sy;
                x += sx;
                f -= w;
            }

        }

    }

    public static void buildlowStep_timed(int[] xp, int[] yp, Vertex start, Vertex end)
    {
        int x = start.x;
        int y = start.y;

        int dx = end.x - start.x;
        int dy = end.y - start.y;

        if(dx == 0 && dy == 0)
        {
            plot_timed(x, y, 1, xp, yp);
            return;
        }

        int sx = (int)Math.signum(dx);
        int sy = (int)Math.signum(dy);
        dx = Math.abs(dx);
        dy = Math.abs(dy);

        int fl = 0;

        if (dy > dx)
        {
            fl = 1;
            int tmp = dx;
            dx = dy;
            dy = tmp;
        }

        float f = (float)8 / 2.0f;
        float m = (float)8 * ((float)dy / (float)dx);
        float w = (float)8 - m;

        for(int i = 0; i < dx; i++)
        {
            plot_timed(x, y, f / (float)8, xp, yp);
            if(f < w)
            {
                if (fl == 0)
                    x += sx;
                else
                    y += sy;
                f += m;
            }
            else
            {
                y += sy;
                x += sx;
                f -= w;
            }

        }

    }
}
