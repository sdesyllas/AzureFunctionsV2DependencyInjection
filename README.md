# Azure Functions V2 Dependency Injection

Sample demonstrating dependency injection in Azure Functions V2 using Microsoft.Extensions.DependencyInjection(https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection) nuget package

# Startup project

By using IWebJobsStartup we get access to the IServiceCollection instance where we register our IWelcomeService.

By following how Host binds function parameters as per https://github.com/Azure/azure-webjobs-sdk-extensions/wiki/The-Binding-Process we register IBindingProvider to our GenericBindingProvider which does the whole job.
 
