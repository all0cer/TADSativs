.text 

main: add $2, $0, 5
      syscall
      add $8, $0, $2 #A
      add $2, $0, 5
      syscall
      add $9, $0, $2    #B
      add $2, $0, 5
      syscall
      add $10, $0, $2 #C
      add $26, $0, 1 #comparacao
      
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
      
      
      mul $19, $16, $10
      mul $23, $17, $15 #Maior entre os 3 $19
       
       
      beq $23, $8, BC  #A é o maior
      beq $23, $9, AC #B é o maior
      beq $23, $10, AB #C é o maior
      
      beq $19, $8, BC  #A é o maior
      beq $19, $9, AC #B é o maior
      beq $19, $10, AB #C é o maior
      
BC:
      slt $20, $9, $10
      beq $20, $26, BCA 
      j CBA
      
AC: 
    slt $20, $8, $10
    beq $20, $26, ACB
    j CAB
    
AB: 
    slt $20, $8, $9
    beq $20, $26, ABC
    j BAC
	
      
BCA:add $4, $0, $9
    add $2, $0, 1
    syscall
    add $4, $0, $10
    add $2, $0, 1
    syscall
    add $4, $0, $8
    add $2, $0, 1
    syscall
    j fim
    
CBA:add $4, $0, $10
    add $2, $0, 1
    syscall
    add $4, $0, $9
    add $2, $0, 1
    syscall
    add $4, $0, $8
    add $2, $0, 1
    syscall
    j fim
    
ACB:add $4, $0, $8
    add $2, $0, 1
    syscall
    add $4, $0, $10
    add $2, $0, 1
    syscall
    add $4, $0, $9
    add $2, $0, 1
    syscall
    j fim

CAB:add $4, $0, $10
    add $2, $0, 1
    syscall
    add $4, $0, $8
    add $2, $0, 1
    syscall
    add $4, $0, $9
    add $2, $0, 1
    syscall
    j fim

ABC:add $4, $0, $8
    add $2, $0, 1
    syscall
    add $4, $0, $9
    add $2, $0, 1
    syscall
    add $4, $0, $10
    add $2, $0, 1
    syscall
    j fim

BAC:add $4, $0, $9
    add $2, $0, 1
    syscall
    add $4, $0, $8
    add $2, $0, 1
    syscall
    add $4, $0, $10
    add $2, $0, 1
    syscall
    
fim: add $2, $0, 10
     syscall
    
      
      
      