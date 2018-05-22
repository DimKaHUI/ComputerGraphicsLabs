from tkinter import *
import math
import matplotlib.pyplot as plt
import time
import tkinter as tk
import tkinter.ttk as ttk
from tkinter import Tk, Canvas, PhotoImage


#  Константы и начальные параметры
X_CENTER = 510
Y_CENTER = 300
COLOR_BACKGROUND = "red"
COLOR_SEGMENT = "blue"
WIDTH = 1020
HEIGHT = 740
VERTEX_SIZE = 1
WIDTH_LINE = 1
CLEAR_FLAG = 0
#DELAY_TIME = 0.00000000000001
DELAY_TIME = 0

COLOR_FOND = 'white'


# Список вершин
vertex_list_x = []
vertex_list_y = []

# Список пикселей ребер
pixel_list_x = []
pixel_list_y = []

# Список пикселей вершин и ребер (общий)
pixel_list_x_global = []
pixel_list_y_global = []

pixel_map = []
for i in range(HEIGHT):
    pixel_map.append([])
    for j in range(WIDTH):
        pixel_map[i].append(COLOR_FOND)

def clear_pixel_map():
    global pixel_map
    for i in range(HEIGHT):
        for j in range(WIDTH):
            pixel_map[i][j] = COLOR_FOND

def list_for_pixel_map():
    global pixel_list_x
    global pixel_list_y
    for i in range(HEIGHT):
        for j in range(WIDTH):
            if pixel_map[i][j] == COLOR_BACKGROUND:
                pixel_list_x.append(j)
                pixel_list_y.append(i)


def round_school(x):
    i, f = divmod(x, 1)
    return int(i + ((f >= 0.5) if (x > 0) else (f > 0.5)))

def sign(x):
    if x > 0:
        return 1
    elif x < 0:
        return -1
    elif x == 0:
        return 0


def set_pixel(x, y, COLOR_SEGMENT):
    img.put(COLOR_SEGMENT, (x + X_CENTER, Y_CENTER - y))

def set_pixel_monitor(x, y, COLOR_SEGMENT):
    img.put(COLOR_SEGMENT, (x, y))


def check_vertex_inner(x1, y1, x2, y2, x, y):
    flag_vertex = True
    if x == x1 and y == y1:
        flag_vertex = False
    elif x == x2 and y == y2:
        flag_vertex = False
    elif y == y2:
        flag_vertex = False
    elif y == y1:
        flag_vertex = False
    elif COLOR_BACKGROUND == COLOR_FOND:
        flag_vertex = False
    elif pixel_map[y][x] != COLOR_FOND:
        flag_vertex = False

    return(flag_vertex)

#  Выбор цвета построения отрезка
def select_color_segment():
    global COLOR_SEGMENT
    global color_segment
    l = colors_1.get()
    if l == 1:
        COLOR_SEGMENT = color_segment[0][0]
    elif l == 2:
        COLOR_SEGMENT = color_segment[1][0]
    elif l == 3:
        COLOR_SEGMENT = color_segment[2][0]
    elif l == 4:
        COLOR_SEGMENT = color_segment[3][0]
    elif l == 5:
        COLOR_SEGMENT = color_segment[4][0]

#  Выбор цвета фона
def select_color_background():
    global COLOR_BACKGROUND
    global color_background

    l = colors_2.get()
    if l == 1:
        COLOR_BACKGROUND = color_background[0][0]
    elif l == 2:
        COLOR_BACKGROUND = color_background[1][0]
    elif l == 3:
        COLOR_BACKGROUND = color_background[2][0]
    elif l == 4:
        COLOR_BACKGROUND = color_background[3][0]
    elif l == 5:
        COLOR_BACKGROUND = color_background[4][0]

