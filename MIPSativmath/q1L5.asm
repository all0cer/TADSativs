.data
.word 1, 0 ,5, -2, -5, 7  #VALORES DO VETOR
.text



main: addi $8, $0, 0 #INDEX ATUAL DO VETOR
      addi $9, $0, 6 #LIMITE DO INDEX
      addi $10, $0, 1 #TESTE PARA POSICAO 1
      addi $11, $0, 5 #TESTE PARA POS 5
      add $12, $0, 4 #TESTE PARA POS 4
      add $13, $0, 100 # VALOR PARA ACRESCENTAR NO INDEX 4
      lui $25, 0x1001 #25 ARMAZENA ENDEREÇO 1001
      
      
      
for0: beq $8, $9, sai0 # SAIR DO LOOP NO LIMITE DO INDEX
      beq $8, $0, soma #SOMA O VALOR DO INDEX 0
      beq $8, $10, soma #SOMA VALOR DO INDEX 1
      beq $8, $11, soma # SOMA VALOR DO INDEX 5
      beq $8, $12, troca #SUBSTITUI VALOR DO INDEX 4
      
      
     
      addi $25, $25, 4 #PEGAR PROXIMO NUMERO INTEIRO
 
      addi $8, $8, 1 #PEGAR PROX INDEX
      j for0


troca:
	sw $13, 0($25) #ARMAZENA NO ENDEREÇO EM $25 O VALOR 100(NO REG 13)
	addi $25, $25, 4 #PROX VALOR INT
        addi $8, $8, 1 #PROX INDEX
        j for0
	
soma:

	lw $22, 0($25) #PEGA O VALOR DO ENDEREÇO DE MEMORIA QUE ESTA NO $25 E ARMAZENA EM $22
	add $4, $4, $22 #SOMA OS VALORES QUE ESTÃO NO $22 PARA O $4
	addi $25, $25, 4 #PROX VALOR INT
	addi $8, $8, 1 #PROX INDEX
	j for0

sai0:
    add $2, $0, 1 #IMPRIMI O VALOR DO $4 ( ATUALMENTE GUARDANDO A SOMA)
    syscall
    add $4, $0, $0
    add $8, $0, $0
    lui $25, 0x1001 #REINICIALIZAR ENDEREÇO DE MEMORIA
    
fo1: #MOSTRAR OS VALORES DO INDEX
     beq $8, $9, terminar # SAIR DO LOOP NO LIMITE DO INDEX
     add $4, $0, 10 #QUEBRA DE LINHA
     add $2, $0, 11#
     syscall#
     
     lw $4, 0($25) #PEGAR O VALOR NO ENDEREÇO DE $25
     add $2, $0, 1 #MOSTRAR O VALOR
     syscall
     
     addi $25, $25, 4 #PROX VALOR INT
     addi $8, $8, 1 #PROX INDEX
     
     j fo1 
     
     

terminar:
     add $2, $0, 10
     syscall
