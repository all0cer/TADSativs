.text

main: add $2, $0, 5
      syscall
      add $8, $0, $2
      add $2, $0, 5
      syscall
      add $9, $0, $2
      sub $10, $8, $9 #subtrai os numeros da entrada
      
      add $11, $10, 0 #pegar a subtração
      not $11, $11 #inverter valor (negativo ou positivo)
      
      srl $10, $10, 31 #bit mais significativo (1 ou 0)
      srl $11, $11, 31
      
      mul $12, $10, $9 #multiplicar por 1 se 
      mul $13, $11, $8
      add $4, $12, $13
      add $2, $0, 1
      syscall
      
      
      
      	
