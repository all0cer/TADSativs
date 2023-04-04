.text

main: add $2, $0, 5
      syscall
      add $8, $0, $2
      
      
soma: sll $10, $8, 1
      add $4, $0, $10
      add $2, $0, 1
      syscall 

terminar: add $2, $0, 10
	  syscall
