Algoritmo ProgramaMejorado_v2
	Escribir "Quieres empezar? "Sin Saltar
	Leer otraVez
	Mientras otraVez=="si"		
		Escribir 'Introduce un número: 'Sin Saltar
		Leer num
		Escribir num , ' es ' Sin Saltar
		Si num<0 Entonces
			Escribir 'negativo.'
		SiNo
			Si num==0 Entonces
				Escribir 'cero.'
			SiNo
				Escribir 'positivo.'
			FinSi
		FinSi	
		Escribir "Quieres volver a empezar? "Sin Saltar
		Leer otraVez
	FinMientras
FinAlgoritmo

	