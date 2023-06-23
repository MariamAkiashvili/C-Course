
namespace Task09
{
    public class Sport : Vehicle
    {

        private Category _category;
        private List<Sport> _cars;
        private double _speed;
        private double _price;

        public Category category { get; set; }
        public override string Name { get; set; }


        public Sport this[int i]
        {
            get
            {
                return _cars[i];
            }
            set
            {
                _cars[i] = value;
            }
        }

        public double Speed {get; set;}

        public double Price { get; set; }
        

        public override void MakeSound()
        {
            Console.WriteLine("Piip");
        }
        public override void ChangeSpeed(int x)
        {
            _speed = _speed * x;
        }
        public override void ChangePrice(double price)
        {
            _price += price;
        }
    }

    public class Combat : Vehicle
    {
        private double _speed;
        private double _price;
        public double Speed { get; set; }
        public double Price { get; set; }

        public override string Name { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Ghhhr");
        }
        public override void ChangeSpeed(int x)
        {
            _speed = _speed * (x/2);
        }
        public override void ChangePrice(double price)
        {
            _price += 2*price;
        }
    }

    public class Public : Vehicle
    {
        private double _speed;
        private double _price;
        public double Speed { get; set; }
        public double Price { get; set; }
         
        public override string Name { get; set; }


        public override void MakeSound()
        {
            Console.WriteLine("Ghhhr");
        }
        public override void ChangeSpeed(int x)
        {
            _speed = _speed * (x / 2);
        }
        public override void ChangePrice(double price)
        {
            _price += 2 * price;
        }

    }

    public class Consuming : Vehicle
    {
        private double _speed;
        private double _price;
        public double Speed { get; set; }
        public double Price { get; set; }

        public override string Name { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Ghhhr");
        }
        public override void ChangeSpeed(int x)
        {
            _speed = _speed * (x / 2);
        }
        public override void ChangePrice(double price)
        {
            _price += 2 * price;
        }
    }
}