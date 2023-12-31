﻿using MyPatternTraining.Behavioral;
using MyPatternTraining.Behavioral.Observer;
using MyPatternTraining.Behavioral.Strategy;
using MyPatternTraining.Creational.Builder;
using MyPatternTraining.Creational.FactoryMethod;
using MyPatternTraining.Creational.Prototype;
using MyPatternTraining.Creational.Singleton;
using MyPatternTraining.TestClasses;

Console.WriteLine("My pattern trainings");

//Singleton.
//var test0 = new Singleton<TestClass0>();
//test0.Instance.TestMethod();

//Factory method generic.
//var factoryClass0 = new ConcreteClassWithFactoryMethod0();
//var test0 = factoryClass0.Create();
//var factoryClass1 = new ConcreteClassWithFactoryMethod1();
//var test1 = factoryClass1.Create();

//Factory method standart
//StandartFactoryMethod factoryClass0 = new StandartFactoryMethod1();
//var test0 = factoryClass0.Create();
//StandartFactoryMethod factoryClass1 = new StandartFactoryMethod2();
//var test1 = factoryClass1.Create();

//Prototype
//var test0 = new TestClassForPrototype0();
//test0.Prop1 = 30;
//test0.Prop2 = 32;
//Console.WriteLine(test0.GetHashCode());
//var test1 = test0.Clone(); 
//Console.WriteLine(test1.GetHashCode());
//Console.WriteLine(test1.Prop1);
//Console.WriteLine(test1.Prop2);
//Console.WriteLine(test1.Prop3);

//Fluent Builder
//var builder = new TestClass0Builder();
//builder
//    .AddProp1(23)
//    .AddProp2(84)
//    .AddProp3(312312);
//var test0 = builder.Build();
//Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(test0));


//Strategy
//var test0 = new TestClassWithStrategy(new ConcreteStrategy1());
//test0.MethodWithStrategy();
//test0.Strategy = new ConcreteStrategy2();
//test0.MethodWithStrategy();

//Observer
//var observer1 = new ConcreteObserver1();
//var observer2 = new ConcreteObserver2();
//var classWithObserver = new TestClass0WithObserver(new List<IObserver> { observer1, observer2 });
//classWithObserver.NotifyObservers("notify message");

//Custom Command
//var commandsInvoker = new CommandsInvoker();
//commandsInvoker
//    .AddCommand(new MyPatternTraining.Behavioral.Command.Command("+", 3))
//    .AddCommand(new MyPatternTraining.Behavioral.Command.Command("-", 3))
//    .AddCommand(new MyPatternTraining.Behavioral.Command.Command("*", 99))
//    .AddCommand(new MyPatternTraining.Behavioral.Command.Command("+", 1))
//    .AddCommand(new MyPatternTraining.Behavioral.Command.Command("*", 99));
//
//Console.WriteLine(commandsInvoker.Invoke());