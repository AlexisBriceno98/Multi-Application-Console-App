# Alexis KyhProject1
Hey, This is my application called AP1 (Alexis Project 1) in this application we have 3 main programs that you might find useful.

In the main menu you can chose what you want to do:

You can calculate the area and perimeter of a Rectangle, Parallellogram, Triangle or Rhombus. 
You can calculate a mathematic problem with the help of 6 different arithmetic operations.
Lastly, for some fun, there's the option to play the classic game of Rock, Paper, Scissors against the computer.

All values are stored in a database called AlexisProject1, using C# Entity Framework

I've put a lot of time and effort into making this system error-free.
I used the Try, Catch, method in every while() as well as creating a generic error message that got personalized with colors for a more dynamic experience.

I am trying to achieve a clean menu for every application, thats why I am using several classes and calling in different methods.
Since there can be a lot of options I used a switch{} in every menu, this makes the code a lot cleaner.

I have a lot of classes but they are saved in a way that are easy to find.
Every program has an own folder, in the folders I have create a class with only get; set;, the other one is for CRUD (where it's needed) and the last one is where I put my code and create the necessary to make it work.

A good example is my Calculator, I have a class where I have my get; set; with the required information that will go to the database.
Then I have my "CalculatorCrud", here I coded everything regarding CRUD. 
Here I can start new calculations, read calculations, update a calculation and the values with the help of the ID and I can delete a calculation, also with the help of the ID.
I also created a "CalculatorCreation", here is where I created my methods for every arithmetic operation, and I call all the functions that I need to my main Calculator program called "CalculatorMenu" which is controlled by a switch.

All of this classes are also running my error handling method with Try{} catch{} and the generic error message, which results in an application that can't crash.

Both Calculator and Shapes are using the same "method" which is to have several classes and call the needed methods to the for example "ShapeMenu" or "CalculatorMenu".
I did the same for the RPS game but the only difference is that I didn't create a CRUD class here with their functions.

Enjoy AP1!
