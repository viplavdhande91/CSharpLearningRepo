using FactoryMethod;

Console.Title = "Factory Method";

KnifeFactory factory = new KnifeFactory();

IKnife chefKnife = factory.CreateKnife("chef");
chefKnife.Sharpen();
chefKnife.Polish();
chefKnife.Package();

Console.WriteLine();

IKnife steakKnife = factory.CreateKnife("steak");
steakKnife.Sharpen();
steakKnife.Polish();
steakKnife.Package();


Console.ReadKey();