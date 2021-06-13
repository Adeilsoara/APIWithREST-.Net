using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRest01.Hypermidia.Abstract {
    public interface ISupportHypermidia {
        List<HyperMediaLink> Links { get; set; }
    }
}