﻿using Kakao.Core.Args;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Core.Evnets
{
    public class LoginCompletedPubSub : PubSubEvent<LoginCompletedArgs>
    {
    }
}
