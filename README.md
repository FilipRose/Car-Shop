# Car Shop Console Application Documentation
This documentation provides an overview of the "Car Shop Console" application, which is a simple console-based program for managing a car store's inventory and shopping cart.
The application is divided into three main classes: Program, Store, and Car.

## Program Class
### Main Method
The Program class contains the entry point of the application, the Main method.
It starts by initializing an instance of the Store class (s). The program then displays a welcome message and provides instructions for using the application.

## Functionality
The user is prompted to choose an action by calling the chooseAction method, which returns an integer representing the user's choice.

The user's choice is processed using a switch statement:

* Case 1: Add a New Car to the Inventory
The user is prompted to enter details for the new car, including car brand, model, and price.
A new Car object is created with the provided details and added to the CarList in the Store.
The current inventory is displayed using the printInventory method.

* Case 2: Add a Car to the Shopping Cart
The user is shown the current inventory using the printInventory method and prompted to choose a car by its index.
The chosen car is added to the ShoppingList in the Store.
The current shopping cart is displayed using the printShoppingCart method.

* Case 3: Checkout
The current shopping cart is displayed using the printShoppingCart method.
The total cost of the items in the shopping cart is calculated by calling the Checkout method in the Store.
The total cost is displayed to the user.
The user can continue to choose actions until they decide to quit by entering 0.

# Store Class
The Store class represents a car store and contains two properties: CarList and ShoppingList.

## Properties
CarList: This is a list of Car objects representing the car inventory in the store.

ShoppingList: This is a list of Car objects representing the items added to the shopping cart.

## Constructor
The class constructor initializes both the CarList and ShoppingList as new empty lists.

## Functionality
Checkout Method: This method calculates the total cost of the items in the shopping cart (ShoppingList) by summing up the prices of each car.
It then clears the shopping cart list and returns the total cost as a decimal.

# Car Class
The Car class represents a car item in the store's inventory.

## Properties
* CarBrand: This is a string property representing the car's brand.

* Model: This is a string property representing the car's model.

* Price: This is a decimal property representing the car's price.

## Constructors
Default Constructor: Initializes all properties to default values.

Parameterized Constructor: Initializes the properties with the provided values.

## ToString Method
The ToString method is overridden to provide a custom string representation of a Car object, displaying the car's brand, model, and price.

This concludes the documentation for the "Car Shop Console" application. The application allows users to manage a car store's inventory,
add cars to their shopping cart, and calculate the total cost of their items at checkout.
