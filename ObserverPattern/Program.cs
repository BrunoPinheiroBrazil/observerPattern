// See https://aka.ms/new-console-template for more information

using ObserverPattern.Models;

Console.WriteLine("Startin Observer Pattern App");

var subject = new MainSubject();

var observer1 = new Observer("Observer 1");
var observer2 = new Observer("Observer 2");
var observer3 = new Observer("Observer 3");

subject.AddObserver(observer1);
subject.AddObserver(observer2);
subject.AddObserver(observer3);

subject.State = "State 1";
subject.State = "State 2";

subject.RemoveObserver(observer2);

subject.State = "State 3";

Console.WriteLine("Ending Observer Pattern App");
