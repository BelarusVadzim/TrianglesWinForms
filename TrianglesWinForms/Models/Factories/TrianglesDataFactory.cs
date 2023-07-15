namespace TrianglesWinForms.Models.Factories
{
    public class TrianglesDataFactory
    {
        public TrianglesData Create(string[] strings)
        {
            ArgumentNullException.ThrowIfNull(strings, nameof(strings));

            if (strings.Length < 2)
                throw new FormatException();

            if (!int.TryParse(strings[0], out var amount))
                throw new FormatException();

            return new TrianglesData
            {
                Amount = amount,
                CoordinatStrings = strings[1..],
            };
        }
    }
}
