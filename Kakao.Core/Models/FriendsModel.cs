using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Core.Models
{
    public class FriendsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FriendsModel DataGen(int v1, string v2)
        {
            Id = v1;
            Name = v2;
            return this;
        }
    }
}
