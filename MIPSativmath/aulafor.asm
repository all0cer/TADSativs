.text

main: addi $8, $0, 0 #i=0
      addi $9, $0, 5 #i<n onde n= qtd colocada no registrador 9
      addi $10, $0, 0 #soma os algarismos na entrada
      
test: beq $8, $9, saida #enquanto $8 e $9 forem diferentes:
      addi $2, $0, 5 # ler um numero
      syscall		
      add $10, $10, $2 #colocar o numero lido no reg 10 e somar o próximo também no reg 10
    
      addi $8, $8, 1 #somar 1 a cada vez que rodar o laço
                     # i++;
      j test         #retorna para o rotulo do laço


saida: add $4, $10, 10 # mostrar a soma dos numeros do input
       addi $2, $0, 1
       syscall
       
       addi $2, $0, 10 #finalizar programa
       syscall
