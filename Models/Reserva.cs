namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        //ATRIBUTOS

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        private decimal valorTotal { get; set; }


        //CONSTRUTORES
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }


        //MÉTODOS
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception("A quantidade de hóspedes é maior que a capacidade da suíte.");               
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            foreach ( var hospede in Hospedes)
            {
                if (hospede == null)
                {
                    throw new Exception("A lista de hóspedes não pode ser nula.");
                }
            }
            {
                return Hospedes.Count;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            valorTotal = DiasReservados * Suite.ValorDiaria;
            

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valorTotal -= valorTotal * 0.1m;
            }
           
            Console.WriteLine($"Valor total da reserva: {valorTotal}");
            return valorTotal;
        }
    }
}