# What is the Mediator Pattern?

The Mediator Pattern is considered to be a behavioral pattern and it defines how the objects can communicate with each other. It was first introduced in the famous book “Design Patterns: Elements of Reusable Object-Oriented Software” back in 1994 but became more popular in recent years.

Mediator pattern reduces the tight coupling between a set of interacting objects thus make it easy for developers to change the functionality of the objects independently. Objects don’t call other objects directly but delegate their interaction to a mediator object. This mediator object then handles the communication and interactions between objects.

A real-world example of the Mediator pattern is the traffic control room at airports. If all flights will have to interact with each other for finding which flight is going to land next, it will create a big mess. Rather flights only send their status to the mediator (control room).
