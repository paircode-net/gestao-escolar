# gestao-escolar
Architecture CQRS Full (.NET 8.0)

#### Migrations

Go to "PairCode.GestaoEscolar.Presentations.APP.Blazor" project folder and open cmd
> cd src/PairCode.GestaoEscolar.Presentations.APP.Blazor

Add migration ex: InitialMigrationDefaultDbContext
> dotnet ef --startup-project ../PairCode.GestaoEscolar.Presentations.APP.Blazor migrations add [Name of the migration]DefaultDbContext -c DefaultDbContext -o Default/Migrations
> dotnet ef --startup-project ../PairCode.GestaoEscolar.Presentations.APP.Blazor migrations add [Name of the migration]GestaoEscolarDbContext -c GestaoEscolarDbContext -o Code/Migrations


#### dotnet-ef install
> dotnet tool install --global dotnet-ef

#### dotnet-ef update
> dotnet tool update --global dotnet-ef
