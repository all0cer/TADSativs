.text
#Escreva um código que leia um número decimal de 0 até 99000 e transforme-o em um sistema de base 11
main:   addi $2, $0, 5
        syscall
        add $8, $0, $2
        addi $9, $0, 12

decompondo: div $8, $9
            mfhi $10          #bit 1 -> $10
            mflo $8

           div $8, $9
           mfhi $11      #bit 2 -> $11
           mflo $8   
           
           div $8, $9
           mfhi $12           #bit 3 -> $12
           mflo $13  
           
                  #bit 5 -> $14     
           
           


           addi $25, $0, 10   #adição para verificação  com A
           addi $26, $0, 11   #adição para verificação  com B
           addi $27, $0, 12   #adição para verificação  com C
           
           
           
######################
impressao0:     beq $25, $13, imprimirA3    
		beq $26, $13, imprimirB3
		beq $27, $13, imprimirC3
                j impressaonormal0

imprimirA0:  addi $4, $0, 'A'
             addi $2, $0, 11
             syscall
             j impressao1
             
imprimirB0:  addi $4, $0, 'B'
             addi $2, $0, 11
             syscall
             j impressao1
             
imprimirC0:  addi $4, $0, 'C'
             addi $2, $0, 11
             syscall
             j impressao1

impressaonormal0:
         add $4, $0, $13
         addi $2, $0, 1
         syscall           
 
######################
impressao1:     beq $25, $12, imprimirA1    #se $9 for = 10, então vai imprimir A
		beq $26, $12, imprimirB1
		beq $27, $12, imprimirC1
		
                j impressaonormal    #
 

imprimirA1:  addi $4, $0, 'A'    #imprime A
            addi $2, $0, 11
            syscall
            j impressao2        #salta para próxima impressão

imprimirB1:  addi $4, $0, 'B'    #imprime B
            addi $2, $0, 11
            syscall
            j impressao2        #salta para próxima impressão
            
imprimirC1:  addi $4, $0, 'C'    #imprime C
            addi $2, $0, 11
            syscall
            j impressao2        #salta para próxima impressão
impressaonormal:add $4, $0, $12
        addi $2, $0, 1
        syscall




impressao2:     beq $25, $11, imprimirA2    #se $9 for = 10, então vai imprimir A
		beq $26, $11, imprimirB2
		beq $27, $11, imprimirC2
                j impressaonormal2

imprimirA2:      
            addi $4, $0, 'A'
            addi $2, $0, 11
            syscall
            j impressao3
            
imprimirB2:  addi $4, $0, 'B'    #imprime B
            addi $2, $0, 11
            syscall
            j impressao3       #salta para próxima impressão
            
imprimirC2:  addi $4, $0, 'C'    #imprime C
            addi $2, $0, 11
            syscall
            j impressao3       #salta para próxima impressão
            
impressaonormal2:
         add $4, $0, $11
         addi $2, $0, 1
         syscall



impressao3:     beq $25, $10, imprimirA3    
		beq $26, $10, imprimirB3
		beq $27, $10, imprimirC3
                j impressaonormal3

imprimirA3:  addi $4, $0, 'A'
             addi $2, $0, 11
             syscall
             j fim
             
imprimirB3:  addi $4, $0, 'B'
             addi $2, $0, 11
             syscall
             j fim
             
imprimirC3:  addi $4, $0, 'C'
             addi $2, $0, 11
             syscall
             j fim

impressaonormal3:
         add $4, $0, $10
         addi $2, $0, 1
         syscall
         
         
##########



fim:        addi $2, $0, 10
        syscall
