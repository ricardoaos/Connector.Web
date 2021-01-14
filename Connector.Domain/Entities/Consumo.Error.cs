namespace Connector.Domain.Entities
{
    public partial class Consumo
    {
        public enum Error
        {
            ConsumoShouldHaveDescription,
            ConsumoShouldHaveValue
        }
    }
}
