# Etape 2 : Création du modèle et utilisation d'Entity Framework Code First

A partir de Visual Studio, ajoutons deux classes dans le dossier Models : 

* Evaluation
* Recipe

```CSharp
namespace MICCookBook.SDK.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
```

```CSharp
using Newtonsoft.Json;

namespace MICCookBook.SDK.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        [JsonIgnore]
        public string PictureUrl => "http://mic-cookbook.azurewebsites.net" + Picture;
    }
}
```

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