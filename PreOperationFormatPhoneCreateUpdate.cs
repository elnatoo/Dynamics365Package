using System;
using Microsoft.Xrm.Sdk;
using System.Text.RegularExpressions;

namespace Dynamics365Package
{
    public class PreOperationFormatPhoneCreateUpdate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the execution context from the service provider
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // Check if the input parameters contain the Target entity
            if (!context.InputParameters.ContainsKey("Target"))
            {
                throw new InvalidPluginExecutionException("No target was found.");
            }

            // Gets the Target entity from the input parameters
            var entity = context.InputParameters["Target"] as Entity;

            // Check if entity attributes contain the telephone1 attribute
            if (!entity.Attributes.Contains("telephone1"))
            {
                return; // No telephone1 attribute to format
            }

            string phoneNumber = (string)entity["telephone1"];

            // Removes all non-numeric characters from the user-provided phone number
            var formattedNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

            entity["telephone1"] = formattedNumber;
        }
    }
}
