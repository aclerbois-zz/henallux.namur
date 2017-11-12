# GIT - Information additionnel le

Contenu additionnel pour GIT

## Se présenter à GIT

La première chose à faire lorsque GIT est installé, se présenter

```bash
git config --global user.name "AClerbois"
git config --global user.email "adrien@aclerbois.be"
```

## Configurer GIT 

### Définir l'éditeur par défaut (merge)

```bash
git config --global core.editor "path to VS Code"
```

## Répository

### Créer un nouveau repository

```bash
git init
```

### Clone un repository distant

```bash
git clone https://github.com/aclerbois/henallux.namur.git
```

## Status

Connaitre le status courant du point HEAD

```bash
git status
```

## Différence

Connaitre les différences avec le pointeur courant avec le précédent

```bash
git diff
```

## Ajouter des fichiers / modifications

### Ajouter un fichier

Ajout du fichier readme.md, si le fichier avait déjà été présent dans le "source control" et qu'il avait subit des modifications, il sera ajouté dans l'état "stage".

```bash
git add readme.md
```

### Ajouter plusieurs fichiers

```bash
git add readme.md
```

### Ajouter toutes les modifications et fichier supprimé

```bash
git add .
```

## Ajouter ses changements dans un commit 

```bash
git commit -m "Avec un petit message c'est toujours mieux"
```

## Synchroniser avec le reste du monde

### Récupérer les dernières modifications

Tirer les dernières modifications de la branche courante

```bash
git pull
```

### Envoyer nos dernières modifications

```bash
git push
```

## Consulter l'historique des commits

```bash
git log
```

> **Attention**: Faire un git log sur un projet avec un grand historique va prendre du temps, vous pouvez spécifier le nombre de commit que vous désirez uniquement voir un certain nombre 

```bash
git log -n 5
```

## A l'aide je suis perdu !

Dès que vous vous posez des questions sur une commande, vous pouvez consulter l'aide grâce à la commande :

```bash
git help log
```

## Branches

### Convention de branche :

#### GitFlow 

Dans le cadre d'une utilisation du **GitFlow**, toutes les branches sont écrites en minuscule. 

Il existe deux branches qui resteront en vie tout au long du développement : 

- master : chaque commit sur cette branche représente une version "finie" de l'application
- develop : Cette branche représente le développement, elle doit être stable.

Il existe des branches annexes qui vont permettant des travailler sur le produit que vous souhaiter développer. 

##### Features

Les branches features sont des branches de développement de fonctionnalité.

Elles sont préfixées par feature/. Ce qui permet à certains logiciels  d'afficher un vue triée par feature.

##### Release

Une fois que l'on a une branche develop qui est remplie de nouvelle fonctionnalité et que l'on souhaite la mettre en production, on créée une branche Release. 

Ces branches sont préfixées par release/. Dépendant des conventions en entreprise, elles peuvent contenir un numéro de version ou une date. 

La nouvelle branche pourrait être mise en test. L'apparition de bug n'est pas à exclure. On va donc réaliser des modifications sur cette branche.

Les commit de correction seront pris en compte pour la release et lorsque l'on a une version qui peut aller en production (master), on merge le contenu de la branche release/***** dans master mais également dans develop pour récupérer les corrections apportées à la branche release.


##### HotFix

Il se peut qu'un problème arrive en production (master), dès lors on va reprendre la version en production (master) et l'on va créer une branche dite hotfix, on va réaliser les corrections et faire un merge vers la branche master et develop. 

Ces branches sont préfixées par hotfix/.

### Listes toutes les branches existantes

```bash
git branch -av
```

### Créer une nouvelle branche

```bash
git branch "nouvelle-branche"
```

### Aller sur une autre branche

```bash
git checkout branch-2
```

### Supprimer une branche

```bash
git branch -d "ma-branche-a-supprimer"
```
### Remonter une branche vers le serveur remote

```bash
 git checkout --track "remote/nouvelle-branche"
```

Si vous ne le faite pas, mais que vous tentez de faire un push, GIT va vous informer qu'il ne peut pas le faire et va vous donner la commande à exécuter pour cela.

## Merge une branche vers une autre. 

Il est important de penser de se placer sur la branche qui va ***Recevoir*** les modifications qu'une autre branche. 

Exemple, je veux faire un merge entre ma branche feature/nouvelle-fonctionnalite vers develop.

```bash
git status
> Vous êtes sur la branche feature/nouvelle-fonctionnalite

git checkout develop
> Vous êtes sur la branche develop

git merge feature/nouvelle-fonctionnalite
> Merge fait en esperant qu'il n'y ai pas de conflit
```

## Tag sa version

Une fois que vous êtes arriver à une version qui vous convient, vous pouvez placer un tag pour un numéro de version 

### Lister les tags existant

```bash
git tag
```

### Ajouter un tag

```bash
git tag 1.0.0 -m "Message pour faire beau"
```

### Se place sur un tag 

```bash
git checkout tags/1.0.0
```

## Annuler ses changements 

```bash
git reset --hard HEAD
```