# Les 5 types de Tri

## 1) Tri par Sélection
### Principe
- Trouver le plus petit élément du tableau.
- Le placer en première position.
- Répéter le processus pour le reste du tableau.

<p><img src="https://i.ibb.co/gDKzKkn/Selection-Sort.png" alt="Selection Sort"></p>

### Avantages
- Facile à comprendre et à coder.
- Nombre minimal d’échanges (n-1).
- Convient lorsque les échanges sont coûteux.

### Inconvénients
- Complexité élevée (O(n²)), peu performant sur de grandes données.
- Inefficace si les données sont déjà triées ou presque triées.

## 2) Tri par Insertion
### Principe
- Diviser le tableau en deux parties : triée et non triée.
- Insérer chaque élément de la partie non triée à sa position correcte dans la partie triée.
- Répéter jusqu’à ce que tout le tableau soit trié.

<p><img src="https://i.ibb.co/W2WhCzy/Insertion-Sort.png" alt="Insertion Sort"></p>

### Avantages
- Simple à implémenter.
- Très rapide (O(n)) si le tableau est déjà trié ou presque trié.

### Inconvénients
- Complexité (O(n²)) dans le pire des cas (données inversées).
    - En moyenne : N²/4 comparaisons et N²/2 échanges
    - Worst case : N²/2 comparaison et N²/2 échanges
    - Best case : N comparaisons et 0 échange (si le vecteur était déjà trié)
- Nécessite beaucoup de décalages dans un tableau.

## 3) Tri Shell
### Principe
- Extension du tri par insertion.
- Trie des sous-vecteurs formés en sélectionnant des éléments espacés par une valeur h.
- Diminue progressivement h pour affiner le tri.
<p><img src="https://i.ibb.co/jyBKKyC/Shell-sort.png" alt="enter image description here"></p>

### Avantages
- Réduit significativement la complexité du tri par insertion (O(n^1.5) à O(n log² n)).
- Très performant pour des données désordonnées.

### Inconvénients
- Dépend du choix des incréments (h), ce qui peut compliquer l’implémentation.
- Moins performant que QuickSort dans certaines situations.

## 4) Heap Sort (Tri par Tas)
### Principe
- Transformer le tableau en un tas (structure en arbre binaire).
- Extraire le plus grand élément (racine) et le placer à la fin du tableau.
- Répéter en ajustant le tas pour le reste du tableau.

<p><img src="https://i.ibb.co/fY8rMXW/Heap-Sort.png" alt="enter image description here"></p>

### Avantages
- Complexité garantie O(n log n), indépendamment des données.
- Pas besoin de mémoire supplémentaire (tri en place).

### Inconvénients
- Pas stable (les éléments égaux peuvent changer d’ordre).
- Moins rapide que QuickSort dans le cas moyen.

## 5) QuickSort
### Principe
- Choisir un pivot dans le tableau.
- Réorganiser le tableau pour que les éléments inférieurs au pivot soient à gauche et les éléments supérieurs à droite.
- Répéter le processus sur les sous-tableaux à gauche et à droite du pivot.

<p><img src="https://i.ibb.co/K0jQdKP/Capture-d-cran-230.png" alt="enter image description here" width="700"></p>

### Avantages
- Très rapide en moyenne (O(n log n)).
- Bien adapté aux très grandes données.
- Peu gourmand en mémoire si bien implémenté.

### Inconvénients
- Complexité O(n²) dans le pire cas (pivot mal choisi).
- Non stable.


## 6) Listes simplement chaînées
### Principe
Structure de données pouvant contenir plusieurs éléments. Chaque élément possède un pointeur vers l’élément suivant. La liste est un pointeur vers le premier élément de la liste appelé  <strong>“Head”</strong>. Le dernier élément pointe vers une adresse spécifique pour signifier la fin de la liste,  <strong>“Tail”</strong>

