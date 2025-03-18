using ObserverPattern.Interfaces;

namespace ObserverPattern.Models
{
  public class Observer : IObserver
  {
    private string _name;

    public Observer(string name)
    {
      _name = name;
    }

    public void Update(string message)
    {
      Console.WriteLine($"The Observer {_name} received message: {message}");
    }
  }
}
