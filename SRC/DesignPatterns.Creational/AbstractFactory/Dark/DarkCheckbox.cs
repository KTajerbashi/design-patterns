using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Dark;

public class DarkCheckbox : ICheckbox
{
    public string Render() => "<input type='checkbox'> Dark Checkbox";
}
