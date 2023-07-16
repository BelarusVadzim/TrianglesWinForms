namespace TrianglesWinForms.Utils
{
    public sealed class CoordinatsParser
    {
        public int[] Parse(string coordinatsString) =>
            coordinatsString.Split(' ')
                .Select(c => 
                {
                    if(int.TryParse(c, out int value))
                        return value;
                    throw new InvalidDataException();
                })
                .ToArray();
    }
}
