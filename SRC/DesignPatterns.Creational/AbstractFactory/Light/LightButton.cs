using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Light;

public class LightButton : IButton
{
    public string Render() => "<button class='btn btn-light'>🌞 Light Button</button>";
}
