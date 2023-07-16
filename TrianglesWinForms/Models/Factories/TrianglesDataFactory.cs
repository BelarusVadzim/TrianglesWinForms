using TrianglesWinForms.Utils;

namespace TrianglesWinForms.Models.Factories
{
    public class TrianglesDataFactory
    {
        private readonly CoordinatsParser coordinatsParser;

        public TrianglesDataFactory()
        {
            coordinatsParser = new CoordinatsParser();
        }

        public TrianglesData Create(string[] strings)
        {
            ArgumentNullException.ThrowIfNull(strings, nameof(strings));

            if (strings.Length < 2)
                throw new FormatException();

            if (!int.TryParse(strings[0], out var amount))
                throw new FormatException();

            if(strings.Length - 1 != amount)
                throw new InvalidDataException("Incorrect number of coordinate lines");

            var coordinatStrings = strings[1..];
            var coordinats = coordinatStrings.Select(x => coordinatsParser.Parse(x)).ToArray();

            return new TrianglesData
            {
                Amount = amount,
                Coordinates = coordinats,
            };
        }
    }
}
