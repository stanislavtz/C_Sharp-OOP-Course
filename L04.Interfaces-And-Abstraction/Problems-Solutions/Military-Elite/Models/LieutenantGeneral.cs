using System;
using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<Private> Privets => throw new NotImplementedException();
    }
}
