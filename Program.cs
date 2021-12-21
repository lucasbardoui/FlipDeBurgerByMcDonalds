class Program
{
    static void Main(string[] args)
    {
        IBurger beef = new BurgerBeef();
        IBurger addtomato = new TomatoDecorator(beef);
        IBurger addsalad = new SaladDecorator(addtomato);
        IBurger extrabeef = new BeefDecorator(addsalad);
        IBurger wrappbeef = new WrappedDecorator(extrabeef);
        Console.WriteLine(wrappbeef.GetBurgerType());


        IBurger chicken = new BurgerChicken();
        IBurger chickentomato = new TomatoDecorator(chicken);
        IBurger chickensalad = new SaladDecorator(chickentomato);
        IBurger addchickenfried = new BeefDecorator(chickensalad);
        IBurger wrappchicken = new WrappedDecorator(addchickenfried);
        Console.WriteLine(wrappchicken.GetBurgerType());
    }
    
}