### Avantages
- Fléxibilité dans la taille
- Ajout et suppression efficaces
- Utilisation efficace de la mémoire

### Inconvenients 
- Accès sequentiel
- Surcharge mémoire
- manipulation comlplexe
   
### Ajout et retrait d'un élément

On a les trois pointeurs suivants :  <code>*head</code>,  <code>*tail</code>  et  <code>*tmp</code> 

- Ajout en debut de la liste : On demande à <code>*tmp</code> de pointer au même endroit que <code>*head</code>. Ensuite <code>*head</code>  de pointer vers le nouvel élément et ce dernier de pointer au même endroit que  <code>*tmp</code>.
<img src="https://i.ibb.co/GR8jYbB/List-add-first.png" alt="enter image description here">

- Ajout en fin de liste : On fait pointer <code>*tail</code> vers le nouvel élément et ce dernier vers la valeur <code>NULL</code>.
<img src="https://i.ibb.co/gwKxpT9/List-add-end.png" alt="enter image description here">

- Suppression en début de liste : on fait pointer <code>*head</code> vers l’élément juste après.
<img src="https://i.ibb.co/wgbFWNs/List-remove-first.png" alt="enter image description here">

- Suppression en fin de liste : comme on n’a pas de pointeur sur l’avant-dernier élément, on va devoir parcourir la liste séquentiellement jusqu’à ce que le prochain élément soit <code>NULL</code>. Ainsi on peut sélectionner l’avant-dernier élément et le faire pointer sur <code>NULL</code>.
<img src="https://i.ibb.co/p3DDN1s/List-remove-end.png" alt="enter image description here">



## 7) Listes doublement chaînées

### Principe 
Lorsque chaque élément d’une liste pointe à la fois vers l’élément suivant et précédent, nous parlons alors de liste doublement chainée.
<p><img src="https://i.ibb.co/jfpvsHY/Double-linked-list.png" alt="enter image description here"></p>

### Avantages :
- Parcours bidirectionnel
- Suppression efficace
- flexibilité accrue

### Inconvénients :
- Surchage memoire

## 8) Listes circulaires chaînées 

### Principe 
Une liste circulaire simplement chainée est une liste où:
- le dernier noeud pointe vers le premier, formant un cycle.
- le parcours peut se faire de manière continue sans atteindre NULL.
<p><img src="https://i.ibb.co/TTnkpK6/Circular-linked-list.png" alt="enter image description here"></p>

### Avantages :
- Pas de fin explicite
- Insertion rapide
- Optimisation mémoire
  
### Inconvénients :
- Complexité de gestion
- Parcours infini
- Difficulté à identifier le début


## 8) Matrices éparses (Sparse Tables) 

### Problème 
une matrice éparse est une matrice dans laquelle la majorité des éléments sont des zeros ou des valeurs neutres, cela gaspille de la mémoire et rend les opérations inefficaces.

### Solution 
L'idée principale est de stocker uniquement les éléments non nuls et leurs indices dans une structure appropriée.
- listes de triplets : (ligne, colonne, valeur)
- Dictionnaire : (ligne, colonne)

### Avantages 
- Reduction significative de l'utilisation mémoire
- optimisation des opérations sur les valeus pertinentes

### inconvenients
- Complexité de mise en oeuvre pour certaines méthodes
- Accès direct moins intuitif comparé à une matrice dense
  



