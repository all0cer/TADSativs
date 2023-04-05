.text 

main:
     add $2, $0, 12
     syscall
     
     sub $8, $2, 32
     add $4, $0, $8
     add $2, $0, 11
     syscall
