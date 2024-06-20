# Design Patterns Project

## 🌟 Introduction
Welcome to the **Design Patterns Project**! This project is a comprehensive guide and learning resource for various design patterns used in software development. Design patterns are proven solutions to common problems in software design. They are like blueprints that can be customized to solve particular design problems in your code.

## 📚 Table of Contents
- [Introduction](#-introduction)
- [Installation](#-installation)
- [Design Patterns](#-design-patterns)
  - [Creational Patterns](#creational-patterns)
  - [Structural Patterns](#structural-patterns)
  - [Behavioral Patterns](#behavioral-patterns)
- [Contact](#-contact)

## 🛠 Installation
To get started with the project, clone the repository and install the necessary dependencies.

git clone https://github.com/nahimaroun/Nova4ApiTraining.git
cd DP Training/DesignPatternsTraining
# Install dependencies (if any)

🧩 Design Patterns
This project covers the following design patterns:
(The language used to code these examples:  C# ) 
(All these Examples are made in Class Libraries, To run them Go to "MainConsoleApp" and run the "Program.cs" file)

● Creational Patterns:
_______________________
-----------------------
Creational patterns deal with object creation mechanisms, aiming to create objects in a manner suitable to the situation. These patterns provide various ways to instantiate objects, which increase the flexibility and reuse of existing code.

○ Singleton Design Pattern:
----------------------------
The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. This is useful when exactly one object is needed to coordinate actions across the system.

*Example: SingletonDesignPattern.dll*

○ Factory Method:
------------------
The Factory Method pattern defines an interface for creating an object but lets subclasses alter the type of objects that will be created. This pattern promotes loose coupling by eliminating the need to bind application-specific classes into the code.

*Example: FactoryDesignPattern.dll*

○ Abstract Factory:
--------------------
The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It involves a super-factory which creates other factories, also known as a factory of factories.

*Example: AbstractFactoryTraining.dll*

○ Prototype Design Pattern:
----------------------------
The Prototype pattern specifies the kinds of objects to create using a prototypical instance, and creates new objects by copying this prototype. This is useful when the cost of creating a new object is expensive or complicated.

*Example: PrototypeDesignPattern.dll*

○ Builder Design Pattern:
--------------------------
The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations. This pattern is useful when creating complex objects step by step.

*Example: BuilderDesignPattern.dll*

____________________________________________________________

● Structural Patterns:
_______________________
-----------------------
Structural patterns concern class and object composition. They use inheritance to compose interfaces and define ways to compose objects to obtain new functionalities.

○ Adapter Design Pattern:
--------------------------
The Adapter pattern converts the interface of a class into another interface clients expect. This allows classes with incompatible interfaces to work together.

*Example: AdapterDesignPattern.dll*

○ Bridge Design Pattern:
-------------------------
The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently. This is useful when both the class and what it does vary often.

*Example: BridgeDesignPattern.dll*

○ Composite Design Pattern:
----------------------------
The Composite pattern composes objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

*Example: CompositeDesignPattern.dll*

○ Decorator Design Pattern:
----------------------------
The Decorator pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

*Example: DecoratorDesignPattern.dll*

○ Facade Design Pattern:
-------------------------
The Facade pattern provides a unified interface to a set of interfaces in a subsystem. It defines a higher-level interface that makes the subsystem easier to use.

*Example: FacadeDesignPattern.dll*

____________________________________________________________

● Behavioral Patterns:
_______________________
-----------------------
Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects. These patterns help define how objects interact and communicate with each other.

○ Chain of Responsibility Design Pattern:
-------------------------------------------
The Chain of Responsibility pattern lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

*Example: CORDesignPattern.dll*

○ Command Design Pattern:
--------------------------
The Command pattern encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

*Example: CommandDesignPattern.dll*

○ Iterator Design Pattern:
---------------------------
The Iterator pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. It allows traversal of the elements in a collection.

*Example: IteratorDesignPattern.dll*

○ Observer Design Pattern:
---------------------------
The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. This is often used in implementing distributed event-handling systems.

*Example: ObserverDesignPattern.dll*

○ Template Method Design Pattern:
----------------------------------
The Template Method pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. It lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

*Example: TemplateMethodDesignPattern.dll*


📬 Contact
For any questions or suggestions, feel free to reach out:

Email: Nahi.Rostom@hotmail.com


## 📚 References
This project was inspired by and utilizes concepts from the following resources:

Info about DPs: https://refactoring.guru/design-patterns/
Example are from: - https://www.c-sharpcorner.com/
                  - https://dotnettutorials.net/
                  - https://refactoring.guru/
