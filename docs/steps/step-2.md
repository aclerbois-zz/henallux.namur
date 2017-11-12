# Etape 2 : Création du modèle et utilisation d'Entity Framework Code First

A partir de Visual Studio, ajoutons deux classes dans le dossier Models : 

* Style
* Recipe




---

## Bonus

Dans vos modèles, si vous désirez ajouter une colonne avec la date de création de celle-ci, vous pouvez utilser le DataAnnotation      

```CSharp
[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
```

Vous devrez alors utiliser les deux using suivant: 

```CSharp
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
```

---

[Etape 3](./step-3.md)