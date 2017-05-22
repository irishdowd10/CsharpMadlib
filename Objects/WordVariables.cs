namespace CsharpMadlib.Objects
{
  public class WordVariables
  {
    private string _name;
    private string _place;
    private string _action;
    private string _adjective;
    private int _age;

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPlace()
    {
      return _place;
    }

    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }

    public string GetAction()
    {
      return _action;
    }

    public void SetAction(string newAction)
    {
      _action = newAction;
    }

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

    public int GetAge()
    {
      return _age;
    }

    public void SetAge(int newAge)
    {
      _age = newAge;
    }

  }
}
