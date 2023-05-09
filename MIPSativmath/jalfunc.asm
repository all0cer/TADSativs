.text


main: addi $4, $0, 54
      addi $5, $0, 64
      addi $6, $0, 100
      jal func
      add $4, $2, $0
      addi $2, $0, 1
      syscall
      
      addi $2, $0, 10
      syscall
      
#########################################
#entradas: $4, $5, $6
#saída: $2
#reg utilizados      
func: add $2, $4, $5
      add $2, $2, $6
      jr $31
      
