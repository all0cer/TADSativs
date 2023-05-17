.data
#0x10010000
.word 0,0,0,0,0,0

.text
main: addi $8, $0, 0
      addi $9, $0, 6
      lui $25, 0x1001
      
      
for1: beq $8, $9, reinicia
      add $2, $0, 5
      syscall
      sw $2, 0($25)
      
      addi $25, $25, 4
      addi $8, $8, 1
      j for1
      
      
reinicia:   add $8, $0, $0
            lui $25, 0x1001 #REINICIALIZAR ENDEREÇO DE MEMORIA
     
     
     
exibir: beq $8, $9, terminar
     add $4, $0, 10 #QUEBRA DE LINHA
     add $2, $0, 11#
     syscall#  
     
      lw $4, 0($25)
      addi $2, $0, 1
      syscall 	
      
      addi $25, $25, 4
      addi $8, $8, 1
      j exibir
      
terminar:
	addi $2, $0, 10
	syscall
