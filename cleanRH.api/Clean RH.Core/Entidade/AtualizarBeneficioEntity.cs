namespace Clean_RH.Core.Entidade
{
    public class AtualizarBeneficioEntity
    {
        public AtualizarBeneficioEntity(int idContratado, List<Beneficio> beneficio)
        {
            IdContratado = idContratado;
            Beneficio = beneficio;
        }

        public int IdContratado { get; set; }
        public List<Beneficio> Beneficio { get; set; }
    }

    public class Beneficio
    {
        public Beneficio(int idConBeneficio, int idTipoBeneficio, DateTime dtdInicio)
        {
            IdConBeneficio = idConBeneficio;
            IdTipoBeneficio = idTipoBeneficio;
            DtdInicio = dtdInicio;
        }

        public int IdConBeneficio { get; set; }
        public int IdTipoBeneficio { get; set; }
        public DateTime DtdInicio { get; set; }
    }
}
