# Interface Segregation Principle

## What is the Interface Segregation Principle?

[Learn here](https://reflectoring.io/interface-segregation-principle/)
## Practical 

You work for a company that deals with different types of aircrafts from passenger planes to fighter jets. 

Without breaking the interface segregation principle add a new service *ArmyAirlineService.cs* that returns a fighter jet.

A fighterjet needs to have the following methods and properties to function:

- void Fly();
- bool HasWings(); (should be true)
- void Break();
- void Accelerate();
- void TurnLeft();
- void TurnRight();
- void FireMissiles();
- void TrackTarget();
- void EjectPilot();
- int Capacity(); (there should be room for a pilot and co-pilot)

Hint: The army do not care about serving food or drink.

## Evidence for the matrix

Create a file called interface-segregation.md

Answer the following questions:

What is the interface segregation principle?   
Why do we use it?   

Insert a link that goes to that file in the repo in your GitHub account.

We will use this as evidence for the I of the SOLID principles.

