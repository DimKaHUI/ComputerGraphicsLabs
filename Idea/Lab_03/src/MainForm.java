import Images.*;

import javax.swing.*;
import javax.swing.plaf.basic.BasicListUI;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.util.ArrayList;

public class MainForm extends JFrame
{
    private JPanel rootPanel;
    private JComboBox algChooser;
    private JPanel drawingPanel;
    private JButton proceedButton;
    private JTextField ysBox;
    private JTextField xeBox;
    private JTextField yeBox;
    private JTextField xsBox;
    private JComboBox colorChooser;
    private JButton clearButton;
    private JButton circleButton;
    private JTextField radiusBox;
    private JTextField angleStepBox;
    private JComboBox backgroundColorBox;
    private JButton applyBackButton;
    private JButton timeCheckerButton;
    private JButton stepCountButton;
    private JPanel drawingSpace;

    private ArrayList<PixImage> images = new ArrayList<>();

    public MainForm()
    {
        // Setting up procedures
        proceedButton.addActionListener(new proceedListener());
        clearButton.addActionListener(new clearListener());
        circleButton.addActionListener(new circleListener());
        applyBackButton.addActionListener(new applyBackListener());
        timeCheckerButton.addActionListener(new timeCheckerListener());
        stepCountButton.addActionListener(new stepCounterListener());

        // Displaying UI
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(1600, 1000);
        setContentPane(rootPanel);
        setVisible(true);
    }

    private void drawAxises()
    {
        Graphics gr = drawingSpace.getGraphics();
        gr.setColor(Color.lightGray);
        int height = drawingSpace.getHeight();
        int width = drawingSpace.getWidth();
        gr.translate(width / 2, height / 2);
        gr.drawLine(0, height, 0, -height);
        gr.drawLine(-width, 0, width, 0);
        gr.setColor(Color.BLACK);
        gr.drawString("X", width / 2 - 10, 10);
        gr.drawString("Y", 10, -height / 2 + 30);
    }

    private void clearScr(Color color)
    {
        Graphics gr = drawingSpace.getGraphics();
        //
        gr.clearRect(0, 0, drawingSpace.getWidth() , drawingSpace.getHeight());
        gr.setColor(color);
        gr.fillRect(0, 0, drawingSpace.getWidth() , drawingSpace.getHeight());
        //drawingSpace.setBackground(color);
        drawAxises();
    }

    private void addLine(Vertex a, Vertex b, Color color, Line.Algorithm alg)
    {
        images.add(new Line(a, b, alg, color));
        clearScr(parseColor(backgroundColorBox));
        for(PixImage img : images)
        {
            img.draw(drawingSpace);
        }
    }

    private Color parseColor(JComboBox box)
    {
        Color color;
        int item = box.getSelectedIndex();
        switch(item)
        {
        case 0:
            color = Color.red;
            break;
        case 1:
            color = Color.orange;
            break;
        case 2:
            color = Color.yellow;
            break;
        case 3:
            color = Color.green;
            break;
        case 4:
            color = Color.cyan;
            break;
        case 5:
            color = Color.blue;
            break;
        case 6:
            color = Color.magenta;
            break;
        case 7:
            color = Color.WHITE;
            break;
        case 8:
            color = Color.BLACK;
            break;
        default:
            color = Color.BLACK;
        }
        return color;
    }

    private Line.Algorithm parseAlg()
    {
        Line.Algorithm alg;
        int item = algChooser.getSelectedIndex();
        switch(item)
        {
        case 0:
            alg = Line.Algorithm.INTEGRAL;
            break;
        case 1:
            alg = Line.Algorithm.BRESENHAM_FLOAT;
            break;
        case 2:
            alg = Line.Algorithm.BRESENHAM_INTEGRAL;
            break;
        case 3:
            alg = Line.Algorithm.BRESENHAM_LOW_STEP;
            break;
        default:
            alg = Line.Algorithm.INTEGRAL;
        }
        return alg;
    }

