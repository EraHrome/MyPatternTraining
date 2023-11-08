using MyPatternTraining.Creational.FactoryMethod;
using MyPatternTraining.Creational.Singleton;
using MyPatternTraining.TestClasses;

Console.WriteLine("My patter trainings");

//Singleton.
//var test0 = new Singleton<TestClass0>();
//test0.Instance.TestMethod();

//Factory method generic.
//var factoryClass0 = new ConcreteClassWithFactoryMethod0();
//var test0 = factoryClass0.Create();
//var factoryClass1 = new ConcreteClassWithFactoryMethod1();
//var test1 = factoryClass1.Create();

//Factory method standart
StandartFactoryMethod factoryClass0 = new StandartFactoryMethod1();
var test0 = factoryClass0.Create();
StandartFactoryMethod factoryClass1 = new StandartFactoryMethod2();
var test1 = factoryClass1.Create();