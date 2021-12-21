// See https://aka.ms/new-console-template for more information

interface IBurger
{
    string GetBurgerType();
}

class Burger : IBurger
{
    public virtual 
        string GetBurgerType()
    {
        return "Burger normal";
    }
}

class BurgerBeef: Burger
{
    public override string GetBurgerType()
    {
        return "Burger au boeuf";
    }
}

class BurgerChicken : Burger
{
    public override string GetBurgerType()
    {
        return "Burger au poulet";
    }
}

class BurgerDecorator : IBurger
{
    private IBurger _burger;

    public BurgerDecorator(IBurger burger)
    {
        _burger = burger;
    }
    public virtual string GetBurgerType()
    {
        return _burger.GetBurgerType();
    }
}

class SaladDecorator : BurgerDecorator
{
    public SaladDecorator(IBurger burger) : base(burger)
    {

    }
    public override string GetBurgerType()
    {
        string type = base.GetBurgerType();
        type += "\n ajout salade";
        return type;
    }
}

class TomatoDecorator : BurgerDecorator
{
    public TomatoDecorator(IBurger burger) : base(burger)
    {

    }
    public override string GetBurgerType()
    {
        string type = base.GetBurgerType();
        type += "\n ajout tomate";
        return type;
    }
}

class BeefDecorator : BurgerDecorator
{
    public BeefDecorator(IBurger burger) : base(burger)
    {

    }
    public override string GetBurgerType()
    {
        string type = base.GetBurgerType();
        type += "\n extra boeuf";
        return type;
    }
}

class ChickenFriedDecorator : BurgerDecorator
{
    public ChickenFriedDecorator(IBurger burger) : base(burger)
    {

    }
    public override string GetBurgerType()
    {
        string type = base.GetBurgerType();
        type += "\n extra poulet pané";
        return type;
    }
}

class WrappedDecorator : BurgerDecorator
{
    public WrappedDecorator(IBurger burger) : base(burger)
    {

    }
    public override string GetBurgerType()
    {
        string type = base.GetBurgerType();
        type += "\n Le burger est emballé";
        return type;
    }
}