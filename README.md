# Observer Pattern in .NET Core

This project demonstrates the implementation of the Observer pattern in C# using .NET Core. The Observer pattern is a behavioral design pattern that allows an object (the "subject") to notify other objects (the "observers") about changes to its state.

## Project Structure

The project consists of the following files:

* `IObserver.cs`: Defines the interface for observers.
* `IObservable.cs`: Defines the interface for the subject.
* `Subject.cs`: Implements the subject.
* `Observer.cs`: Implements a concrete observer.
* `Program.cs`: Demonstrates the usage of the Observer pattern.

## How to Use

1.  Clone the repository.
2.  Open the project in Visual Studio or another .NET Core compatible IDE.
3.  Run the project.

## Code Explanation

* **`IObserver`:** This interface defines the `Update` method, which is called by the subject to notify observers about changes to its state.
* **`IObservable`:** This interface defines the `AddObserver`, `RemoveObserver`, and `NotifyObservers` methods. The subject uses these methods to manage the list of observers and notify them about changes to its state.
* **`Subject`:** This class implements the `IObservable` interface. It maintains a list of observers and notifies them when its state changes.
* **`Observer`:** This class implements the `IObserver` interface. It receives notifications from the subject and performs some action in response.
* **`Program`:** This class demonstrates the usage of the Observer pattern. It creates a subject and two observers, registers them with the subject, and changes the subject's state.

## Example Output