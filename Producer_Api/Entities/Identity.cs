namespace Producer_Api.Entities
{
    public class Identity
    {
        public long Id { get; set; }
        public bool IsNewIdentity => Id > 0;
    }
}
