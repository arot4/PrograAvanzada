from tkinter import *
from tkinter import ttk
import requests
import json

def accionBtn():
    response = requests.get("http://localhost/api/apimysql.php?x=" + codPost.get())
    data = response.json()
    listaCol["values"] = data['data']

root = Tk()
root.title("Codigo Postal")
root.geometry("400x400")

etiqueta0 = Label(root, text="Codigo Postal:")
etiqueta0.place(x=10, y=10)

codPost = Entry(root)
codPost.place(x=100, y=10)

buscarBtn = Button(root, text="Buscar", command=accionBtn)
buscarBtn.place(x=300, y=10)

etiqueta1 = Label(root, text="Colonias:")
etiqueta1.place(x=10, y=50)

listaCol = ttk.Combobox(root)
listaCol.place(x=100, y=50)




root.mainloop()

