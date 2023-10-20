Car myCar = new();

myCar.engine = new Engine();

myCar.engine.name = "V8";

myCar.trunk = new Trunk();

Human martin = new Human();

myCar.trunk.human = martin;

Human micke = new Human();

martin.name = "Martin";
micke.name = "Micke";

martin.friend = micke;
micke.friend = martin;

Console.WriteLine(martin.friend.friend.friend.friend.friend.name);

// Human fakeMartin = martin;

// martin.name = "Martin";
// fakeMartin.name = "Fejkmartin";

// Console.WriteLine(martin.name);
// Console.WriteLine(fakeMartin.name);

Console.ReadLine();