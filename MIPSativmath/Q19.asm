.text

main: addi $2 $0 5
      syscall
      addi $6 $0 10
      add $8 $0 $2
      div $8 $6
      mfhi $7 #1
      mflo $8
      div $8 $6
      mfhi $9 #2
      mflo $8
      div $8 $6
      mfhi $10 #3
      mflo $8
      div $8 $6
      mfhi $11 #4
      mflo $8
      div $8 $6
      mfhi $12 #5
      mflo $8
      div $8 $6
      mfhi $13 #6
      mflo $8
      div $8 $6
      mfhi $14 #7
      mflo $8 #8
      
      
      sll $9 $9 1
      add $9 $9 $7
      sll $10 $10 2
      add $9 $9 $10
      sll $11 $11 3
      add $9 $9 $11
      sll $12 $12 4
      add $9 $9 $12
      sll $13 $13 5
      add $9 $9 $13
      sll $14 $14 6
      add $9 $9 $14
      sll $8 $8 7
      add $9 $9 $8
      
      
      add $4 $0 $9
      addi $2 $0 1
      syscall
      
      
