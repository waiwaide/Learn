using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.Command;
using DesignPatterns.Command.Example;
using DesignPatterns.Adapter;
using DesignPatterns.Facade;
using DesignPatterns.Template;
using DesignPatterns.Strategy;
using DesignPatterns.Iterator;
using DesignPatterns.Composite;
using DesignPatterns.state;
using DesignPatterns.Proxy;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeverageComponent beverage = new Espresso();

            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            MessageBox.Show(string.Format("{0}", beverage.GetDescription() + "$" + beverage.Cost()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarAbstract car = new CarSimpleFactory().Product("Ferrari");
            car.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarAbstract car = new BenzCarFactory().Product();
            car.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ISuperFactory superFactory = new HouseAndCar();

            HouseAbstract house = superFactory.houseInit().Product();
            CarAbstract car = superFactory.carInit().Product();
            house.Print();
            car.Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var r = new Receiver();
            Command.Command c = new ConcreteCommand(r);
            var i = new Invoker();

            i.SetCommand(c);
            i.ExecutedCommand();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XiaoAi xiaoAi = new XiaoAi();

            AirConditioningReceiver airConditioningReceiver = new AirConditioningReceiver();
            TVReceiver tVReceiver = new TVReceiver();

            OpenAirConditioningCommand openAirConditioningCommand = new OpenAirConditioningCommand(airConditioningReceiver);
            OpenTVCommand openTVCommand = new OpenTVCommand(tVReceiver);
            CloseAirConditioningCommand closeAirConditioningCommand = new CloseAirConditioningCommand(airConditioningReceiver);
            CloseTVCommand closeTVCommand = new CloseTVCommand(tVReceiver);

            xiaoAi.SetCommand(openAirConditioningCommand);
            xiaoAi.SetCommand(openTVCommand);
            xiaoAi.SetCommand(closeAirConditioningCommand);
            xiaoAi.SetCommand(closeTVCommand);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Target target = new Adapter.Adapter();
            target.Request();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MovieFacade movie = new MovieFacade();
            Projector projector = new Projector("Huawei");

            movie.OpenMovie();
            Console.WriteLine();
            movie.Projector = projector;
            movie.Projector.SetStandardScreen();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           Strategy.Context context;
            context = new Strategy.Context(new ConcreteStrategyA());
            context.ContextAlgorithm();
            context = new Strategy.Context(new ConcreteStrategyB());
            context.ContextAlgorithm();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "Item A";
            aggregate[1] = "Item B";
            aggregate[2] = "Item C";
            aggregate[3] = "Item D";

            Iterator.Iterator i = aggregate.CreatIterator();

            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            Composite.Composite root = new Composite.Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite.Composite comp = new Composite.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            state.Context context = new state.Context(new state.ConcreteStateA());

            context.Requset();
            context.Requset();
            context.Requset();
            context.Requset();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Proxy.Proxy proxy = new Proxy.Proxy();
            proxy.Request();
        }
    }
    
}
