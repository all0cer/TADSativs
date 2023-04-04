.text

main: add $2, $0, 5
      syscall
      add $8, $0, $2
      add $2, $0, 5
      syscall
      add $9, $0, $2
      
soma: add $10, $9, $8
      add $11, $0, 2
      div $10, $11
      mflo $4
      add $2, $0, 1
      syscall
      
terminar: add $2, $0, 10
	  syscall
