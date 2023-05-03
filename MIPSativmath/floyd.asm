.text

main: addi $2, $0, 5 #recebe inteiro
      syscall
      beq $2, $0, fim #caso receba valor nulo
      
valor: add $19, $2, $0 # receber valor do $2
      
contadores:     addi $20, $0, 1 #linha
		addi $18, $0, 1 #linha
		
      

for0: addi $21, $0, 0 #zerar  
  
for1: beq $20, $21, quebra
      add  $4, $18, $0
      addi $2, $0, 1
      syscall #exibir numero
        
      addi $4, $0, ' '
      addi $2, $0, 11
      syscall #imprimir espaço para o numero
      
      addi $21, $21, 1 # contador++
      
      
      beq $21, $19, fim
      j for1


quebra: add $4, $0, '\n'
	addi $2, $0, 11
	syscall
	addi $20, $20, 1 #somar para imprimir x valores na linha
	addi $18, $18, 1
	j for0
	
fim: addi $2, $0, 10
     syscall
	 
