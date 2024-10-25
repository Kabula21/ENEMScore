namespace ENEMScore.Client.Data
{
    public class CursoInfo
    {
        // Propriedade para a universidade
        public string Universidade { get; set; }

        // Propriedade para o ano
        public int Ano { get; set; }

        // Propriedade para o campus
        public string Campus { get; set; }

        // Propriedade para o curso
        public string Curso { get; set; }

        // Propriedade para o turno
        public string Turno { get; set; }

        // Propriedade para o tipo de vaga
        public string Tipo { get; set; }

        // Nota de corte do curso
        public double NotaDeCorte { get; set; }

        // Pesos das notas do ENEM
        public double CienciasDaNatureza { get; set; }
        public double CienciasHumanas { get; set; }
        public double Linguagens { get; set; }
        public double Matematica { get; set; }


    }
}
