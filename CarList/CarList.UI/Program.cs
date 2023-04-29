using CarList.Logic;

Console.WriteLine(" Carros ");
var cars = new DoubleList<Car>();

var car1 =  new Car { Brand = "AUDI", Model = "Q3", Year = 2023, Colors = "Blanco", Price = 200000000 };
var car2 =  new Car { Brand = "BMW", Model = "SERIE 3", Year = 1995, Colors = "Rojo", Price = 36000000 };
var car3 =  new Car { Brand = "MERCEDES BENZ", Model = "Clase GLS", Year = 2017, Colors = "Marron", Price = 225000000 };
var car4 =  new Car { Brand = "ASTON MARTIN", Model = "V12", Year = 2022, Colors = "Gris", Price = 240000000 };
var car5 =  new Car { Brand = "FORD", Model = "F-150", Year = 2018, Colors = "Blanco", Price = 192000000 };
var car6 =  new Car { Brand = "NISSAN", Model = "Sentra", Year = 2018, Colors = "Verde", Price = 68000000 };
var car7 =  new Car { Brand = "RENAULT", Model = "Stepway", Year = 2019, Colors = "Gris", Price = 40000000 };
var car8 =  new Car { Brand = "FORD", Model = "Fiesta", Year = 2015, Colors = "Amarillo", Price = 43000000 };
var car9 =  new Car { Brand = "NISSAN", Model = "Urvan", Year = 2017, Colors = "Morada", Price = 120000000 };
var car10 = new Car { Brand = "MERCEDES BENZ", Model = "Clase C", Year = 2009, Colors = "Azul", Price = 50000000 };
var car11 = new Car { Brand = "RENAULT", Model = "Sandero", Year = 2018, Colors = "Rosado", Price = 70000000 };
var car12 = new Car { Brand = "VOLKSWAGEN", Model = "Jetta", Year = 2019, Colors = "Blanco", Price = 96000000 };


cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);
cars.Add(car5);
cars.Add(car6);
cars.Add(car7);
cars.Add(car8);
cars.Add(car9);
cars.Add(car10);
cars.Add(car11);
cars.Add(car12);

Console.WriteLine("Lista de Carros =>");
Console.WriteLine(cars);

Console.WriteLine("Filtro Por marca RENAULT =>");
Console.WriteLine(cars.GetBrand("RENAULT"));
Console.WriteLine("*******************************=>");

Console.WriteLine("Filtro Por marca FORD =>");
Console.WriteLine(cars.GetBrand("FORD"));
Console.WriteLine("*******************************=>");

Console.WriteLine("Filtro Por Año Entre 1995 y 2015 =>");
Console.WriteLine(cars.GetYear(1995,2015));
Console.WriteLine("*******************************=>");

Console.WriteLine("Filtro Por Año Entre 2016 y 2024 =>");
Console.WriteLine(cars.GetYear(2016, 2024));
Console.WriteLine("*******************************=>");

Console.WriteLine("Filtro Por Precio Entre 0 y 60 Millones =>");
Console.WriteLine($"1. {cars.GetPrice(0, 60000000)}");
Console.WriteLine("******************************* =>");

Console.WriteLine("Filtro Por Precio Entre 60 y 120 Millones =>");
Console.WriteLine($"2. {cars.GetPrice(60000000,120000000)}");
Console.WriteLine("******************************* =>");

Console.WriteLine("Filtro Por Precio Entre 120 y 240 Millones =>");
Console.WriteLine($"3. {cars.GetPrice(120000000, 240000000)}");
Console.WriteLine("******************************* =>");

Console.WriteLine("8 CASOS DE FILTROS =>");
Console.WriteLine("Todos cumplen * =>");
Console.WriteLine(cars.GetSeveralFilters("*", "*", "*", 1900, 2025));
Console.WriteLine("MARCA CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("AUDI", "*", "*", 1900, 2025));
Console.WriteLine("MARCA Y MODELO CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("AUDI", "Q3", "*", 1900, 2025));
Console.WriteLine("TODOS CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("NISSAN", "Urvan", "Morada", 1900, 2025));
Console.WriteLine("MARCA Y COLOR CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("VOLKSWAGEN", "*", "Blanco", 1900, 2025));
Console.WriteLine("COLOR CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("*", "*", "Azul", 1900, 2025));
Console.WriteLine("MODELO Y COLOR CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("*", "Jetta", "Blanco", 1900, 2025));
Console.WriteLine("MODELO CON VALOR  =>");
Console.WriteLine(cars.GetSeveralFilters("*", "Sandero", "*", 1900, 2025));


var list = cars.GetMinMax(cars);

Console.WriteLine("******************************* =>");
Console.WriteLine("MIN =>");
Console.WriteLine(list[0]);
Console.WriteLine("MAX =>");
Console.WriteLine(list[1]);


