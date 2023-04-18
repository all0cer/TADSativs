.text


main: addi $2, $0, 5
      syscall
      
      
      addi $8, $0, 100000000
      div $2, $8
      mflo $9 #digito 1 
      mfhi $26 #resto 1
      add $27, $0, $26
      
      addi $8, $0, 10000000
      div $26, $8
      mflo $10 #digito 2
      mfhi $26 #resto 2
      
      addi $8, $0, 1000000
      div $26, $8 
      mflo $11 #digito 3
      mfhi $26 #resto 3
      
      addi $8, $0, 100000
      div $26, $8 
      mflo $12 #digito 4
      mfhi $26 #resto 4
      
      addi $8, $0, 10000
      div $26, $8 
      mflo $13 #digito 5
      mfhi $26 #resto 5
      
      addi $8, $0, 1000
      div $26, $8 
      mflo $14 #digito 6
      mfhi $26 #resto 6
      
      addi $8, $0, 100
      div $26, $8 
      mflo $15 #digito 7
      mfhi $26 #resto 7
      
      addi $8, $0, 10
      div $26, $8 
      mflo $16 #digito 8
      mfhi $26 #resto = 9 digito
      


times: addi $17, $0, 10
       mul $9, $9, $17
       
       addi $17, $0, 9
       mul $10, $10, $17
       
       addi $17, $0, 8
       mul $11, $11, $17
       
       addi $17, $0, 7
       mul $12, $12, $17
       
       addi $17, $0, 6
       mul $13, $13, $17
       
       addi $17, $0, 5
       mul $14, $14, $17
       
       addi $17, $0, 4
       mul $15, $15, $17
       
       addi $17, $0, 3
       mul $16, $16, $17
       
       addi $17, $0, 2
       mul $26, $26, $17
       
       
       



somas: add $18, $9, $10
       add $18, $18, $11
       add $18, $18, $12 
       add $18, $18, $13 
       add $18, $18, $14 
       add $18, $18, $15 
       add $18, $18, $16 
       add $18, $18, $26
       
         
addi $19, $0, 11 #valor para divisao e subtracao


divi: div $18, $19
      mfhi $20
      
      addi $21, $0, 1
      beq $20, $0, normal #digito 0
      beq $20, $21, normal #digito 1
      j subtrai11 #caso nao seja 0 ou 1 vai subtrair com o resto
      
        
normal: add $22, $0, $0 # 1 digito de J
	j segundadivisao
subtrai11: sub $22, $19, $20 # 1 digito de J






segundadivisao: 
      addi $8, $0, 100000000
      div $27, $8
      mflo $10 #digito 2
      mfhi $27 #resto 2
      
      
      addi $8, $0, 10000000
      div $27, $8 
      mflo $11 #digito 3
      mfhi $27 #resto 3
      
      addi $8, $0, 1000000
      div $27, $8 
      mflo $12 #digito 4
      mfhi $27 #resto 4
      
      addi $8, $0, 100000
      div $27, $8 
      mflo $13 #digito 5
      mfhi $27 #resto 5
      
      addi $8, $0, 1000
      div $27, $8 
      mflo $14 #digito 6
      mfhi $27 #resto 6
      
      addi $8, $0, 100
      div $27, $8 
      mflo $15 #digito 7
      mfhi $27 #resto 7
      
      addi $8, $0, 10
      div $27, $8 
      mflo $16 #digito 8
      mfhi $27 #resto = 9 digito


timessegundavez: 
       addi $17, $0, 10
       mul $10, $10, $17
       
       addi $17, $0, 9
       mul $11, $11, $17
       
       addi $17, $0, 8
       mul $12, $12, $17
       
       addi $17, $0, 7
       mul $13, $13, $17
       
       addi $17, $0, 6
       mul $14, $14, $17
       
       addi $17, $0, 5
       mul $15, $15, $17
       
       addi $17, $0, 4
       mul $16, $16, $17
       
       addi $17, $0, 3
       mul $26, $26, $17
       
       addi $17, $0, 2
       mul $23, $22, $17


somosegundavez:
       add $18, $10, $11
       add $18, $18, $12
       add $18, $18, $13 
       add $18, $18, $14 
       add $18, $18, $15 
       add $18, $18, $16 
       add $18, $18, $17
       add $18, $18, $26
       
       
dividesegunda:
            div $18, $19
            mfhi $24 #resto da divisao para segundo numero
            
            beq $24, $21, segundanormal #digito 1
      	    beq $24, $0, segundanormal #digito 0
            j subtraisegunda #caso nao seja 0 ou 1 vai subtrair com o resto


segundanormal: addi $25, $0, 0 # 1 digito de B
		j mostrarnumeros
subtraisegunda: sub $25, $19, $24 # 1 digito de B



mostrarnumeros: add $4, $0, $22
		add $2, $0, 1
		syscall
		
		add $4, $0, $25
		add $2, $0, 1
		syscall
		
fim:
		add $2, $0, 10
		syscall