#  Рисуем фон
def draw():
    canvas.create_rectangle(0, 0, WIDTH, HEIGHT , fill='white')
    global img
    img = PhotoImage(width=WIDTH, height=HEIGHT)
    canvas.create_image((WIDTH // 2, HEIGHT // 2), image=img, state="normal")


#  Освобождение полотна от наложенных на него рисунков
def clean():
    global vertex_list_x
    global vertex_list_y
    global pixel_list_x
    global pixel_list_y
    global CLEAR_FLAG
    global pixel_list_x_global
    global pixel_list_y_global

    vertex_list_x = []
    vertex_list_y = []
    pixel_list_x = []
    pixel_list_y = []
    pixel_list_x_global = []
    pixel_list_y_global = []

    CLEAR_FLAG = 0
    clear_pixel_map()

    canvas.delete("all")
    draw()


def current_close():

    global vertex_list_x
    global vertex_list_y
    global pixel_list_x
    global pixel_list_y
    global pixel_list_x_global
    global pixel_list_y_global

    #  Добавили все точки к глобальным спискам
    close_figure()
    vertex_weight()

    pixel_list_x_global.extend(pixel_list_x)
    pixel_list_y_global.extend(pixel_list_y)

    #  Освободились от предыдущих данных
    vertex_list_x = []
    vertex_list_y = []
    pixel_list_x = []
    pixel_list_y = []



def Bresenham(x1, y1, x2, y2):
    global img
    global pixel_list_x  # Список пикселей (x)
    global pixel_list_y  # Список пикселей (y)
    global pixel_map  # Матрица пикселей

    flag = False  # Флаг просмотра горизонтального ребра
    if y1 != y2:
        flag = True

    flag_y = True  # Флаг учета изменения покселя (y)

    dx = int(x2 - x1)
    dy = int(y2 - y1)
    sx = sign(dx)
    sy = sign(dy)
    dx = abs(dx)
    dy = abs(dy)

    swap = False
    if (dy <= dx):
        swap = False
    else:
        swap = True
        dx, dy = dy, dx


    e = int(2 * dy - dx)
    x = int(x1)
    y = int(y1)


    for i in range(dx + 1):
        set_pixel_monitor(x, y, COLOR_BACKGROUND)

        if flag == True and check_vertex_inner(x1, y1, x2, y2, x, y) and flag_y == True:
            pixel_list_x.append(x)
            pixel_list_y.append(y)
            flag_y = False

        if (e >= 0):
            if (swap):
                x += sx
            else:
                y += sy
                flag_y = True
            e = e - 2 * dx
        if (e < 0):
            if (swap):
                y += sy
                flag_y = True
            else:
                x += sx
            e = e + 2 * dy



# Ввод данных с мыши
def draw_circle(event):
    global vertex_list_x
    global vertex_list_y
    global pixel_map  # Матрица пикселей

    print(event.x, event.y)
    set_pixel_monitor(int(event.x), int(event.y), COLOR_BACKGROUND)
    vertex_list_x.append(event.x)  # Добавляем координаты вершин с список вершин
    vertex_list_y.append(event.y)
    pixel_map[event.y][event.x] = COLOR_BACKGROUND

    curr_len = len(vertex_list_x)
    if curr_len >= 2 and COLOR_BACKGROUND != COLOR_FOND:

        Bresenham(vertex_list_x[curr_len-1], vertex_list_y[curr_len-1],
                  vertex_list_x[curr_len-2], vertex_list_y[curr_len-2])

        canvas.create_line(vertex_list_x[curr_len-1], vertex_list_y[curr_len-1],
                          vertex_list_x[curr_len-2], vertex_list_y[curr_len-2],  fill=COLOR_BACKGROUND,
                          width=WIDTH_LINE)


# Ввод данных с клавиатуры
def draw_circle_keyboard(x, y):
    global vertex_list_x
    global vertex_list_y
    global pixel_map  # Матрица пикселей

    vertex_list_x.append(x)  # Добавляем координаты вершин с список вершин
    vertex_list_y.append(y)
    set_pixel_monitor(int(x), int(y), COLOR_BACKGROUND)
    pixel_map[y][x] = COLOR_BACKGROUND

    curr_len = len(vertex_list_x)
    if curr_len >= 2 and COLOR_BACKGROUND != COLOR_FOND:
        Bresenham(vertex_list_x[curr_len - 1], vertex_list_y[curr_len - 1],
                  vertex_list_x[curr_len - 2], vertex_list_y[curr_len - 2])

        canvas.create_line(vertex_list_x[curr_len-1], vertex_list_y[curr_len-1],
                          vertex_list_x[curr_len-2], vertex_list_y[curr_len-2],  fill=COLOR_BACKGROUND,
                           width=WIDTH_LINE)

    print(x, y)

# Замкнуть фигуру
def close_figure():
    curr_len = len(vertex_list_x)
    if curr_len >= 2 and COLOR_BACKGROUND != COLOR_FOND:
        Bresenham(vertex_list_x[curr_len - 1], vertex_list_y[curr_len - 1],
                  vertex_list_x[0], vertex_list_y[0])

        canvas.create_line(vertex_list_x[curr_len-1], vertex_list_y[curr_len-1],
                          vertex_list_x[0], vertex_list_y[0],  fill=COLOR_BACKGROUND,
                           width=WIDTH_LINE)


def check_horizontal_ext(x, y):
    initial = 0
    min = 0
    max = 0
    for i in range(0, len(pixel_list_y)):
        if pixel_list_y[i] == y:
            if initial == 0:
                initial = 1
                min = pixel_list_x[i]
                max = pixel_list_x[i]

            if pixel_list_x[i] < min:
                min = pixel_list_x[i]

            if pixel_list_x[i] > max:
                max = pixel_list_x[i]

    if max == x or min == x:
        return 0
    else:
        return 1

# Учесть экстремумы
def erase_element(x, y):
    global pixel_list_x
    global pixel_list_y

    for i in range(len(pixel_list_y)):
        if pixel_list_y[i] == y and pixel_list_x[i] == x:
            pixel_list_x.pop(i)
            pixel_list_y.pop(i)
            break


def vertex_weight():
    global pixel_list_x
    global pixel_list_y

    new_list_x = []
    new_list_y = []

    #  Добавили негоризонтальные вершины в список new_list
    for i in range(0, len(vertex_list_x)-1):
        if vertex_list_y[i+1] != vertex_list_y[i]:
            new_list_x.append(vertex_list_x[i])
            new_list_y.append(vertex_list_y[i])

        else:
            if vertex_list_y[i] != pixel_list_y[i-1]:
                new_list_x.append(vertex_list_x[i])
                new_list_y.append(vertex_list_y[i])

    # Учли последнюю вершину
    if vertex_list_y[-1] != vertex_list_y[0]:
        new_list_x.append(vertex_list_x[-1])
        new_list_y.append(vertex_list_y[-1])
    else:
        if vertex_list_y[-1] != vertex_list_y[-2]:
            new_list_x.append(vertex_list_x[-1])
            new_list_y.append(vertex_list_y[-1])


    #  Вершины по 1 разу добавляем в список
    for i in range(0, len(new_list_y)):
        pixel_list_x.append(new_list_x[i])
        pixel_list_y.append(new_list_y[i])

    # принадлежащие концам горизонтального ребра еще по разу
    for i in range(0, len(new_list_y)-1):
        if new_list_y[i] == new_list_y[i+1]:
            pixel_list_x.append(new_list_x[i])
            pixel_list_y.append(new_list_y[i])
        if new_list_y[i] == new_list_y[i-1]:
            pixel_list_x.append(new_list_x[i])
            pixel_list_y.append(new_list_y[i])

    # Отдельно для последней вершины
    if new_list_y[len(new_list_y)-1] == new_list_y[0]:
        pixel_list_x.append(new_list_x[len(new_list_y)-1])
        pixel_list_y.append(new_list_y[len(new_list_y)-1])

    if new_list_y[len(new_list_y)-1] == new_list_y[len(new_list_y)-2]:
        pixel_list_x.append(new_list_x[len(new_list_y) - 1])
        pixel_list_y.append(new_list_y[len(new_list_y) - 1])




    #  Горизонтальные "экстремумы" учитываем по особому:
    i = 0
    while i < len(new_list_y)-2:
        if new_list_y[i] == new_list_y[i+1]:
            if (new_list_y[i-1] > new_list_y[i] and new_list_y[i+2] < new_list_y[i]) or\
                    (new_list_y[i-1] < new_list_y[i] and new_list_y[i+2] > new_list_y[i]):
                if new_list_x[i] > new_list_x[i+1]:
                    erase_element(new_list_x[i], new_list_y[i])
                else:
                    erase_element(new_list_x[i+1], new_list_y[i+1])
        i = i + 1

    #  Предпоследняя вершина:
    if new_list_y[len(new_list_y)-2] == new_list_y[len(new_list_y)-1]:
        i = len(new_list_y)-2
        if (new_list_y[i - 1] > new_list_y[i] and new_list_y[0] < new_list_y[i]) or \
                (new_list_y[i - 1] < new_list_y[i] and new_list_y[0] > new_list_y[i]):
            if new_list_x[i] > new_list_x[i + 1]:
                erase_element(new_list_x[i], new_list_y[i])
            else:
                erase_element(new_list_x[i+1], new_list_y[i+1])

    #  Последняя вершина:
    if new_list_y[len(new_list_y)-1] == new_list_y[0]:
        i = len(new_list_y)-1
        if (new_list_y[i - 1] > new_list_y[i] and new_list_y[1] < new_list_y[i]) or \
                (new_list_y[i - 1] < new_list_y[i] and new_list_y[1] > new_list_y[i]):
            if new_list_x[i] > new_list_x[i + 1]:
                erase_element(new_list_x[i], new_list_y[i])
            else:
                erase_element(new_list_x[0], new_list_y[0])






    #  Локальные экстремумы
    for i in range(1, len(vertex_list_x) - 1):
        if vertex_list_y[i] > vertex_list_y[i - 1] and vertex_list_y[i] > vertex_list_y[i + 1]:
            pixel_list_x.append(vertex_list_x[i])
            pixel_list_y.append(vertex_list_y[i])

        elif vertex_list_y[i] < vertex_list_y[i - 1] and vertex_list_y[i] < vertex_list_y[i + 1]:
            pixel_list_x.append(vertex_list_x[i])
            pixel_list_y.append(vertex_list_y[i])

    #  Для первой
    if vertex_list_y[0] > vertex_list_y[1] and vertex_list_y[0] > vertex_list_y[-1]:
        pixel_list_x.append(vertex_list_x[0])
        pixel_list_y.append(vertex_list_y[0])

    elif vertex_list_y[0] < vertex_list_y[1] and vertex_list_y[0] < vertex_list_y[-1]:
        pixel_list_x.append(vertex_list_x[0])
        pixel_list_y.append(vertex_list_y[0])

    # Для последней
    if vertex_list_y[len(vertex_list_x) - 1] > vertex_list_y[0]\
            and vertex_list_y[len(vertex_list_x) - 1] > vertex_list_y[len(vertex_list_x) - 2]:
        pixel_list_x.append(vertex_list_x[len(vertex_list_x) - 1])
        pixel_list_y.append(vertex_list_y[len(vertex_list_x) - 1])

    elif vertex_list_y[len(vertex_list_x) - 1] < vertex_list_y[0] and vertex_list_y[len(vertex_list_x) - 1] < \
            vertex_list_y[len(vertex_list_x) - 2]:
        pixel_list_x.append(vertex_list_x[len(vertex_list_x) - 1])
        pixel_list_y.append(vertex_list_y[len(vertex_list_x) - 1])




def fill_figure():
    global pixel_list_x
    global pixel_list_y
    global CLEAR_FLAG

    if CLEAR_FLAG == 0:
        root.update()
        CLEAR_FLAG = 1

    pixel_list_x = pixel_list_x_global
    pixel_list_y = pixel_list_y_global


    #  Сортируем по убыванию 'y'
    for j in range(0, len(pixel_list_x)):
        for i in range(0, len(pixel_list_x) - 1):
            if pixel_list_y[i] < pixel_list_y[i+1]:
                tmp = pixel_list_x[i]
                pixel_list_x[i] = pixel_list_x[i+1]
                pixel_list_x[i+1] = tmp

                tmp = pixel_list_y[i]
                pixel_list_y[i] = pixel_list_y[i+1]
                pixel_list_y[i+1] = tmp

    #  Сортируем по возрастанию 'x' у равных 'y'
    for j in range(0, len(pixel_list_x)):
        for i in range(0, len(pixel_list_x) - 1):
            if (pixel_list_y[i] == pixel_list_y[i+1]) and (pixel_list_x[i] > pixel_list_x[i+1]):
                tmp = pixel_list_x[i]
                pixel_list_x[i] = pixel_list_x[i + 1]
                pixel_list_x[i+1] = tmp


    # Заполнение строк внутри многоуголника цветом COLOR_SEGMENT
    i = 0
    while i < len(pixel_list_y)-1:
        x1 = pixel_list_x[i]
        x2 = pixel_list_x[i+1]

        x = pixel_list_x[i]
        y = pixel_list_y[i]


        x = x + 1
        while x <= (x2 - 1) and x >= x1:
            set_pixel_monitor(int(x), int(y), COLOR_SEGMENT)
            x = x + 1
        i = i + 2


def fill_figure_delay():
    global pixel_list_x
    global pixel_list_y
    global CLEAR_FLAG

    if CLEAR_FLAG == 0:
        root.update()
        CLEAR_FLAG = 1

    pixel_list_x = pixel_list_x_global
    pixel_list_y = pixel_list_y_global


    #  Сортируем по убыванию 'y'
    for j in range(0, len(pixel_list_x)):
        for i in range(0, len(pixel_list_x) - 1):
            if pixel_list_y[i] < pixel_list_y[i+1]:
                tmp = pixel_list_x[i]
                pixel_list_x[i] = pixel_list_x[i+1]
                pixel_list_x[i+1] = tmp

                tmp = pixel_list_y[i]
                pixel_list_y[i] = pixel_list_y[i+1]
                pixel_list_y[i+1] = tmp

    #  Сортируем по возрастанию 'x' у равных 'y'
    for j in range(0, len(pixel_list_x)):
        for i in range(0, len(pixel_list_x) - 1):
            if (pixel_list_y[i] == pixel_list_y[i+1]) and (pixel_list_x[i] > pixel_list_x[i+1]):
                tmp = pixel_list_x[i]
                pixel_list_x[i] = pixel_list_x[i + 1]
                pixel_list_x[i+1] = tmp


    # Заполнение строк внутри многоуголника цветом COLOR_SEGMENT
    i = 0
    while i < len(pixel_list_y)-1:
        x1 = pixel_list_x[i]
        x2 = pixel_list_x[i+1]

        x = pixel_list_x[i]
        y = pixel_list_y[i]


        x = x + 1
        while x <= (x2 - 1) and x >= x1:
            set_pixel_monitor(int(x), int(y), COLOR_SEGMENT)
            x = x + 1
            root.update()
            time.sleep(DELAY_TIME)
        i = i + 2






#  Пользовательский интерфейс
# Создаем рабочее окно
root = Tk()
#img = PhotoImage(width=WIDTH, height=HEIGHT)
root.title('Lab_03')
root.geometry('1420x740')


# Создаем полотно для рисования размера WIDTH и HEIGHT на рабочем окне с координаты (400, 0)
canvas = Canvas(root, width=WIDTH, height=HEIGHT, bg='#002')
canvas.place(x=400, y=0)
global img
draw()
canvas.create_image((WIDTH // 2, HEIGHT // 2), image=img, state="normal")

##################################################################################
#  Надписи перед кнопками на пустом фоне
#  Для окружности
label_name_circle = Label(root, text="Координаты новой точки")
label_name_circle.place(x=80, y=150)
label_point_x1 = Label(root, text='X:')  # x1
label_point_x1.place(x=30, y=170)
label_point_y1 = Label(root, text='Y:')
label_point_y1.place(x=130, y=170)


#  Создаем поля, куда что-то вводим.  Упаковывать лучше потом через pack
#  Для окружности
entry_x1 = Entry(root)
entry_x1.place(x=60, y=170, width=60)

entry_y1 = Entry(root)
entry_y1.place(x=160, y=170, width=60)


##########################################################################################

#  Создаем радиокнопки
color_segment = [("red", 1), ("green", 2), ("blue", 3), ("black", 4), ("white", 5)]
color_background = [("red", 1), ("green", 2), ("blue", 3), ("black", 4), ("white", 5)]

header = Label(text="Выберите цвет заливки       Выберете цвет границ")
header.place(x=30, y=10)

colors_1 = IntVar()
colors_2 = IntVar()

row = 0
for txt, val in color_segment:
    Radiobutton(text=txt, value=val, variable=colors_1, command=select_color_segment) \
        .place(x=30, y=30+row)
    row += 20

row = 0
for txt, val in color_background:
    Radiobutton(text=txt, value=val, variable=colors_2, command=select_color_background) \
        .place(x=180, y=30+row)
    row += 20

kek = 100
#  Кнопки
canvas.bind("<ButtonRelease-1>", draw_circle)  # Установка вершин с мыши

button1 = Button(root, text="Добавить точку по координатам с клавиатуры")
button1.bind("<ButtonRelease-1>", lambda event: draw_circle_keyboard((int)(entry_x1.get()),
                                                                     (int)(entry_y1.get())))
button1.place(x=30, y=230)

#button2 = Button(root, text="Замкнуть фигуру")
#button2.bind("<ButtonRelease-1>", lambda event: clear_pixel_map())
#button2.place(x=30, y=290)

button3 = Button(root, text="Закрасить многоугольник")
button3.bind("<ButtonRelease-1>", lambda event: fill_figure())
button3.place(x=30, y=330)

button4 = Button(root, text="Закрасить многоугольник с задержкой")
button4.bind("<ButtonRelease-1>",lambda event: fill_figure_delay())
button4.place(x=30, y=380)

button5 = Button(root, text="Замкнуть многоугольник")
button5.bind("<ButtonRelease-1>", lambda event: current_close())
button5.place(x=30, y=280)



button8 = Button(root, text="Очистить экран")
button8.bind("<ButtonRelease-1>", lambda event: clean())
button8.place(x=150, y=710)


root.mainloop()