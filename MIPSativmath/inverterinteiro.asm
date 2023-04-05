.text 

main:
     add $2, $0, 5
     syscall
     
     
     add $15, $0, 100
     div $2, $15
     mflo $8 #centena
     mfhi $12 #dezena e unidade
     add $15, $0, 10
     div $12, $15
     mflo $10
     mfhi $11
     
     
     add $4, $0, $11 #unidade
     add $2, $0, 1
     syscall
     add $4, $0, $10 #dezena
     add $2, $0, 1
     syscall
     add $4, $0, $8 #centena
     add $2, $0, 1
     syscall
     
     add $2, $0, 10
     syscall
