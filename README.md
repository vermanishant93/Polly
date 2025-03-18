# Polly
The De facto resilience and transient fault handling library for .Net
We can use it to create Policies in our .Net apps

# Implemented Policies by three types
- ImmediateHttpRetry
- LinearHttpRetry
- ExponentialHttpRetry

# Commands
### In Response Service
- dotnet new webapi -n ResponseService
- dotnet add package Swashbuckle.AspNetCore         

### In Request Service
- dotnet new webapi -n RequestService
- dotnet add package Microsoft.Extensions.Http.Polly
- dotnet add package Swashbuckle.AspNetCore
