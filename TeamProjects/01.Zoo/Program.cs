
using _01.Zoo;

Zoo zoo = new Zoo();

Bird bird = new Bird("Pesho", 5);
Mammal mammal = new Mammal("Gosho", 3);
Fish fish = new Fish("Ivan", 2);

zoo.AddAnimal(bird);
zoo.AddAnimal(mammal);
zoo.AddAnimal(fish);

zoo.PrintAnimalsNames();

zoo.MakeAllSounds();

zoo.GetDietTypes();

zoo.GetHabitatTypes();

zoo.GetAnimalTypes();




