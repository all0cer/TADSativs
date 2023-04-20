.text

main: add $2, $0, 5 #Introduz um inteiro
      syscall
      add $20, $0, $2 #adiciona o inteiro no reg 20
      
numForDiv: add $8, $0, 100 #para dividir por 100
           add $9, $0, 3 # para dividir por 3
           add $10, $0, 300 #para dividir por 300
           add $11, $0, 7 #para dividir por 7
           add $25, $0, 1 #para comprovar

divsbissexto:  div $20, $10 #divide por 300
               mfhi $12
               beq  $12, $0, bissexto
      
               div $20, $11 #divide por 7
               mfhi $12
               beq $12, $0, bissexto
               
               div $20, $9 #divide por 3
               mfhi $12
               div $20, $8 #divide por 100
               mfhi $13
               slt $21, $12, $13
               beq $21, $25, bissexto
               j naobissexto #caso nao entre em nenhum dos casos nao sera bissexto

bissexto: 
	add $4, $0, 83
	add $2, $0, 11
	syscall
	j fim
	
naobissexto:
	add $4, $0, 78
	add $2, $0, 11
	syscall

fim: add $2, $0, 10
     syscall
      
      
      
      
      