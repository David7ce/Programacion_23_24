Algoritmo Cambio_2
	Escribir "Inserte su n�mero: "
	Leer numero
	dosCifras <- numero % 100 
	numBase <- Numero - dosCifras
	unidades <- dosCifras % 10
	decenas = trunc(dosCifras / 10)
	numeroFinal = numBase + unidades*10 + decenas
	Escribir numeroFinal
FinAlgoritmo