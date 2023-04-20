#include <stdio.h>









int main(){
    int i=0, j=0, casos=0, qtdCarneirinhos=0;
    scanf("%d", &casos);
    
    for(i=0; i<casos; i++){ //loop até quantidade de casos
          scanf("%d", &qtdCarneirinhos);
          long carneiros[qtdCarneirinhos];
          for(j=0; j<qtdCarneirinhos; j++){ //loop ate quantidade de carneirinhos definido
                scanf("%d", &carneiros[j]);
          }
    }
}

