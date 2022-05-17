
using Galactica_nich2072.Objects;
Star sun;

AddPlanets();
addMoons();
showAll();

void showAll()
{
    Console.WriteLine($"----Sun: name={sun.Name} type={sun.Type}----");
    foreach (Planet planet in sun.Planets)
    {
        Console.WriteLine($"\n---{planet.Name} ---");
        Console.WriteLine($"Type: {planet.Type}");
        Console.WriteLine($"Distance to sun: {planet.Distance(sun)}");
        Console.WriteLine($"--{planet.Name}'s Moons--");
        foreach (Moon moon in planet.Moons)
        {
            Console.WriteLine($"Distance to {planet.Name}: {moon.Distance()}");
        }
    }
}
void AddPlanets()
{
    sun = new Star()
    {
        Id = 1,
        Name = "Sun",
        position = (new SpaceObjects.Position() { x = 0, y = 0 }),
        Type = StarType.YellowDwarf,
        Temperature = 5500
    };
    sun.Planets = new List<Planet>();
    sun.Planets.Add(new Planet() {
        Id = 1,
        Name = "Mercury",
        position = new SpaceObjects.Position() { x = 20, y = 20 },
        Type = PlanetType.Terrestial,
        Diameter = 4880000,
        RotationPeriod = 1407,
        RevolutionPeriod = 176
    });
    sun.Planets.Add(new Planet()
    {
        Id = 2,
        Name = "Venus",
        position = (new SpaceObjects.Position() { x = 30, y = 30 }),
        Type = PlanetType.Terrestial,
        Diameter = 6051800,
        RotationPeriod = 5832,
        RevolutionPeriod = 116
    });
    sun.Planets.Add(new Planet()
    {
        Id = 3,
        Name = "Earth",
        position = new SpaceObjects.Position() { x = 50, y = 50 },
        Type = PlanetType.Terrestial,
        Diameter = 12742000,
        RotationPeriod = 24,
        RevolutionPeriod = 365,
    });
    sun.Planets.Add(new Planet() {
        Id = 4,
        Name = "Mars",
        position = new SpaceObjects.Position() { x = 60, y = 60 },
        Type = PlanetType.Terrestial,
        Diameter = 6779000,
        RotationPeriod = 25,
        RevolutionPeriod = 687
    }); 
    sun.Planets.Add(new Planet()
    {
        Id = 5,
        Name = "Jupiter",
        position = new SpaceObjects.Position() { x = 80, y = 80 },
        Type = PlanetType.Gas_Giant,
        Diameter = 139820000,
        RotationPeriod = 10,
        RevolutionPeriod = 4380
    });
    sun.Planets.Add(new Planet()
    {
        Id = 6,
        Name = "Saturn",
        position = new SpaceObjects.Position() { x = 100, y = 100 },
        Type = PlanetType.Gas_Giant,
        Diameter = 116460000,
        RotationPeriod = 11,
        RevolutionPeriod = 10585
    }); 
    sun.Planets.Add(new Planet()
    {
        Id = 7,
        Name = "Uranus",
        position = new SpaceObjects.Position() { x = 120, y = 120 },
        Type = PlanetType.Giant,
        Diameter = 50724000,
        RotationPeriod = 17,
        RevolutionPeriod = 30660
    });
    sun.Planets.Add(new Planet()
    {
        Id = 8,
        Name = "Neptune",
        position = new SpaceObjects.Position() { x = 140, y = 140 },
        Type = PlanetType.Giant,
        Diameter = 49244000,
        RotationPeriod = 16,
        RevolutionPeriod = 60225
    });
}

void addMoons()
{
    foreach (Planet planet in sun.Planets)
    {
        planet.Moons = new List<Moon>();
        switch (planet.Name)
        {
            case "Earth":
                planet.Moons.Add(new Moon()
                {
                    Id = 1,
                    Name = "Luna",
                    position = new SpaceObjects.Position() { x = 55, y = 55 },
                    Orbiting = planet,
                    Diameter = 3474800,
                    RotationPeriod = 648,
                    RevolutionPeriod = 27
                });
                break;
            case "Saturn":
                planet.Moons.Add(new Moon()
                {
                    Id = 2,
                    Name = "Titan",
                    position = new SpaceObjects.Position() { x = 105, y = 105 },
                    Orbiting = planet,
                    Diameter = 5149500,
                    RotationPeriod = 384,
                    RevolutionPeriod = 16
                });

                planet.Moons.Add(new Moon()
                {
                    Id = 8,
                    Name = "Mimas",
                    position = new SpaceObjects.Position() { x = 97, y = 97 },
                    Orbiting = planet,
                    Diameter = 396400,
                    RotationPeriod = 23,
                    RevolutionPeriod = 1
                });
                break;
            case "Mars":
                planet.Moons.Add(new Moon()
                {
                    Id = 3,
                    Name = "Phobos",
                    position = new SpaceObjects.Position() { x = 65, y = 65 },
                    Orbiting = planet,
                    Diameter = 22533,
                    RotationPeriod = 8,
                    RevolutionPeriod = 1
                });

                planet.Moons.Add(new Moon()
                {
                    Id = 5,
                    Name = "Deimos",
                    position = new SpaceObjects.Position() { x = 67, y = 67 },
                    Orbiting = planet,
                    Diameter = 12400,
                    RotationPeriod = 30,
                    RevolutionPeriod = 2
                });
                break;
            case "Jupiter":
                planet.Moons.Add(new Moon()
                {
                    Id = 4,
                    Name = "Europe",
                    position = new SpaceObjects.Position() { x = 85, y = 85 },
                    Orbiting = planet,
                    Diameter = 3121600,
                    RotationPeriod = 85,
                    RevolutionPeriod = 4
                });

                planet.Moons.Add(new Moon()
                {
                    Id = 6,
                    Name = "Ganymedes",
                    position = new SpaceObjects.Position() { x = 87, y = 87 },
                    Orbiting = planet,
                    Diameter = 5268200,
                    RotationPeriod = 171,
                    RevolutionPeriod = 7
                });

                planet.Moons.Add(new Moon()
                {
                    Id = 7,
                    Name = "Io",
                    position = new SpaceObjects.Position() { x = 78, y = 78 },
                    Orbiting = planet,
                    Diameter = 3643200,
                    RotationPeriod = 42,
                    RevolutionPeriod = 2
                });
                break;
        }
    }
}