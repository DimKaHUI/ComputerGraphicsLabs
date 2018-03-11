import Images.Line;
import Images.PixImage;
import Images.Vertex;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
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

    private ArrayList<PixImage> images = new ArrayList<>();

    public MainForm()
    {
        // Setting up procedures
        proceedButton.addActionListener(new proceedListener());
        clearButton.addActionListener(new clearListener());

        // Displaying UI
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(1600, 1000);
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

    private void addLine(Vertex a, Vertex b, Color color, Line.Algorithm alg)
    {
        images.add(new Line(a, b, alg, color));
        Graphics gr = drawingCanvas.getGraphics();
        gr.clearRect(0, 0, drawingCanvas.getWidth(), drawingCanvas.getHeight());
        drawAxises();
        for(PixImage img : images)
        {
            img.draw(drawingCanvas);
        }
    }

    public class clearListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            images.clear();
            Graphics gr = drawingCanvas.getGraphics();
            gr.clearRect(0, 0, drawingCanvas.getWidth(), drawingCanvas.getHeight());
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

            Line.Algorithm alg;
            int item = algChooser.getSelectedIndex();
            switch(item)
            {
            case 0:
                alg = Line.Algorithm.INTEGRAL;
                break;
            case 1:
                alg = Line.Algorithm.BREZENGHEM_INTEGRAL;
                break;
            case 2:
                alg = Line.Algorithm.BREZENGHEM_FLOAT;
                break;
            case 3:
                alg = Line.Algorithm.BREZENGHEM_LOW_STEP;
                break;
            default:
                alg = Line.Algorithm.INTEGRAL;
            }

            Color color;
            item = colorChooser.getSelectedIndex();
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
            default:
                color = Color.BLACK;
            }

            addLine(a, b, color, alg);
        }
    }

}
