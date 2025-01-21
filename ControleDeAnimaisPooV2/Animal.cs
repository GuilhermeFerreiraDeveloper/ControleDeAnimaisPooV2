namespace ControleDeAnimaisPooV2
{
    internal class Animal
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set
            {               
                if (value == "CACHORRO" || value == "GATO" || value == "PEIXE")
                {
                    tipo = value; 
                }
                else
                {
                    tipo = "PEIXE"; 
                }
            }
        }
    }
}
