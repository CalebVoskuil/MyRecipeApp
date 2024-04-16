# MyRecipeApp
This is part one of my PROG6221 POE. I have built a console application that allows a user to enter the details for a recipe of their choice such as the ingredients, the unit of measurement and the quantity. This data will be stored to an array to allow the user to access it again. The user is also able to scale the quantity of ingredients by any factor they wish and have the new recipe displayed.

Table of Contents
Installation
Classes
References 

# Installation
My application was built using the .NET 4.8 Framework for C# in MicroSoft Visual Studio.
MicroSoft Visual studio is free to install and can be found on the official website for microsft.
Once microsoft visual studio is installed you can clone the repository directly to visual studio and open it.
once you have opened the file there will be a green arrow at the top of the window, once you click that the code will compile and run

# Classes
i have 3 classes each handling different areas of the console app
the first class is the main method which simply has an object in it to call on the next class, the menuHandler class
The menuHandler class has a switch statement in it for all the various choice the user could make regarding their recipe. Each case of the switch function calls on another method in the final class, the ingredients class.
This class has the bulk of the code in it containing the methods that handle the user input and storing them into arrays, scaling the quantities by a certain factor, resetting the quantities back to the original and displaying the recipe back to the user in a neat format.

# References 
below is a list of all the videos i used as help as well as the link to my repository
https://youtu.be/GhQdlIFylQ8?si=cKIYSWunHDC1csWj
https://youtu.be/gfkTfcpWqAY?si=3BredEtmLRK-IVXr
https://youtu.be/wxznTygnRfQ?si=YdSPdyKekHStCUFz
https://github.com/CalebVoskuil/MyRecipeApp.git
