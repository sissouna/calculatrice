# Projet Quiz Mathématique

Une petite application console en C# proposant un quiz de calculs mathématiques.

**Fonctionnalités**
- Propose des opérations (addition, soustraction, multiplication, division).
- Pose une série de questions et calcule le score.
- Interface texte simple pour exécution dans un terminal.

**Structure du dépôt**
- `Projet Quiz Mathématique/` : projet principal (quiz mathématique).
- `ConsoleApp1/` : projet secondaire (exemples ou ancien code).

**Prérequis**
- .NET Framework / .NET SDK installé (compatible avec les fichiers `.csproj` fournis).
- Visual Studio ou `dotnet` en ligne de commande.

**Build & Exécution (ligne de commande)**
Ouvrez un terminal dans la racine du dépôt puis exécutez :

```powershell
dotnet build "Projet Quiz Mathématique/Projet Quiz Mathématique.csproj"
dotnet run --project "Projet Quiz Mathématique/Projet Quiz Mathématique.csproj"
```

Ou ouvrez la solution `Projet Quiz Mathématique.sln` depuis Visual Studio et lancez le projet `Projet Quiz Mathématique`.

**Utilisation**
- Répondez aux questions affichées dans la console en saisissant le résultat puis `Entrée`.
- À la fin du quiz, le score et le nombre de bonnes réponses sont affichés.

**Contribution**
- Proposez des améliorations via des branches et des pull requests : tests, nouveaux types de questions, chronomètre, etc.

Si vous voulez, je peux ajouter des instructions de test automatisé ou un fichier `.gitignore` minimal.
