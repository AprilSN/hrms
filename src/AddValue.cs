namespace HrmsProject
{
    internal class AddValue
    {
        private string v1;
        private int v2;
        private int v;

        public AddValue(int v)
        {
            this.v = v;
        }

        public AddValue(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}