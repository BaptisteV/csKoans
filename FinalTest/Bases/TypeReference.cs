namespace FinalTest.Bases
{
    public class TypeReference
    {
        public int I { get; private set; }

        public TypeReference(int i)
        {
            I = i;
        }

        public override bool Equals(object obj)
        {
            var item = obj as TypeReference;
            if (item == null)
            {
                return false;
            }
            return item.I == this.I;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}