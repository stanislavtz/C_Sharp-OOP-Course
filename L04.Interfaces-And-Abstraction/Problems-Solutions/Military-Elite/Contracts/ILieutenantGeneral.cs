using Military_Elite.Models;
using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface ILieutenantGeneral
    {
        List<Private> Privates { get; }
    }
}
