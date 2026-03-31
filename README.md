1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Git wykona fast-forward, gdy gałąź, do której scalasz, nie ma nowych commitów względem gałęzi źródłowej — innymi słowy historia jest liniowa i można jedynie „przesunąć wskaźnik” gałęzi.

Merge commit powstaje wtedy, gdy obie gałęzie mają własne, niezależne commity i Git musi połączyć dwie różne historie. W takiej sytuacji tworzony jest dodatkowy commit scalający.

2. Czym w praktyce różni się merge od rebase?

Merge:

łączy dwie gałęzie, zachowując pełną historię,
tworzy dodatkowy commit scalający (jeśli nie da się zrobić fast-forward),
historia jest bardziej „rozgałęziona”, ale wierna rzeczywistości pracy zespołowej.

Rebase:

„przepisuje” historię commitów, przenosząc je na nową bazę,
nie tworzy merge commitów,
historia jest liniowa i bardziej czytelna, ale zmienia oryginalne commity (nowe identyfikatory SHA).

W praktyce: merge zachowuje historię taką, jaka była, a rebase ją upraszcza i porządkuje.

3. W jaki sposób został rozwiązany konflikt w repozytorium?

Konflikt został rozwiązany poprzez ręczną edycję plików, w których Git oznaczył sprzeczne fragmenty kodu. Wybrano odpowiednie wersje zmian z obu gałęzi (lub połączono je logicznie), usunięto znaczniki konfliktu (<<<<<<<, =======, >>>>>>>), a następnie:

dodano poprawione pliki (git add),
wykonano commit kończący proces merge.

Dzięki temu historia została poprawnie scalona, a konflikt został usunięty.
