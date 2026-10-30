 # Dynamics 365 Package

This project contains a package for extending or configuring Microsoft Dynamics 365 and Power Platform Dataverse. It is intended to be imported into a Dataverse environment and used as a starting point for the project's customizations.

This project was built by following the [Extend plug-ins in Power Platform module](https://learn.microsoft.com/en-us/training/modules/extend-plug-ins/) from the Microsoft Learn course Microsoft Power Platform Developer.

## Recommended use in Dataverse

1. Make sure you have access to the target Dataverse environment and the required permissions to import solutions.
2. In Power Apps, select the target environment and open **Solutions**.
3. Import the solution package provided by this project, following the import prompts.
4. Review any dependencies and environment-specific settings, then publish the customizations.
5. Test the changes in a non-production environment before deploying to production.

## Local development

Please refer to the documentation steps on how to generate your own Strong Name Key (.snk) file for usage in signing the software assembly of the project.