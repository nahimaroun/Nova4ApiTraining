# Design Patterns Project

## 🌟 Introduction
Welcome to the **Design Patterns Project**! This project is a comprehensive guide and learning resource for various design patterns used in software development. Design patterns are proven solutions to common problems in software design. They are like blueprints that can be customized to solve particular design problems in your code.

## 📚 Table of Contents
- [Introduction](#-introduction)
- [Installation](#-installation)
- [Design Patterns](#-design-patterns)
  - [Creational Patterns](#-creational-patterns)
  - [Structural Patterns](#--structural-patterns)
  - [Behavioral Patterns](#-behavioral-patterns)
- [References](#-References)

## 🛠 Installation
To get started with the project, clone the repository and install the necessary dependencies.

git clone https://github.com/nahimaroun/Nova4ApiTraining.git

cd DP Training/DesignPatternsTraining

Install dependencies (if any)

## 🧩 Design Patterns
This project covers the following design patterns:
- Creational Design Patterns
- Structural Design Patterns
- Behavioral Design Patterns

I have made 5 detailed examples about each category of Design Patterns, you can run them and check out the code to learn about these design patterns and how they're implemented. These examples are very basic examples and no one would use them for such basic tasks, but our goal here is to learn not complicate our lives.

(The language used to code these examples:  C# ) 

(All these Examples are made in Class Libraries, To run them Go to "MainConsoleApp" and run the "Program.cs" file)

## ○ Creational Patterns:

Creational patterns deal with object creation mechanisms, aiming to create objects in a manner suitable to the situation. These patterns provide various ways to instantiate objects, which increase the flexibility and reuse of existing code.

____________________________
● Singleton Design Pattern:

The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. This is useful when exactly one object is needed to coordinate actions across the system.

![singleton-comic-1-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/8d34bd67-4780-445e-a695-d0890ca97512)

*Project-Reference: SingletonDesignPattern.dll*
_________________
● Factory Method:

The Factory Method pattern defines an interface for creating an object but lets subclasses alter the type of objects that will be created. This pattern promotes loose coupling by eliminating the need to bind application-specific classes into the code.

![factory-method-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/cbdce3b7-454c-4bb8-b1a4-68e99d327f5c)

*Project-Reference: FactoryDesignPattern.dll*
___________________
● Abstract Factory:

The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It involves a super-factory which creates other factories, also known as a factory of factories.

![abstract-factory-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/cc7c08a3-61e4-403a-ae96-ef4a8c215e47)

*Project-Reference: AbstractFactoryTraining.dll*
____________________________
● Prototype Design Pattern:

The Prototype pattern specifies the kinds of objects to create using a prototypical instance, and creates new objects by copying this prototype. This is useful when the cost of creating a new object is expensive or complicated.

![prototype](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/69a1c567-599b-4775-8867-d5e4fa03672e)

*Project-Reference: PrototypeDesignPattern.dll*
__________________________
● Builder Design Pattern:

The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations. This pattern is useful when creating complex objects step by step.

![builder-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/398de502-e0e8-42c5-82cd-11779900b726)

*Project-Reference: BuilderDesignPattern.dll*




## ○  Structural Patterns:

Structural patterns concern class and object composition. They use inheritance to compose interfaces and define ways to compose objects to obtain new functionalities.

____________________________
● Adapter Design Pattern:

The Adapter pattern converts the interface of a class into another interface clients expect. This allows classes with incompatible interfaces to work together.

![adapter-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/44c843e4-02b0-43cd-a8e6-d6e9e2741e3d)

*Project-Reference: AdapterDesignPattern.dll*
____________________________
● Bridge Design Pattern:

The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently. This is useful when both the class and what it does vary often.

![bridge](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/af393d94-6479-4d48-a98c-448b23f62508)

*Project-Reference: BridgeDesignPattern.dll*
____________________________
● Composite Design Pattern:

The Composite pattern composes objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

![composite](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/d59522cc-16e7-4e7a-9b14-ce313f0465aa)

*Project-Reference: CompositeDesignPattern.dll*
____________________________
● Decorator Design Pattern:

The Decorator pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

![decorator](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/47f0dc59-4a61-4ea6-8c0e-41b02e4d08f0)

*Project-Reference: DecoratorDesignPattern.dll*
____________________________
● Facade Design Pattern:

The Facade pattern provides a unified interface to a set of interfaces in a subsystem. It defines a higher-level interface that makes the subsystem easier to use.

![facade](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/d8e80864-14c7-4e6a-9375-569b3165273b)

*Project-Reference: FacadeDesignPattern.dll*




## ○ Behavioral Patterns:

Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects. These patterns help define how objects interact and communicate with each other.

_________________________________________
● Chain of Responsibility Design Pattern:

The Chain of Responsibility pattern lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

![chain-of-responsibility](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/dedf8e05-030b-4429-82e6-2215aaf93cbc)

*Project-Reference: CORDesignPattern.dll*
____________________________
● Command Design Pattern:

The Command pattern encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

![command-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/a0fb42bb-31c1-4d48-a894-716cfb9a01d0)

*Project-Reference: CommandDesignPattern.dll*
____________________________
● Iterator Design Pattern:

The Iterator pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. It allows traversal of the elements in a collection.

![iterator-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/db4a2bc6-12fb-4c81-8f02-fdbd0b6c683a)

*Project-Reference: IteratorDesignPattern.dll*
____________________________
● Observer Design Pattern:

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. This is often used in implementing distributed event-handling systems.

![observer](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/0ed928da-80c5-4181-9966-b66e468b0c61)

*Project-Reference: ObserverDesignPattern.dll*
__________________________________
● Template Method Design Pattern:

The Template Method pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. It lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

![template-method](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/25f55e79-99bf-4781-9143-f839d3a8aa5d)

*Project-Reference: TemplateMethodDesignPattern.dll*

## 📚 References
This project was inspired by and utilizes concepts from the following resources:

Information And Images:

- [Refactoring Guru]( https://refactoring.guru/design-patterns/)


Examples are from:

- [C# Corner](https://www.c-sharpcorner.com/)
                   
- [Dot Net Tutorials](https://dotnettutorials.net/)

- [Refactoring Guru]( https://refactoring.guru/design-patterns/)