    public class clearListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            images.clear();
            clearScr(Color.WHITE);
        }
    }

    public class proceedListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            Vertex a, b;
            int X1, X2, Y1, Y2;
            try
            {
                X1 = Integer.parseInt(xsBox.getText());
                Y1 = Integer.parseInt(ysBox.getText());
                X2 = Integer.parseInt(xeBox.getText());
                Y2 = Integer.parseInt(yeBox.getText());
            }
            catch(NumberFormatException exception)
            {
                JOptionPane.showMessageDialog(rootPanel, "Некорректный формат ввода");
                return;
            }

            a = new Vertex(X1, Y1);
            b = new Vertex(X2, Y2);

            Line.Algorithm alg = parseAlg();
            Color color = parseColor(colorChooser);

            addLine(a, b, color, alg);
        }
    }

    public class circleListener implements ActionListener
    {

        @Override
        public void actionPerformed(ActionEvent e)
        {
            try
            {
                int radius = Integer.parseInt(radiusBox.getText());
                double step = Float.parseFloat(angleStepBox.getText());
                step = Math.toRadians(step);
                Vertex start = new Vertex(0, 0);
                Line.Algorithm alg = parseAlg();
                Color color = parseColor(colorChooser);
                for (float a = 0; a <= Math.PI * 2; a += step)
                {
                    double x = radius * Math.cos(a);
                    double y = radius * Math.sin(a);
                    Vertex end = new Vertex((int) x, (int) y);
                    images.add(new Line(start, end, alg, color));
                }
                clearScr(parseColor(backgroundColorBox));
                for (PixImage img : images)
                {
                    img.draw(drawingSpace);
                }
            }
            catch (NumberFormatException ex)
            {
                JOptionPane.showMessageDialog(rootPanel, "Некорректный формат ввода");
                return;
            }
        }
    }

    public class applyBackListener implements ActionListener
    {

        @Override
        public void actionPerformed(ActionEvent e)
        {
            clearScr(parseColor(backgroundColorBox));
            for(PixImage img : images)
                img.draw(drawingSpace);
        }
    }

    public class timeCheckerListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            long values[] = new long[4];
            clearScr(Color.WHITE);

            long sec;

            sec = 0;
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
                    new Line(start, end, Line.Algorithm.INTEGRAL, Color.BLACK);
                    tmp = System.nanoTime() - tmp;
                    sec += tmp;
                }
            }
            values[0] = sec;

            sec = 0;
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
                    new Line(start, end, Line.Algorithm.BRESENHAM_FLOAT, Color.BLACK);
                    tmp = System.nanoTime() - tmp;
                    sec += tmp;
                }
            }
            values[1] = sec;

            sec = 0;
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
                    new Line(start, end, Line.Algorithm.BRESENHAM_INTEGRAL, Color.BLACK);
                    tmp = System.nanoTime() - tmp;
                    sec += tmp;
                }
            }
            values[2] = sec;

            sec = 0;
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
                    new Line(start, end, Line.Algorithm.BRESENHAM_LOW_STEP, Color.BLACK);
                    tmp = System.nanoTime() - tmp;
                    sec += tmp;
                }
            }
            values[3] = sec;


            Barchart.DrawBarchart(values, new  String[]{"Целочисленный", "Брезенхема (вещ)", "Брезенхема (цел)", "Брезенхема (сглаж)"}, "нс",50, Color.blue, drawingSpace);
        }
    }

    public class stepCounterListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            clearScr(Color.WHITE);
            int count = drawingSpace.getWidth() / 2 / 10; // Количество единиц в оси
            float arg_x[] = new float[count];
            float arg_y[] = new float[count];
            double angleStep = 90.0f / count;
            double angle = 0;
            Vertex start = new Vertex(0, 0);
            for(int i = 0; i < count; i++)
            {
                arg_x[i] = (float)angle;
                angle += angleStep;
                int x = (int)(100 * Math.cos(Math.toRadians(angle)));
                int y = (int)(100 * Math.sin(Math.toRadians(angle)));
                Vertex end = new Vertex(x, y);
                arg_y[i] = new Line(start, end, parseAlg(), parseColor(colorChooser)).countSteps();
            }

            // Finding maximum
            float y_max = arg_y[arg_y.length - 1];
            for(int i = arg_y.length - 1; i >= 0; i--)
                if(arg_y[i] > y_max)
                    y_max = arg_y[i];

            float y_scale = (drawingSpace.getHeight() - 50) / 2 / y_max;
            float x_scale = (drawingSpace.getWidth()) / 2 / 90;

            Graph graph = new Graph(arg_x, arg_y, x_scale, y_scale, 5, Color.RED);
            graph.draw(drawingSpace);
            Graphics gr = drawingSpace.getGraphics();
            gr.drawString("Длина отрезка: " + 100, drawingSpace.getWidth() / 2 - 50, drawingSpace.getHeight() / 2 + 50);
        }
    }
}
