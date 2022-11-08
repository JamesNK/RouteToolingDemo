# Route Tooling Demo

Preview route tooling improvements:

1. Install .NET 8 SDK from https://github.com/dotnet/installer/blob/main/README.md#table
2. Open app in Visual Studio
3. Toggle app version in csproj between 7.0 and 8.0 to turn tooling on and off.

Route tooling features:

* Route syntax colorization
* Brace match highlighting
* Route parameter highlighting
* Route completion:
  * Constraints
  * Route parameter name from delegate argument name
  * Delegate argument name from route parameter name
* Code fixer to add delegate argument from parameter
* Route syntax analyzer
