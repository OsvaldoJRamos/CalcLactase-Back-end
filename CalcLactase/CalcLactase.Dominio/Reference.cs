namespace CalcLactase.Dominio
{
    public class Reference
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public Reference(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
