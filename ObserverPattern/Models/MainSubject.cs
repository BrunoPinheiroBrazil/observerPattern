using ObserverPattern.Interfaces;

namespace ObserverPattern.Models
{
  public class MainSubject : IObservable
  {
    private readonly ICollection<IObserver> _observers;
    private string _state = "";

    public string State
    {
      get => _state;
      set
      {
        _state = value;
        NotifyObservers($"Stated updated for {_state}");
      }
    }

    public MainSubject()
    {
      _observers = new List<IObserver>();
    }

    public void AddObserver(IObserver observer)
    {
      _observers.Add(observer);
    }

    public void NotifyObservers(string message)
    {
      _observers.ToList().ForEach(o =>
      {
        o.Update(message);
      });
    }

    public void RemoveObserver(IObserver observer)
    {
      _observers.Remove(observer);
    }
  }
}
