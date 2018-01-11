# Entity Framework Code First - Information additionnel 

Contenu additionnel pour entity framework 

## Installation d'Entity Framework

### Via nuget

- Clique droit sur votre project dans Visual Studio
- Sélectionner **Manage NuGet Package**
- Rechercher **EntityFramework**
- Cliquer sur **Install**
- Accepter la license

## Connection String pour .NET Core

La connection string doit être ajoutée dans le fichier appSettings.json 

```JSON
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\SQLEXPRESS;Database=devdaybe;Trusted_Connection=True;"
    },
    "Logging": {
        "IncludeScopes": false,
        "LogLevel": {
            "Default": "Warning"
        }
    }
}
```

## Navigation d'une entity à une autre

## Exemple de DBContext 

```CSharp
public class ApplicationDbContext : DbContext {

    // Constructeurs 
    public ApplicationDbContext(DbContextOptions<DevDayContext> options) : base(options) {}

    public ApplicationDbContext() : base() {}

    // Definition des DbSet (table)
    public DbSet<Product> Products { get; set; }

    // Méthodes utilisées pour ajouter de la configuration supplémentaire 
    protected override void OnModelCreating(ModelBuilder modelBuilder) {}

}
```
### Définir le nom de la table à utiliser 

Dans certains cas, il est possible de définir le nom de la table que l'on souhaite avoir avec un DbSet 

#### 1. Fluent API

```CSharp
protected override void OnModelCreating(ModelBuilder modelBuilder) {
    // do stuff
    modelBuilder.Entity<Product>().ToTable("Products");
    // do stuff
}
```

#### 2. DataAnnotations

Pour pouvoir utiliser le DataAnnotations, vous devez référence la librarie suivante :

```CSharp
using System.ComponentModel.DataAnnotations.Schema;
```

Et au dessus de votre class utiliser la décoration suivante : 

```CSharp
[Table("Products")]
public class Products { }
```

## Commande line à utiliser dans Visual Studio

Les commandes suivantes sont à utiliser dans le **Package Manager Console**

### Activer EntityFramework dans le project 

> N'oubliez pas d'ajouter une ConnectionString à votre solution qui correspond à votre Context sur lequel vous souhaitez activer entity framework code first. Votre code doit également compiler à l'execution de chaque commande EF Code First

```Console
Enable-Migrations
```

### Ajouter une modification dans votre context

Lorsque vous avez ajouté / modifié / supprimé dans colonnes dans une table ou ajouté / supprimé une ou plusieurs table(s) dans votre context, vous devez créer un point de Migration. 

> La syntaxe est Add-Migration [Nom de la migration]

```Console
Add-Migration AddProductsTable
```

### Mettre à jour la base de données

La manipulation suivante va permettre de mettre à jour la base de données définie dans la ConnectionString

```Console
Update-Database
```

> **Attention :**
> - Les fichiers de migrations font évoluer la base de données de manière incrémentale.
> - La migration se base sur l’état courant de la DB. Il ne peut y avoir de migration en attente d’application pour en générer une nouvelle.
> - Si la base de données a été modifiée avant l’application d’une migration, la migration peut échouer ou se terminer mais laisser la base de données dans un état non-voulu.

## Relation Entity Framework many-to-many

Dans un système de gestion de base de données relationnelle, il exsite trois type de relation:
- one-to-one
- one-to-many
- many-to-many

Les deux premiers sont complètements intégrer dans Entity Framework Code First et de façon native. La dernière nécessite une configuration supplémentaire.

Prenons l'exemple qu'un produit a une ou plusieurs catégorie(s) et qu'une catégorie à un ou plusieurs produit(s).

Nous devons, dans un premier temps, créer une class qui va permettre de faire une liaison entre les deux entités. 

```CSharp
    public class ProductCategory
    {
        public ProductCategory();

        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
```
Ensuite dans le Context, nous devons ajouter dans la méthode **OnModelCreating**, la configuration pour la liaison

```CSharp
public DbSet<SpeakerSession> SpeakerSessions { get; set; }


protected override void OnModelCreating(ModelBuilder modelBuilder) {

    // Définition du nom de la table, pas obligatoire, mais impotatant si l'on veut suivre une convention  .
    modelBuilder.Entity<ProductCategory>().ToTable("ProductCategories");
    // do stuff
    modelBuilder.Entity<Product>()
        .HasOne(ss => ss.Category)
        .WithMany(ss => ss.ProductCategory)
        .HasForeignKey(ss => ss.CategoryId);

    modelBuilder.Entity<Category>()
        .HasOne(ss => ss.Product)
        .WithMany(ss => ss.ProductCategory)
        .HasForeignKey(ss => ss.ProductId);

  // do stuff
}
```

## Ressources 

* EntityFramework tutorail : [http://www.entityframeworktutorial.net/code-first/](http://www.entityframeworktutorial.net/code-first/)
