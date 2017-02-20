using System;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Interview.Validation
{
    // Validator for action parameters applied either to individual actions 
    //   or to the whole controller
    public class ActionParametersRegexValidatorAttribute : ActionFilterAttribute
    {
        private string regex;
        private RegexOptions regexOpts;
        private string validationErrorMessage;

        public ActionParametersRegexValidatorAttribute(string regex, RegexOptions regexOpts, string validationErrorMessage)
        {
            this.regex = regex;
            this.regexOpts = regexOpts;
            this.validationErrorMessage = validationErrorMessage;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var descriptor = context.ActionDescriptor;

            if (descriptor != null)
            {
                var parameters = descriptor.GetParameters();

                foreach (var parameter in parameters)
                {
                    var argument = context.ActionParameters[parameter.ParameterName] as string;

                    if (!Regex.Match(argument, regex, regexOpts).Success)
                        throw new Exception(validationErrorMessage);
                    //EvaluateValidationAttributes(parameter, argument, null);
                }
            }

            base.OnActionExecuting(context);
        }
        /*
        private void EvaluateValidationAttributes(System.Web.Mvc.ParameterDescriptor parameter, object argument, ModelStateDictionary modelState)
        {
            var validationAttributes = parameter.CustomAttributes;

            foreach (var attributeData in validationAttributes)
            {
                var attributeInstance = CustomAttributeExtensions.GetCustomAttribute(parameter, attributeData.AttributeType);

                var validationAttribute = attributeInstance as ValidationAttribute;

                if (validationAttribute != null)
                {
                    var isValid = validationAttribute.IsValid(argument);
                    if (!isValid)
                    {
                        modelState.AddModelError(parameter.Name, validationAttribute.FormatErrorMessage(parameter.Name));
                    }
                }
            }
        }*/
    }
}