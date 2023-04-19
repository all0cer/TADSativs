.text

main:
    add $2, $0, 5
    syscall
    addi $8, $0, 2 #valor para divisão
    div $2, $8
    mfhi $10
    mflo $2
    div $2, $8
    mfhi $11
    mflo $2
    div $2, $8
    mfhi $12
    mflo $2
    div $2, $8
    mfhi $13
    mflo $2
    div $2, $8
    mfhi $14
    mflo $2
    div $2, $8
    mfhi $15
    mflo $2
    div $2, $8
    mfhi $16
    mflo $2
    div $2, $8
    mfhi $17
    mflo $2
    div $2, $8
    mfhi $18
    mflo $2
    div $2, $8
    mfhi $19
    mflo $2

mostrarnum:
       add $4, $0, $18
       add $2, $0, 1
       syscall
       add $4, $0, $17
       add $2, $0, 1
       syscall
       add $4, $0, $16
       add $2, $0, 1
       syscall
       add $4, $0, $15
       add $2, $0, 1
       syscall
       add $4, $0, $14
       add $2, $0, 1
       syscall
       add $4, $0, $13
       add $2, $0, 1
       syscall
       add $4, $0, $12
       add $2, $0, 1
       syscall
       add $4, $0, $11
       add $2, $0, 1
       syscall
       add $4, $0, $10
       add $2, $0, 1
       syscall
    
fim: addi $2, $0, 10
     syscall
    
