using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Dark;

public class DarkButton : IButton
{
    public string Render() => "<button class='btn btn-dark'>🌚 Dark Button</button>";
}
