using APIRest01.Hypermidia.Abstract;
using System.Collections.Generic;

namespace APIRest01.Hypermidia.Filter {
    public class HyperMidiaFilterOptions {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}