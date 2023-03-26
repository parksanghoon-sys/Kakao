namespace Kakao.Core.Models
{
    public class MenuModel
    {
        public string? Id { get; set; }

        public MenuModel DataGetId(string v)
        {
            Id = v;
            return this;
        }
    }
}
