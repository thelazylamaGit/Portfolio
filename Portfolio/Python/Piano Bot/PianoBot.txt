from pyautogui import *
import pyautogui
import time
import keyboard
import random
import win32api, win32con

#tile 1 x: 1153 y: 930
#tile 2 x: 1020 y: 930
#tile 3 x: 867  y: 930
#tile 4 x: 750  y: 930
#made for https://www.agame.com/game/magic-piano-tiles *must be in fullscreen and have all libs installed with correct screen coordinates*

def click(x,y):
    win32api.SetCursorPos((x,y))
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN,0,0)
    time.sleep(0.01)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP,0,0)

while keyboard.is_pressed('q') == False:

    if pyautogui.pixel(1153, 800) [0] == 0:
        click(1153,800)
    if pyautogui.pixel(1020, 800) [0] == 0:
        click(1020,800)
    if pyautogui.pixel(867, 800) [0] == 0:
        click(867,800)
    if pyautogui.pixel(750, 800) [0] == 0:
        click(750,800)
                           
