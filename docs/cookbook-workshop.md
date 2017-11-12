# Cookbook Workshop

Réaliser un site web pour la présentation et la visualisation d'un Cookbook 


## Etape 0 : Créer son environment de développement

* Créer un compte sur visual studio online ou github 
* Créer un repository sur le source control
* Créer un dossier 
* Faire un git init
* Ajouter des dossiers: 
    * src
    * docs
* Dans le dossier racine ajouter un readme.md
* Dans le dossier src ajouter un .gitignore avec visual studio et visual studio code voir [gitignore.io](http://www.gitignore.io)
* Remonter son code dans le source control git de son choix


## Etape 1 : Création de la structure du project

* Créer un nouveau projet 

> **.NET Core** : Ouvrir une console dans un dossier src et y utliser la commande line : 
>```bash
> dotnet new sln -n "Henalux.Cookbook"
>> The template "Solution File" was created successfully.
>
> dotnet new mvc -n "Henalux.Cookbook.Website"
>> The template "ASP.NET Core Web App (Model-View-Controller)" was created successfully.
>> This template contains technologies from parties other than Microsoft, see https://aka.ms/template-3pn for details.
>> 
>> Processing post-creation actions...
>> Running 'dotnet restore' on Henalux.Cookbook.Website\Henalux.Cookbook.Website.csproj...
>>   Restoring packages for C:\_softlab\henallux.namur\src\NETCORE\Step 1\Henalux.Cookbook.Website\Henalux.Cookbook.Website.csproj...
>>   Restore completed in 80.6 ms for C:\_softlab\henallux.namur\src\NETCORE\Step 1\Henalux.Cookbook.Website\Henalux.Cookbook.Website.csproj.
>>   Generating MSBuild file C:\_softlab\henallux.namur\src\NETCORE\Step 1\Henalux.Cookbook.Website\obj\Henalux.Cookbook.Website.csproj.nuget.g.props.
>>   Generating MSBuild file C:\_softlab\henallux.namur\src\NETCORE\Step 1\Henalux.Cookbook.Website\obj\Henalux.Cookbook.Website.csproj.nuget.g.targets.
>>   Restore completed in 2.96 sec for C:\_softlab\henallux.namur\src\NETCORE\Step 1\Henalux.Cookbook.Website\Henalux.Cookbook.Website.csproj.
>> 
>> 
>> Restore succeeded.
>> 
>dotnet sln add .\Henalux.Cookbook.Website\Henalux.Cookbook.Website.csproj
>> Project `Henalux.Cookbook.Website\Henalux.Cookbook.Website.csproj` added to the solution.
>```

Lancer dans Visual Studio la solution Henalux.Cookbook.sln

> **.NET Framework** : Ouvrir une nouvelle instance de Visual Studio
> * Cliquez sur **Créer un nouveau project...**
> * Sur la gauche, cliquez sur **Visual C#** > **Web**
> * Sélectionnez "**ASP.NET Web Application (.NET Framework)**"
> * Entrez comme project name : **Henalux.Cookbook.Website**
> * Sélectionnez ou entrez l'endroit ou vous souhaitez enregister votre solution (src de l'environement)
> * Cochez **Create directory for solution** et indiquez dans la textebox Solution name : **Henalux.Cookbook**
> * Cliquez sur **OK**
> * Une fenêtre s'ouvre et vous demande de choisir parmis plusieurs propositions :
>    * .NET Framework (dropdown suppérieur)
>    * Web Application (Model-View-Controller)
>    * Authenciation : **No Authentication**
>  * Cliquez sur **OK**
> Le projet va se créer. 

Compilé votre projet pour s'assurer que tous fonctionne correctement. 

> Ruban supérieur :  **Build** > **Build Solution**

> Raccourci : Appuyé simulanément sur les touches **[CTRL] + [MAJ] + [B]**.



## Etape 2 : Création du modèle et utilisation d'Entity Framework Code First

## Etape 3 : Afficher une page d'accueil, une page pour lister les produits et une page de détails

## Etape 4 : Des routes sexy, et le référencement dans tous cela ? 

## Etape 5 : Créer une zone d'administration

## Etape 6 : CRUD d'une recette


