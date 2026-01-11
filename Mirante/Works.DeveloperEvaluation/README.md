# Developer Evaluation Project

## Considerações:

1 – Feito com NetCore6, Visual Studio 22.

2 - Usei uma arquitetura DDD para tentar deixar o mais limpo possível, com separação dos projetos.

3 – O designer parttern eu optei pelo CQRS. Eu gosto muito pois faz uma separação entre buscas e ações (Update, Insert, Delete) no banco de dados, 
e com isso fornece uma melhor organização e facilita em futuras manutenções. Também facilita a comunicação com mais de um banco de dados. 
Ponto negativo talvez seja a maior quantidade de arquivos... Infelizmente não ficou 100% por falta de tempo e talvez conhecimento. 

4 - Para banco dados usei o SQL Express com Migrations: 
Criar o banco dados: [DeveloperEvaluation]
NO PACKAGE MANAGER CONSOLE RODAR O MIGRATIONS
PROJ:Adapters\Drivers\WebApi\Works.DeveloperEvaluation.WebApi
add-migration Inicio -Context Context -verbose
update-database Inicio 
 
5 -Para executar deve inicar dois projetos:
Works.DeveloperEvaluation.Frontend 
Works.DeveloperEvaluation.WebApi
 
6 - FALTOU FAZER:
6.1 - Cobertura testes 

6.2 - Colocação no docker
No cmd:
c:\Projetos\Mirante\Works.DeveloperEvaluation>docker build -t testemirante .
c:\Projetos\Mirante\Works.DeveloperEvaluation>docker run -d -p 5001:80 --name web-api-container testemirante
Na imagem chamar swagger: http://localhost:5001/swagger/index.html

7 - Testes:
7.1 - No projeto XUnit.Coverlet.Collector: 
dotnet test C:\Projetos\Works.DeveloperEvaluation\tests\Works.DeveloperEvaluation.Unit\Works.DeveloperEvaluation.Collector.Unit\Works.DeveloperEvaluation.Collector.Unit.csproj --collect:"XPlat Code Coverage"
7.2 - No projeto XUnit.Coverlet.MSBuild:
7.2.1 - dotnet tool update -g dotnet-reportgenerator-globaltool
7.2.2 - dotnet test C:\Projetos\Works.DeveloperEvaluation\tests\Works.DeveloperEvaluation.Unit\Works.DeveloperEvaluation.MSBuild.Unit1\Works.DeveloperEvaluation.MSBuild.Unit.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
7.2.3 - reportgenerator -reports:"C:\Projetos\Works.DeveloperEvaluation\tests\Works.DeveloperEvaluation.Unit\Works.DeveloperEvaluation.Collector.Unit\TestResults\931eb173-2b7d-44ee-8906-ce95c1eb40f4\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html coverage_report\index.html


