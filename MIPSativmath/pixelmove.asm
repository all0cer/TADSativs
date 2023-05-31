.text

main: lui $8, 0x1001
      addi $9, $0, 512 #quantidade de vezes
      addi $10, $0, 0x0ff #cor escolhida
      
for: beq $9, $0, fim #quando preencher as cores sai
     sw $10, 0($8) #guarda no registrador 8 o valor da cor
     sw $10, 2048($8) #guarda um valor shadow
     
     addi $4, $0, 1000
     addi $5, $0, 0x00ffffff
     addi $2, $0, 42 
     syscall
     add $10, $4, $0
     
     
     addi $8, $8, 4 #vai para o proximo endereço de memória
     addi $9, $9, -1 #decrementa para sair do laço
     j for
     
fim:  add $20, $0, 0x00ffffff
      lui $21, 0x1001
      sw $20, 0($21)
      	
      addi $22, $0, 512
      
muve: beq $22, $0, sai2
      lw $23, 2048($21)#escreve a cor na memoria
      sw $23, 0($21) #armazena de volta a cor antiga
      add $21, $21, 4 #próximo endereço de memória (pixel)
      sw $20, 0($21) #pinta novamente o branco
      jal sleep	#funcao para dar delay      
      addi $22, $22, -1 
      j muve
      
sai2:    addi $2, $0, 10
     syscall
     
sleep: addi $15, $0, 20000
forsleep: beq $15, $0, fimsleep
          nop
          nop
          nop
          addi $15, $15, -1
          j forsleep
          
fimsleep: jr $31
