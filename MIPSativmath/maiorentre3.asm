.text 

main: add $2, $0, 5
      syscall
      add $8, $0, $2
      add $2, $0, 5
      syscall
      add $9, $0, $2   
      add $2, $0, 5
      syscall
      add $10, $0, $2
      
      sub $11, $8, $9
      
      #se 8 > 9, será positivo
      
      add $12, $0, $11
      not $12, $12
      
      srl $11, $11, 31
      srl $12, $12, 31
      
      
      mul $13, $11, $9
      mul $14, $12, $8
      add $15, $14, $13
      
      sub $16, $15, $10
      add $17, $0, $16
      not $17, $17
      
      srl $16, $16, 31
      srl $17, $17, 31
      
      
      mul $18, $16, $10
      mul $19, $17, $15
      add $4, $18, $19
      add $2, $0, 1
      syscall
       
      add $2, $0, 10
      syscall
