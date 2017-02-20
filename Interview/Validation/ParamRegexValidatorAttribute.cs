using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;
using System.Text.RegularExpressions;
//using System.Web.Mvc;

namespace Interview.Validation
{
    // Validates a particular Action parameter and is applied to it directly 
    // in the action's parameter list before the parameter declaration like so
    // ActionName([ParamValidator(arg)] string actionArg)
    public class ParamRegexValidatorAttribute : ParameterBindingAttribute
    {
        private readonly string regex;
        public ParamRegexValidatorAttribute(string regex)
        {
            this.regex = regex;
        }

        public override HttpParameterBinding GetBinding(HttpParameterDescriptor parameter)
            => new ParameterValidatorAttribute(parameter, regex);
    }

    public class ParameterValidatorAttribute : HttpParameterBinding, IValueProviderParameterBinding
    {
        private readonly string regex;
        public HttpParameterBinding DefaultUriBinding;

        public ParameterValidatorAttribute(HttpParameterDescriptor desc, string regex)
            : base(desc)
        {
            this.regex = regex;
            var defaultUrl = new FromUriAttribute();
            DefaultUriBinding = defaultUrl.GetBinding(desc);
            ValueProviderFactories = defaultUrl.GetValueProviderFactories(desc.Configuration);
        }

        public override Task ExecuteBindingAsync(ModelMetadataProvider metadataProvider, HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            return DefaultUriBinding.ExecuteBindingAsync(metadataProvider, actionContext, cancellationToken).ContinueWith((tsk) =>
            {
                var currentBoundValue = this.GetValue(actionContext);
                var currentBound = (string)currentBoundValue;
                if (!string.IsNullOrWhiteSpace(currentBound) && !string.IsNullOrWhiteSpace(regex))
                {
                    var match = Regex.Match(currentBound, regex, RegexOptions.IgnoreCase);
                    if (match.Success)
                        return;
                }
                var preconditionFailedResponse = actionContext.Request.CreateResponse(
                    HttpStatusCode.PreconditionFailed,
                    $"The parameter {DefaultUriBinding.Descriptor.ParameterName} must be a valid automobile manufacturer name");
                throw new HttpResponseException(preconditionFailedResponse);
            }, cancellationToken);
        }

        public IEnumerable<ValueProviderFactory> ValueProviderFactories { get; }
    }
}