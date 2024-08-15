# CarFactory Console Application Patika Dev Week 5 Final HomeWork

## Overview

The **CarFactory** console application is a simple project written in C# that simulates the process of creating and managing a list of cars. The application allows users to input car details such as serial number, brand, model, color, and door count. The production date is automatically assigned when a new car is created. It includes validation mechanisms to ensure that door count inputs are correct and that the program gracefully handles invalid inputs using exception handling and custom exception classes.

## Features

- **Car Creation:** Users can input details to create a car, including serial number, brand, model, color, and door count.
- **Automatic Production Date:** The production date is automatically set to the current date and time when a car is created.
- **Input Validation:** Ensures that the door count is either 2 or 4, and handles invalid inputs using a custom exception class.
- **Exception Handling:** Handles exceptions for non-numeric door count inputs and redirects users back to correct their input.
- **Custom Exception:** Implements a custom exception (`InvalidDoorCountException`) to handle invalid door count values.

## Technologies Used

- **C#:** The primary programming language used to build this console application.
- **.NET Core:** The application is built on the .NET Core platform.
- **Custom Exceptions:** Demonstrates the use of custom exceptions in C# to enforce specific validation rules.

## Installation and Setup

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/CarFactory.git


  ## How It Works
1- User Input: The application prompts the user to input various car details.

2- Door Count Validation: The program checks if the entered door count is numeric and either 2 or 4. If the input is invalid, the user is prompted to enter the value again.

3- Exception Handling: If a non-numeric value is entered for the door count, a FormatException is caught, and the user is redirected to enter a valid value. If a numeric value other than 2 or 4 is entered, a custom exception (InvalidDoorCountException) is thrown.

4- Car List Management: Valid car entries are added to a list, and the user is asked if they want to continue adding cars.

5-Production Date: Each car object is assigned a production date when it is created, which reflects the current date and time.

