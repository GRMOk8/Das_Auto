using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Decorator
{

    class Car
    {
        public virtual string Name { get; set; }
        public virtual void Run()
        {
            // Console.WriteLine("");
        }
    }

    class GlavElemDecorator : Car
    {
        protected Car _source;

        public GlavElemDecorator(Car source)
        {
            _source = source;
        }

        public override string Name
        {
            get { return _source.Name; }
            set { _source.Name = value; }
        }
        public override void Run() { _source.Run(); }
    }

    class RamaDecorator : GlavElemDecorator
    {
        public RamaDecorator(Car source) : base(source) { }

        public override void Run()
        {
            _source.Run();
            Console.Write(" Рама является несущим элементом всех компонентов автомобиля.");
        }
    }

    class KuzovDecorator : GlavElemDecorator
    {
        public KuzovDecorator(Car source) : base(source) { }

        public override void Run()
        {
            _source.Run();
            Console.Write(" Кузов закреплён на раме. Имеет места для посадки водителя и пассажиров.");
        }
    }

    class EngineDecorator : GlavElemDecorator
    {
        public EngineDecorator(Car source) : base(source) { }

        public override void Run()
        {
            _source.Run();
            Console.Write(" Двигатель установлен на раме в передней части. Преобразует энергию сгорания топлива в механическую работу.");
        }
    }

    class KPPDecorator : GlavElemDecorator
    {
        public KPPDecorator(Car source) : base(source) { }

        public override void Run()
        {
            _source.Run();
            Console.Write(" КПП - это редуктор, позволяющий ступенчато изменять соотношение скоростей вращения ведущего и ведомого валов.");
        }
    }

    class RazdatKorDecorator : GlavElemDecorator
    {
        public RazdatKorDecorator(Car source) : base(source) { }

        public override void Run()
        {
            _source.Run();
            Console.Write(" Раздаточная коробка позволяет подключать для передачи вращающего момента вторую колёсную ось и управлять раздачей мощности от двигателя между осями.");
        }
    }

    class ReductorDecorator : GlavElemDecorator
    {
        public ReductorDecorator(Car source) : base(source) { }

        public override void Run()
        {
            _source.Run();
            Console.Write(" Редуктор - устройство, передающее и преобразующее вращающий момент на ведущие колёса.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car = new RamaDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            car = new Car();
            car = new KuzovDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            car = new Car();
            car = new EngineDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            car = new Car();
            car = new KPPDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            car = new Car();
            car = new RazdatKorDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            car = new Car();
            car = new ReductorDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            car = new Car();
            car = new RamaDecorator(car);
            car = new EngineDecorator(car);
            car = new KPPDecorator(car);
            car = new RazdatKorDecorator(car);
            car = new ReductorDecorator(car);

            car.Run();
            Thread.Sleep(1000);

            Console.ReadKey();
        }
    }
}
