namespace Kakao.Core.Models
{
    public class FriendsModel
    {
        public string Email { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public FriendsModel DataGen(string v1, string v2)
        {
            Id = v1;
            Name = v2;
            return this;
        }
    }
}
