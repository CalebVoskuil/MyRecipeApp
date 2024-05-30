
# Recipe App

Welcome to the Recipe App! This application allows you to manage your recipes, including entering recipe details, displaying recipes, scaling recipes, and more.

## Table of Contents
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Downloading the App](#downloading-the-app)
  - [Running the App](#running-the-app)
- [Classes and Functionalities](#classes-and-functionalities)
  - [MenuHandler](#menuhandler)
  - [Ingredient](#ingredient)
  - [Recipe](#recipe)
  - [MyIngredients](#myingredients)

## Getting Started

### Prerequisites

Before running the Recipe App, ensure you have the following prerequisites installed on your system:

- [.NET Core SDK](https://dotnet.microsoft.com/download) - The app is built using C# and requires the .NET Core SDK to be installed.

### Downloading the App

You can download the Recipe App source code from its GitHub repository. Follow these steps:

1. Visit the [Recipe App GitHub repository](https://github.com/example-user/recipe-app).
2. Click on the "Code" button and select "Download ZIP" to download the source code as a ZIP file.
3. Extract the contents of the ZIP file to a location of your choice.

### Running the App

To run the Recipe App in Microsoft Visual Studio, follow these steps:

1. Open Microsoft Visual Studio.
2. Navigate to "File" > "Open" > "Project/Solution" and select the solution file (`MyRecipeApp.sln`) from the extracted source code folder.
3. Once the solution is loaded, set the startup project to the `MyRecipeApp` project.
4. Build the solution by selecting "Build" > "Build Solution" from the menu.
5. Press `F5` or click on the "Start" button to run the application.
6. Follow the on-screen instructions to use the Recipe App.

## Classes and Functionalities

The Recipe App consists of several classes that handle different functionalities of the application.

### MenuHandler

The `MenuHandler` class manages the application menu and user interaction. It provides options for entering recipe details, displaying recipes, scaling recipes, resetting recipes, and exiting the application.

### Ingredient

The `Ingredient` class represents an ingredient in a recipe. It contains properties such as Name, Quantity, Unit, Calories, and FoodGroup. It also overrides the `ToString` method to provide a string representation of the ingredient.

### Recipe

The `Recipe` class represents a recipe. It contains properties for the recipe name, a list of ingredients (`List<Ingredient>`), and a list of steps. It also provides a method (`TotalCalories`) to calculate the total calories of the recipe.

### MyIngredients

The `MyIngredients` class manages the collection of recipes. It provides functionalities for entering recipe details, displaying recipes, scaling recipes, and resetting recipes. It also defines an event (`OnCaloriesExceeded`) to notify when the total calories of a recipe exceed a certain threshold.

---

# References 
below is a list of all the videos i used as help as well as the link to my repository
https://youtu.be/GhQdlIFylQ8?si=cKIYSWunHDC1csWj
https://youtu.be/gfkTfcpWqAY?si=3BredEtmLRK-IVXr
https://youtu.be/wxznTygnRfQ?si=YdSPdyKekHStCUFz
https://github.com/CalebVoskuil/MyRecipeApp.git
