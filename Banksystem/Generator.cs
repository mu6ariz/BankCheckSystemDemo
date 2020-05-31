namespace Banksystem
{

    class Generator
    {
        private int counter;

        public Generator()
        {
            counter = 0;
        }

        public int GenerateNumber()
        {
            counter++;
            return counter;
        }
    }
}
