# gestao-escolar
Architecture CQRS Full (.NET 8.0)

#### Migrations

Go to "PairCode.GestaoEscolar.Presentations.Web.MudBlazor" project folder and open cmd
> cd src/PairCode.GestaoEscolar.Presentations.Web.MudBlazor

Add migration ex: InitialMigrationSecurityDbContext
> dotnet ef --startup-project ../PairCode.GestaoEscolar.Presentations.Web.MudBlazor migrations add [Name of the migration]SecurityDbContext -c SecurityDbContext -o Infrastructures/Data/Security/Migrations
> dotnet ef --startup-project ../PairCode.GestaoEscolar.Presentations.Web.MudBlazor migrations add [Name of the migration]EducationDbContext -c EducationDbContext -o Infrastructures/Data/Education/Migrations


#### dotnet-ef install
> dotnet tool install --global dotnet-ef

#### dotnet-ef update
> dotnet tool update --global dotnet-ef
