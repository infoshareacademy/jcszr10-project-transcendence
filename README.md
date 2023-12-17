# <p style="text-align: center; color:Red">Project Transcendence</p>


## Opis

Gra jest osadzona w świecie fantasy, gracz wciela się w nej w stworzoną przez siebie postać, wybiera rasę oraz klasę swojej postaci i wyrusza w przygodę po świecie "Concordium" (nazwa robocza). By osiągnąć transcendencję tj. ukończyć rozgrywkę musi pokonać wszystkie napotkane problemy. **TBC...**
#

## Twórcy

 - <span style="color:yellow">**Tech Lead**</span> Piotr Niewczas
 - <span style="color:yellow">**Scrum Master**</span> Paula Migulska
 - <span style="color:Yellow">**Trener**</span> Tymoteusz Micherda
 #


# <p style="text-align: center;">Dokumentacja</p>

## Konwencja nazewnictwa

- Do nazywania klas, rekordów i structów używamy "PascalCasing"
- Interfejsy zaczynają się od prefixu I.  "interface ILogger"
- Do właściwości używamy "PascalCasing
- prywatne pola posiadają prefix _ i uzywaja "camelCasing". "private int _age = 5"
- Lokalne zmienne używaja "camelCasing"
- staramy się by nazwy byly jak najkrutsze i w punkt (ale jeśli mamy wybraćjedno albo   drugie to używamy dluzszej nazwy)
- swój featur breanch nazywamy: feature\(nazwa feature'a) zamiast spacji uzywamy " - "

#

## Git Workflow

Do końca 1 sprintu będziemy korzystać z 3 branchy:
- main
- develop
- feature

Każdy tworzy swój feature branch wychodzący od develop i pracuje nad swoim taskiem.
Po spuszowaniu wszystkich zmian robicie merge pull request a tech lead go sprawdza i jeśli wszystko się zgadza merguje zmiany i poprawia ewentualne konflikty.
Podczas 2 sprintu dodamy do tego release branch ( o tym później )

## Workflow
Na Jirze utworzone są taski, każdy jest odpowiedzialny za swoje zadanie. Duże taski są podzielone na mniejsze dla lepszego wglądu w postępy prac. 
Po wykonaniu zadania, sami aktualizujemy jego status na Jirze  lub dajemy znać Scrum Masterowi.



**Zasady:**

Działamy według poniższych zasad:
- Na spotkaniu projektowym ustalamy, co musimy zrobić w danym Sprincie
- Na podstawie ustaleń wybieramy Taski, które chcemy wykonać
- Na Slacku piszemy o postępach prac - jeżeli coś wrzucamy na GitHuba informujemy o tym
- Jeżeli mamy jakiś problem z Taskiem zgłaszamy to grupie i działamy nad tym razem. 


