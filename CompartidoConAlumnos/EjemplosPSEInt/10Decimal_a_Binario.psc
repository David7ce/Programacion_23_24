Algoritmo Decimal_a_Binario
	Escribir "Numero: "Sin Saltar
	Leer numero
	cociente <- numero
	binario <- ""
	Repetir
		resto <- cociente % 2
		cociente <- trunc(cociente/2)
		binario <- ConvertirATexto(resto) + binario
		//binario <- Concatenar(ConvertirATexto(resto),binario)
	Hasta Que cociente==0
	Escribir numero, " en binario es ", binario
FinAlgoritmo
