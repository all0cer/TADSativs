.text

main: add $2, $0, 5
      syscall
      add $8, $0, $2

         
centena: add $6, $0, 100
	div $8, $6
	mflo $10
	

	
unidade: add $7, $0, 10
         div $8, $7
	 mfhi $11 	#unidade
dezena:	 mflo $9
	 div  $9, $7
	 mfhi $9
	 

	 
	 
soma: add $12, $10, $11
      add $13, $12, $9

mostrar: add $4, $0, $13
         add $2, $0, 1
         syscall
         
encerrar: add $2, $0, 10
          syscall
