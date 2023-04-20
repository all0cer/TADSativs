#include <stdio.h>
 
int main(){
    int n=0, i=0, acima=0, abaixo=0;
    double media=0;
        scanf("%d", &n);
    long quant[n], qc[n], qb[n];
    for(i=0; i<n; i++){
        scanf("%ld", &quant[i]);
        media+=quant[i];
    }
    media=media/n;
    for(i=0; i<n; i++){
        if(quant[i]>=media){
            qc[acima]=quant[i];
            acima++;
        }
        else {
            qb[abaixo]=quant[i];
            abaixo++;
        }
    }
    printf("%.1f\n", media);
    printf("%ld", abaixo);
    for(i=0; i<abaixo; i++){
        printf(" %ld", qb[i]);
    }
    printf("\n");
    printf("%d", acima);
    for(i=0; i<acima; i++){
        printf(" %ld", qc[i]);
    }

    return 0;
}