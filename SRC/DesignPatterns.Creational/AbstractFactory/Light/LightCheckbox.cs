using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Light;

public class LightCheckbox : ICheckbox
{
    public string Render() => "<input type='checkbox' checked> Light Checkbox";
}
