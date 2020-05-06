namespace _06_ByteBank
{
    internal class Customer
    {
        private string _cpf;
        public string Name { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // to write cpf validation logic
                _cpf = value;
            }
        }
        public string Profession { get; set; }
    }
}
