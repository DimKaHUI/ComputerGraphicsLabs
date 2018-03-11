package Images;

import java.awt.*;

public class Barchart
{

    public static void DrawBarchart(long values[], String labels[], String units, int bar_width, Color color, Component canvas)
    {
        int width = canvas.getWidth();
        int height = canvas.getHeight();
        int count = values.length;
        int space = (int)(width -  bar_width * count)/ count;

        Graphics gr = canvas.getGraphics();

        gr.clearRect(30, 30, width - 50, height - 50);
        gr.translate(0, height);

        gr.setColor(Color.gray);
        gr.fillRect(0,-100, width, height - 50);

        gr.setColor(color);

        float max_val = values[0];
        for(int i = 0; i < count; i++)
            if(values[i] > max_val)
                max_val = values[i];
        float scale = (height - 150) / max_val;

        int x = 100;
        for(int i = 0; i < count; i++)
        {
            int bar_height = (int)(values[i] * scale);
            gr.fillRect(x - bar_width, -bar_height - 100, bar_width, bar_height);
            gr.drawString(String.valueOf(values[i]) + " " + units, x - bar_width, -bar_height - 110);
            gr.drawString(labels[i], x - bar_width, -80);
            x+= space;
        }
    }
}
