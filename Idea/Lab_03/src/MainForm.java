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
    private JPanel drawingCanvas;
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

    private final int STEP_COUNT_LENGTH = 50;

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
        Dimension dim = Toolkit.getDefaultToolkit().getScreenSize();
        setSize(dim.width- 100, dim.height - 100);
        setTitle("Исследование алгоритмов построения прямых линий");

        setContentPane(rootPanel);
        setVisible(true);
    }

    private void drawAxises()
    {
        Graphics gr = drawingCanvas.getGraphics();
        gr.setColor(Color.lightGray);
        int height = drawingCanvas.getHeight();
        int width = drawingCanvas.getWidth();
        gr.translate(width / 2, height / 2);
        gr.drawLine(0, height, 0, -height);
        gr.drawLine(-width, 0, width, 0);
        gr.setColor(Color.BLACK);
        gr.drawString("X", width / 2 - 10, 10);
        gr.drawString("Y", 10, -height / 2 + 30);
    }

    private void clearScr(Color color)
    {
        Graphics gr = drawingCanvas.getGraphics();
        //
        gr.clearRect(0, 0, drawingCanvas.getWidth(), drawingCanvas.getHeight());
        gr.setColor(color);
        gr.fillRect(0, 0, drawingCanvas.getWidth(), drawingCanvas.getHeight());
        //drawingCanvas.setBackground(color);
        drawAxises();
    }

    private void addLine(Vertex a, Vertex b, Color color, Line.Algorithm alg)
    {
        if(alg != Line.Algorithm.BRESENHAM_LOW_STEP)
            images.add(new Line(a, b, alg, color));
        else
            images.add(new MulticolorLine(a, b, color, parseColor(backgroundColorBox), drawingCanvas));
        clearScr(parseColor(backgroundColorBox));
        for(PixImage img : images)
        {
            img.draw(drawingCanvas);
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
                    if(alg != Line.Algorithm.BRESENHAM_LOW_STEP)
                        images.add(new Line(start, end, alg, color));
                    else
                        images.add(new MulticolorLine(start, end, color, parseColor(backgroundColorBox), drawingCanvas));
                }
                clearScr(parseColor(backgroundColorBox));
                for (PixImage img : images)
                {
                    img.draw(drawingCanvas);
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
                img.draw(drawingCanvas);
        }
    }

    public class timeCheckerListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            long values[] = new long[4];
            clearScr(Color.WHITE);

            values[0] = Line.GetTime(Line.Algorithm.INTEGRAL);
            values[1] = Line.GetTime(Line.Algorithm.BRESENHAM_FLOAT);
            values[2] = Line.GetTime(Line.Algorithm.BRESENHAM_INTEGRAL);
            values[3] = Line.GetTime(Line.Algorithm.BRESENHAM_LOW_STEP);

            Barchart.DrawBarchart(values, new  String[]{"Целочисленный", "Брезенхема (вещ)", "Брезенхема (цел)", "Брезенхема (сглаж)"}, "нс",50, Color.blue, drawingCanvas);
        }
    }

    public class stepCounterListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            clearScr(Color.WHITE);
            int count = 100;
            float arg_x[] = new float[count];
            float arg_y[] = new float[count];
            double angleStep = 90.0f / count;
            double angle = 0;
            Vertex start = new Vertex(0, 0);
            for(int i = 0; i < count; i++)
            {
                arg_x[i] = (float)angle;
                angle += angleStep;
                int x = (int)(STEP_COUNT_LENGTH * Math.cos(Math.toRadians(angle)));
                int y = (int)(STEP_COUNT_LENGTH * Math.sin(Math.toRadians(angle)));
                Vertex end = new Vertex(x, y);
                Line.Algorithm alg = parseAlg();
                if(alg != Line.Algorithm.BRESENHAM_LOW_STEP)
                arg_y[i] = new Line(start, end, parseAlg(), parseColor(colorChooser)).countSteps();
                else
                    arg_y[i] = 0;
            }

            // Finding maximum
            float y_max = arg_y[arg_y.length - 1];
            for(int i = arg_y.length - 1; i >= 0; i--)
                if(arg_y[i] > y_max)
                    y_max = arg_y[i];

            float y_scale = drawingCanvas.getHeight() / 2 / y_max;
            float x_scale = drawingCanvas.getWidth() / 2 / 90;

            Graph graph = new Graph(arg_x, arg_y, x_scale, y_scale, 5, Color.RED);
            graph.draw(drawingCanvas);
            Graphics gr = drawingCanvas.getGraphics();
            gr.drawString("Длина отрезка: " + STEP_COUNT_LENGTH, drawingCanvas.getWidth() / 2 - 50, drawingCanvas.getHeight() / 2 + 50);
        }
    }
}
