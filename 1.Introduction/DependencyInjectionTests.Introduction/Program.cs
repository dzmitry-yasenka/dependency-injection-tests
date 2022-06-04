using DependencyInjectionTests.Introduction.CarExample;
using DependencyInjectionTests.Introduction.DataExample;
using DependencyInjectionTests.Introduction.GreeterExample;


Console.WriteLine("---Car example---");
var electricCar = new Car(new ElectricEngine());
var dieselCar = new Car(new DieselEngine());
var petrolCar = new Car(new PetrolEngine());
var testCar = new Car(new TestEngine());

var cars = new List<Car> {electricCar, dieselCar, petrolCar, testCar};

foreach (var car in cars)
{
    car.Start();
    car.Stop();
}
Console.WriteLine("---Car example---");


Console.WriteLine("---Data Example---");
var userService = new UserService(new UserRepository(new SqliteDbConnectionFactory()));
Console.WriteLine("---Data Example---");


Console.WriteLine("---Greeter Example---");
var greeter = new Greeter(new DateTimeProvider());
Console.WriteLine(greeter.CreateGreetMessage());
Console.WriteLine("---Greeter Example---");

Console.ReadKey();