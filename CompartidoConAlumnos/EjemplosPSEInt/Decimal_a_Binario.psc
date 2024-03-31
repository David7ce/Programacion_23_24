Algoritmo Decimal_a_Binario
	binario <- ""
	Escribir "Numero decimal: "Sin Saltar
	leer numero
	peso <- 128
	Mientras (numero > peso*2-1)
		peso <- peso * 2
	FinMientras
	Repetir
		Si numero >= peso Entonces
			binario <- binario + "1"
			numero <- numero - peso
		SiNo
			binario <- binario + "0"
		FinSi
		peso <- trunc(peso / 2)
	Hasta Que peso == 0
	Escribir binario
FinAlgoritmo
