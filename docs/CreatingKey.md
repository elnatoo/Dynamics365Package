# Creating a key for usage in the project

1. Right-click the project and select the __Properties__ option
2. Select the Signing tab and check the box labeled _Sign the assembly_
3. Select __New Key File__
4. Enter your key's name (e.g. contoso.snk) in the __Key file name__ field and uncheck the _Protect my key file with a password_ box, then select OK
5. Your key should now be generated in the root of your project
6. Close out of the __Properties__ tab and build the project to ensure the build succeeds