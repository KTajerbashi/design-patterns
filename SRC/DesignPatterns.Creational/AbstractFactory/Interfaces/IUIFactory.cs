namespace DesignPatterns.Creational.AbstractFactory.Interfaces;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
