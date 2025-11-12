# Guide de contribution

Ce document est le guide de contributions. Il définit les règles à respecter pour contribuer sur le projet.

## Architecture des fichiers

Le projet est structuré par grandes catégories :
- Scenes : Regroupe l'ensemble des scènes. Peut être sous découpé au besoin (si plusieurs scènes par niveau par exemple)
- Settings : Regroupe les fichiers de configurations du URP (Universal Render Pipeline)
- Sprites : Regroupe l'ensemble des éléments graphiques. Celui-ci sera sous-découpé en grandes catégorie :
  - UI : Pour les éléments graphiques notamment les menus et zones textuelles
  - Props : Eléments de décor
  - Objects : Armes, objets récupérable pas le joueur
  - Characters : Eléments associés aux personnages
- Scripts : Regroupe les différents scripts (code C#) utilisés.

## Utilisation de git

Il est important de séparer autant que possible le développement des différentes fonctionnalités dans des branches différentes. Lorsque ces fonctionnalités atteignent un niveau de maturité suffisantes elles seront combinées à la branche principale (main). Puis, lorsque la branche principale aura atteinte une maturité suffisante en fonction des attendues de la version, elle sera tag et une release sera créée.

Il est important de correctement nommé les commits et si besoin ajouté une description si les changements apportés sont trop nombreux.