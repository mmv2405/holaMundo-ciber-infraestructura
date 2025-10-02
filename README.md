Video del testing: https://drive.google.com/file/d/1q_5xNqoP2W5NDi8mU3_l21cqqMTBgvMI/view?usp=sharing
Archivos modificados: MauiApp1 -> MainPage.xaml && MainPage.xaml.cs


Abrir Visual Studio y crear un nuevo proyecto de tipo "Aplicación DESKTOP de WINFORMS"

Nombre del proyecto: "HolaMundo"

Incorporar a la vista dos campos de texto y un botón que validen la estructura de una contraseña, la contraseña deberá exigir:
 - Al menos una letra mayúscula
 - Al menos una letra minúscula
 - Al menos un símbolo
 - Al menos un número
Si la contraseña ingresada corresponde a la regla solicitada, la siguiente validación comprobará que el segundo campo contenga el mismo texto
Una vez que esto suceda deberá aparecer un MESSAGE BOX que diga "La contraseña ha sido validada"


Tu programa deberá contener:
Un evento click en el botón, que envía el formulario y que retorna la validación.
Una expresión regular (Regex) que valide la regla propuesta.