<h1 id="stack-and-queue">8. Stack and Queue</h1>
<p><strong>Principe :</strong> Variante des listes chainées où l’on ne peut ajouter des nouveaux éléments seulement en début ou en fin. Ils possèdent la même structure avec un pointeur vers l’élément suivant dont le dernier pointe vers <code>NULL</code>.</p>
<ul>
<li>
<p><strong>Piles (Stack) :</strong> <code>Last In First Out</code>.<br>
<img src="https://i.ibb.co/SRpYDKk/Piles.png" alt="enter image description here"><br>
<strong>Implementation :</strong><br>
<strong>Vecteur :</strong> Pour utiliser le vecteur, il faudra prévoir une case pour mémoriser l’indice de la dernière valeur de la pile. La taille de la pile doit être connue lors de la création et est donc fixe.<br>
<strong>Liste :</strong> Une liste simplement chainée dans laquelle on va ajouter/retirer en début de liste. Aucun parcours de la liste n’est nécessaire.</p>
</li>
<li>
<p><strong>Files (Queue) :</strong> <code>First In First Out</code>.<br>
<img src="https://i.ibb.co/vHYdBc4/Files.png" alt="enter image description here"><br>
<strong>Implementation :</strong><br>
<strong>Vecteur :</strong> Le vecteur doit être circulaire. Grâce aux pointeurs <code>last</code> et <code>first</code> on va pouvoir ajouter en fin et retirer en début.  La taille doit être connue lors de la création et est donc fixe.<br>
<img src="https://i.ibb.co/xfBTjyG/Implem-Vectoriel-File.png" alt="enter image description here"><br>
<strong>Liste :</strong> Une liste simplement chainée dans laquelle on va pouvoir ajouter en fin et enlever en début de liste.</p>
</li>
</ul>
<h1 id="binary-search-trees-1">9. Binary Search Trees (1)</h1>
<p><strong>Principe :</strong> Lorsqu’on construit un arbre binaire on le fait de manière à ce qu’il soit trié, sinon aucun intérêt. On insère les éléments dans l’arbre dans l’ordre dans lequel ils arrivent et lorsque la case n’est pas libre, si on est plus petit que la case on place l’élément à gauche et inversement à droite. Chaque élément a un pointeur vers ses enfants de gauche et droite. Le pointeur est <code>NULL</code> s’il n’a pas d’enfant.</p>
<p><img src="https://i.ibb.co/BKF6Ny6/Binary-Search-Tree.png" alt="enter image description here"></p>
<p><strong>Insertion d’un élément :</strong>  Comme expliqué dans le principe de fonctionnement, lorsqu’on insère un nouvel élément on vient le placer tel que si la racine est occupée, il ira à droite si &gt; root ou à gauche si &lt; root. Et si la racine est libre il prendra tout simplement sa place.</p>
<p><strong>Supression d’un élément :</strong>  Nous avons 3 situations :</p>
<ul>
<li>En bout d’arbre c’est assez facile, il suffit de modifier le pointeur du parent du dernier noeud pour pointer vers  <code>NULL</code>.<br>
<img src="https://i.ibb.co/Ycz44zP/Delete-Node.png" alt="enter image description here"></li>
<li>Si on veut effacer un noeud qui possède un seul enfant, il faudra relier cet <em>“orphelin”</em> au parent du noeud et puis supprimer ce noeud en faisant pointer son parent vers <code>NULL</code>.<br>
<img src="https://i.ibb.co/B2g5ycQ/Delete-Node-one-child.png" alt="enter image description here"></li>
<li>Si on veut effacer un noeud possédant 2 enfants, il faut dans un premier temps créer un pointeur temporaire <code>tmp</code> sur l’enfant de gauche. Ce pointeur va ensuite voyager jusqu’à pointer la valeur la plus à droite de cet enfant. On peut ensuite accrocher l’enfant de droite du noeud au pointeur <code>tmp</code> puisque les éléments à droite sont toujours plus grands que ceux à gauche. Une fois l’enfant de droite <em>“adopté”</em> on peut raccorder l’enfant de gauche au parent du noeud à supprimer. Et terminer par supprimer le noeud en faisant pointer son parent vers <code>NULL</code>.<br>
<img src="https://i.ibb.co/Db9ydSv/Delete-Node-two-children.png" alt="enter image description here"></li>
</ul>
<p><strong>Mode de parcours :</strong> On parle de parcours infixe ou encore LVR (Left Visit Right). Chaque case de l’arbre possède une sorte de sets d’action à exécuter: <code>LVR</code>. Lorsqu’on parcourt l’arbre, on commence par la racine qui a un pointeur. Prenons l’exemple suivant :</p>
<p><img src="https://i.ibb.co/fVRcGMJ/LVR.png" alt="enter image description here"></p>
<ol>
<li>On commence par l’action  <code>LEFT</code>  de la racine qui consiste à pointer l’enfant à gauche. On descend dans l’arbre en exécutant le  <code>LEFT</code>  de chaque enfant jusqu’à ce qu’on ne puisse plus aller à gauche.</li>
<li>Pour ce dernier élément le  <code>LEFT</code>  a été exécuté on peut passer à son action  <code>VISIT</code>  qui consiste à consulter la valeur de la case.</li>
<li>Ensuite on passe à l’action  <code>RIGHT</code>  consistant à pointer un enfant à droite, s’il y en a bien sûr.</li>
</ol>
<p>Une fois les trois actions  <code>LVR</code>  exécuté pour l’élément le plus de l’arbre on passe à l’élément qui le précède. On peut directement passer à l’action  <code>VISIT</code>  puisque celui-ci à déjà utilisé son  <code>LEFT</code>. Il exécutera ensuite son  <code>RIGHT</code>  pour descendre dans ses enfants. Ces derniers exécuteront leur  <code>LVR</code>  jusqu’a remonter chez son parent.</p>
<p>On remonte ainsi jusqu’à la racine qui une fois “visité” passera à son  <code>RIGHT</code>  pour à son tour faire exécuter les  <code>LVR</code>  de tous ses enfants de droite.</p>
<h1 id="binary-search-trees-2">10. Binary Search Trees (2)</h1>
<p><strong>Manipulation par rotation :</strong></p>
<ul>
<li>On peut effectuer des rotations à droite, de manière à ce que le parent (avec son enfant de droite  <code>R</code>) vienne s’accrocher à la droite de son enfant de gauche en  <code>Q</code>  sur la figure (a). Ainsi l’enfant de gauche peut prendre la place du père. Cette manière de procéder permet de garder un arbre trié.<br>
<img src="https://i.ibb.co/bKCFTDH/Rotation-droite.png" alt="enter image description here"></li>
<li>On peut effectuer des rotations à gauche en faisant l’opposé des actions décrites plus haut.</li>
</ul>
<p><strong>Déséquilibrage :</strong></p>
<ul>
<li><strong>Problème :</strong>  Lorsqu’on manipule l’arbre en y insérant/supprimant des éléments on peut introduire un déséquilibre dû au nombre de noeuds différent à gauche et à droite d’un parent.<br>
<img src="https://i.ibb.co/VDpmv1D/D-s-quilibre.png" alt="enter image description here"></li>
<li><strong>Solutions :</strong>  Il existe différentes méthodes d’équilibrage à base de rotation comme les arbres  <a href="#11-avl-trees">AVL</a></li>
</ul>
<h1 id="avl-trees">11. AVL Trees</h1>
<p><strong>Principe :</strong> c’est un algorithme qui permet de rendre un arbre équilibré en associant aux différents noeuds (en plus des valeurs) des niveaux de désiquilibrede l’arbre. <code>+n</code> et <code>-n</code> lors d’un déséquilibre respectivement à droite et à gauche ou encore <code>0</code> lorsque le noeud est équilibré. À partir d’un déséquilibre de <code>+2</code>ou <code>-2</code>, l’arbre va effectuer une rotation classique afin de rééquilibrer.</p>
<p><img src="https://i.ibb.co/JBm55Gq/AVL-Trees.png" alt="enter image description here"></p>
<p><strong>Utilité :</strong> Permet de réaliser des insertions, suppressions et recherche de complexité logarithmique O(log(n)). AVL assure un équilibrage de maximum 2 niveaux.</p>
<h1 id="data-compression">12. Data compression</h1>
<h2 id="run-length-encoding">12.1 Run-length Encoding</h2>
<p>Lorsque l’on code par plage, on va essayer de noter plusieurs caractères qui se suivent d’une manière différente.</p>
<ul>
<li>En comptant le nombre de répétitions d’un caractère, un message composé uniquement de lettre  <code>AAAABBAAACCCCCB</code>  devient  <code>4A2B3A5CB</code>. On constate un gain de place évident.</li>
<li>Si le message contient des caractères alphanumériques, on vient placer un caractère d’échappement (Escape)  <code>Z</code>  devant un chiffre pour signifier qu’il indique le nombre d’apparitions de la lettre juste à côte. Le message  <code>4AAAA5BBB</code>  devient  <code>4</code><em>Z4</em><code>A5BBB</code>. On constate avec cette méthode que si une lettre se répète moins de 3 fois, on va préférer garder la répétition.  <code>BBB</code>  n’a aucun intérêt à devenir  <code>Z3B</code>.</li>
</ul>
<h2 id="variable-length-code">12.2 Variable-length Code</h2>
<p>On va coder des caractères très fréquents sur moins de bits que des caractères plus rares. En prenant le cas du français on codera la lettre <code>E</code> sur 4 bits car très susceptible d’apparaitre et la lettre <code>Z</code> sur 13 bits, car beaucoup moins susceptible d’apparaître. On optimise ainsi l’espace.</p>
<h1 id="absract-data-type-adt">13. Absract Data Type (ADT)</h1>
<p><strong>Définition :</strong>  L’objectif d’un type abstrait de données (TAD, ou ADT en anglais) est de cacher les détails d’implémentation de la structure de données, tout en modélisant le monde réel. Les changements d’implémentation de TAD doivent être indépendants du reste du programme, et celui-ci est autodocumenté. Les opérations réalisables avec chaque TAD sont définies dans son interface. Les noms de TAD sont représentatifs de leurs fonctionnalités ; Nous en avons déjà rencontré quelques-uns : par exemple la pile et la file qui peuvent s’implémenter de différentes façons.</p>
<p><strong>Exemples de TAD :</strong><br>
<strong>1. Deque :</strong>  Est une  <code>file</code>  à deux bouts, une séquence d’éléments à laquelle on peut ajouter et enlever aux deux extrémités. Son interface propose au minimum les méthodes suivantes :</p>
<ul>
<li>IsEmpty()</li>
<li>insertFirst(element)</li>
<li>insertLast(element)</li>
<li>removeFirst()</li>
<li>removeLast()<br>
L’implémentation peut se faire avec une liste simplement ou doublement chaînée avec pointeur de fin de liste.</li>
</ul>
<p><strong>2. Dictionnaire :</strong>  Permet le stockage de paires clé-valeur, mais une clé peut être associée à plusieurs valeurs. Son interface propose au minimum les méthodes suivantes :</p>
<ul>
<li>Size() : nbr de paires clé-valeur</li>
<li>isEmpty() pas une seule clé-valeur</li>
<li>find(k) renvoie une valeur associée à la clé k (null si k n’existe pas dans le dictionnaire)</li>
<li>findAll(k) renvoie un itérateur sur les valeurs associées à la clé k (null si k n’existe pas dans le dictionnaire)</li>
<li>insert(k,v) ajoute la paire clé-valeur (k,v)</li>
<li>remove(k,v) supprime la clé-valeur</li>
<li>entries() est un itérateur sur les paires clé-valeurs<br>
L’implémentation peut se faire avec une liste chaînée ordonnée ou non ou une liste à saut (skipList).</li>
</ul>
<h1 id="error-detecting-codes">14. Error-Detecting Codes</h1>
<p><strong>Principe :</strong>  Afin de garantir la fiabilité des informations lors d’une transmission de données, on y introduit suffisamment de redondance par un codage de correction.</p>
<p>Le cas le plus simple est l’utilisation d’un bit de parité. On ajoute pour chaque bloc de n bits un bit qui est la somme (sans report) des bits du bloc (1+1=0). Ce système permet de détecter si un  <code>nombre impair</code>  de bit est  <code>incorrect</code>  dans le bloc. En cas de nombre pair d’erreurs, le bit de parité sera correct. Ce système consiste donc à ajouter au bloc de bits à transmettre le modulo 2 (0 ou 1) de ce bloc.</p>
<p><strong>Améliorer le nombre de détections :</strong>  Si l’on consacre 2 bits à la détection d’erreur, on peut utiliser un modulo 4 (0, 1, 2 ou 3 càd en binaire 00, 01, 10 ou 11). Si au décodage, le modulo 4 est correct, cela signifie qu’il y a 0, 4, 8… erreurs de transmission. Le 0 étant le plus probable surtout si le bloc transmis est de petite taille.</p>
<p><strong>En cas de détection :</strong>  On peut constater que cette technique permet de détecter des erreurs, mais pas de les corriger. Si le code détecteur est assez développé il peut corriger l’erreur comme le  <code>codage de Hamming</code>. Autrement une solution plus simple consiste à demander de renvoyer le message.</p>
<h1 id="raid-arrays">15. RAID</h1>
<p>Le principe du RAID (<i>Redundant Array of Independant Disks</i>) est de grouper plusieurs disques durs physiques pour qu'ils soient traités comme un seul.</p>
<p>On distingue 7 types de RAID différents, numérotés de RAID 0 à RAID 6.</p>
<ul>
  <li>RAID 0 : Utilise au moins deux disques. Il permet d'augmenter la capacité et les vitesses de transfert en répartissant l'information sur les disques. Ce RAID ne permet pas de redondance, il suffit qu'un seul disque tombe en panne pour perdre l'entièreté des données.</li>
  <li>RAID 1 : Clone l'information sur ses disques, ne permet pas de gain de performance mais permet la redondance (pour n disques, on a droit jusqu'à n-1 disques défectueux).</li>
  <li>RAID 2 : N'est plus utilisé aujourd'hui, il reprenait le principe du RAID 0 en ajoutant un disque dur contenant des codes de contrôle d'erreur calculés par Hamming.</li>
  <li>RAID 3 & 4 : Semblables au RAID2, ils utilisent un disque pour vérifier la parité des données. La différence entre les deux est respectivement la découpe des données en octets, ou en blocs.</li>
  <li>RAID 5 : Se base aussi sur un disque de parité. La différence avec le RAID 3/4 est la capacité à reconstruire le contenu d'un disque en panne.</li>
  <li>RAID 6 : Évolution du RAID 5 utilisant plus d'un disque de redondance. Cependant, les calculs des informations de redondance étant plus compliqués, on se limite en général à 2 disques de parité.</li>
</ul>
<p>On peut très bien imbriquer un RAID dans un autre. Par exemple, un RAID 0+1 sera un RAID 1 de deux volumes en RAID 0.</p>
<p>La gestion d'un RAID peut soit être effectuée logiciellement (l'OS se chagre des calculs et du transfert des données), pseudo-matériellement (contrôleur de stockage avec des fonctionnalités avancées) ou matériellement (composant dédié aux calculs et aux transferts).</p>
<h1 id="bibliography">Bibliography</h1>
<p>A. LORGE, <em>3BE Structures de données</em>, 2021<br>
A. LORGE, <a href="https://teams.microsoft.com/_#/school/files/General?threadId=19%3Adad3058aa849416991b553df80365ed6%40thread.tacv2&amp;ctx=channel&amp;context=Recordings&amp;rootfolder=%252Fsites%252F3BEPG3L-L1Projetcopier%252FDocuments%2520partages%252FGeneral%252FRecordings">Teams-Recordings</a>, 2021</p>
