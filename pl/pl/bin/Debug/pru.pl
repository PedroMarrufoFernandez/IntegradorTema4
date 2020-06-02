medicinade(veterinario,rabia).
medicinade(vitaminab,moquillo).
medicinade(metoclopramida,parvovirus).
medicinade(ninguno,edad).
medicinade(antibiotico,infeccion).
medicinade(antibiotico,bacterias).
medicinade(resguardo,clima).

sintomade(decaido,moquillo).
sintomade(espasmos,moquillo).

sintomade(esessangre,parvovirus).
sintomade(diarrea,parvovirus).

sintomade(duerme,edad).
sintomade(comemal,edad).

sintomade(diarrea,infeccion).
sintomade(temperatura,infeccion).

sintomade(caidapel,bacterias).

sintomade(tos,clima).

sintomade(espuma,rabia).

cargar(A):-exists_file(A),consult(A).
recetade(M,S):-sintomade(S,M).
tratamiento(P,T):-sintomade(S,Z),medicinade(N,Z).

