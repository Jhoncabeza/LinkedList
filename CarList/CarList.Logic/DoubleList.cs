using System.Linq;

namespace CarList.Logic
{
    public class DoubleList<T>
    {
        private DoubleNode<T>? _first;

        private DoubleNode<T>? _last;

        public DoubleList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }
        public string ToInvertedList()
        {
            var output = string.Empty;
            var pointer = _last;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Left;
            }
            return output;
        }
        public void Add(T item)
        {
            var node = new DoubleNode<T>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }
        public T[] ToArray()
        {
            var array = new T[Count];
            int i = 0;
            var pointer = _first;
            while (pointer != null)
            {
                array[i] = pointer.Data!;
                i++;
                pointer = pointer.Right;
            }
            return array;
        }
        public DoubleList<Car> GetBrand(string brand)
        {
            var list = new DoubleList<Car>();
            var pointer = _first;

            while (pointer != null)
            {
                Car carPointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;
                if (brand.Equals(carPointer!.Brand))
                {
                    list.Add(carPointer);
                }
                pointer = pointer.Right;
            }

            return list;
        }
        public DoubleList<Car> GetYear(int lower, int upper)
        {
            var list = new DoubleList<Car>();
            var pointer = _first;

            while (pointer != null)
            {
                Car carPointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;
                if (carPointer!.Year >= lower && carPointer!.Year <= upper)
                {
                    list.Add(carPointer);
                }
                pointer = pointer.Right;
            }

            return list;
        }
        public DoubleList<Car> GetPrice(decimal lower, decimal upper)
        {
            var list = new DoubleList<Car>();
            var pointer = _first;

            while (pointer != null)
            {
                Car carPointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;
                if (carPointer!.Price >= lower && carPointer!.Price <= upper)
                {
                    list.Add(carPointer);
                }
                pointer = pointer.Right;
            }

            return list;
        }
        public DoubleList<Car> GetSeveralFilters(string brand, string model, string color, int minimunYear, int maximunYear)
        {
            var list = new DoubleList<Car>();
            var pointer = _first;

            while (pointer != null)
            {
                Car carPointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;

                if (carPointer.Year >= minimunYear && carPointer.Year <= maximunYear)
                {
                    if (brand == "*")
                    {
                        if (model == "*")
                        {
                            if (color == "*")
                            {
                                list.Add(carPointer);
                            }
                            else
                            {
                                if (carPointer.Colors == color)
                                {
                                    list.Add(carPointer);
                                }
                            }
                        }
                        else
                        {
                            if (color == "*")
                            {
                                if (carPointer.Model == model)
                                {
                                    list.Add(carPointer);
                                }
                            }
                            else
                            {
                                if (carPointer.Colors == color && carPointer.Model == model)
                                {
                                    list.Add(carPointer);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (model == "*")
                        {
                            if (color == "*")
                            {
                                if(carPointer.Brand == brand)
                                {
                                    list.Add(carPointer);
                                }
                            }
                            else
                            {
                                if (carPointer.Brand == brand && carPointer.Colors == color)
                                {
                                    list.Add(carPointer);
                                }
                            }
                        }
                        else
                        {
                            if (color == "*")
                            {
                                if (carPointer.Brand == brand && carPointer.Model == model )
                                {
                                    list.Add(carPointer);
                                }
                            }
                            else
                            {
                                if (carPointer.Brand == brand && carPointer.Colors == color && carPointer.Model == model)
                                {
                                    list.Add(carPointer);
                                }
                            }
                        }
                    }
                }
                
                pointer = pointer.Right;
            }

            return list;
        }
        public Car[] GetMinMax(DoubleList<Car> list)
        {
            var response = new Car[2];
            var pointer = list._first;
            Car tempMinCar = (Car)Convert.ChangeType(pointer!.Data, typeof(Car))!; // posicion 0
            

            while (pointer.Right != null)
            {
                if (tempMinCar.Price > pointer.Right.Data.Price)
                {
                    tempMinCar = pointer.Right.Data;
                }
                pointer = pointer.Right;
            }

            var pointerMax = list._first;
            Car tempMaxCar = (Car)Convert.ChangeType(pointer!.Data, typeof(Car))!;

            while (pointerMax.Right != null)
            {
                if (tempMaxCar.Price < pointerMax.Right.Data.Price)
                {
                    tempMaxCar = pointerMax.Right.Data;
                }
                pointerMax = pointerMax.Right;
            }

            response[0] = tempMinCar;
            response[1] = tempMaxCar;

            return response;
        }
    }
}
