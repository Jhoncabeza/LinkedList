namespace CarList.Logic
{
    public class Car
    {
        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int Year { get; set; }

        public string? Colors { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Colors} - {Year} - {Price:C2}";
        }
    }
}
