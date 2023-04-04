.text

main: add $2, $0, 5
      syscall
      add $8, $0, $2
      
      
soma: mult $8, $8
      mflo $10	
      add $4, $0, $10
      add $2, $0, 1
      syscall 

terminar: add $2, $0, 10
	  syscall
