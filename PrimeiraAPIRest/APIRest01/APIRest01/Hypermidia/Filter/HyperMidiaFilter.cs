using APIRest01.Hypermidia.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest01.Hypermidia.Filter {
    public class HyperMidiaFilter : ResultFilterAttribute {
        private readonly HyperMidiaFilterOptions _hyperMidiaFilterOptions;

        public HyperMidiaFilter(HyperMidiaFilterOptions hyperMidiaFilterOptions) {

            _hyperMidiaFilterOptions = hyperMidiaFilterOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context) {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context) {
            if (context.Result is OkObjectResult objectResult) {
                var enricher = _hyperMidiaFilterOptions
                    .ContentResponseEnricherList
                    .FirstOrDefault(x => x.CanEnrich(context));
                if (enricher != null) Task.FromResult(enricher.Enrich(context));
            }
        }
    }
}